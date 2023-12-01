using DataAccess.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ManeroWebAppMVC.Data
{
	public class DataInitializer
	{
		private readonly ApplicationDbContext _identityContext;
		private readonly LocalContext _localContext;
		private readonly UserManager<IdentityUser> _userManager;

		public DataInitializer(ApplicationDbContext identityContext, UserManager<IdentityUser> userManager, LocalContext localContext)
		{
			_identityContext = identityContext;
			_userManager = userManager;
			_localContext = localContext;
		}

		public void SeedData()
		{
			_identityContext.Database.Migrate();
			//_localContext.Database.Migrate();
			SeedRoles();
			SeedUsers();
		}

		// Här finns möjlighet att uppdatera dina användares loginuppgifter
		private void SeedUsers()
		{
			AddUserIfNotExists("johan.svensson@email.se", "BytMig123!", new string[] { "Customer" });
			AddUserIfNotExists("patrick.wernersson@email.se", "BytMig123!", new string[] { "Customer" });
		}

		// Här finns möjlighet att uppdatera dina användares roller
		private void SeedRoles()
		{
			AddRoleIfNotExisting("Customer");
		}

		private void AddRoleIfNotExisting(string roleName)
		{
			var role = _identityContext.Roles.FirstOrDefault(r => r.Name == roleName);
			if (role == null)
			{
				_identityContext.Roles.Add(new IdentityRole { Name = roleName, NormalizedName = roleName });
				_identityContext.SaveChanges();
			}
		}

		private void AddUserIfNotExists(string userName, string password, string[] roles)
		{
			if (_userManager.FindByEmailAsync(userName).Result != null) return;

			var user = new IdentityUser
			{
				UserName = userName,
				Email = userName,
				EmailConfirmed = true
			};
			_userManager.CreateAsync(user, password).Wait();
			_userManager.AddToRolesAsync(user, roles).Wait();
		}

	}

}
