using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Handlers.Services;
using ManeroWebAppMVC.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();



builder.Services.AddDbContext<LocalContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ICookieService, CookieService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
//builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<SubCategoryRepository>();
builder.Services.AddScoped<CustomerAddressRepository>();

builder.Services.AddCookiePolicy(x =>
{
    x.OnAppendCookie = options =>
    {
        options.CookieOptions.Path = "/";
        options.CookieOptions.SameSite = SameSiteMode.Strict;
        options.CookieOptions.Secure = true;
        options.CookieOptions.IsEssential = true;
    };
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

// Add services
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IOrderService, OrderService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCookiePolicy();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
