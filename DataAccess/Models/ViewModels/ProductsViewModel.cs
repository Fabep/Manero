namespace DataAccess.Models.ViewModels
{
    public class ProductsViewModel
    {
        public string? PageTitle { get; set; }

        public List<Product>? ProductList { get; set; }

        public string? SortOrder { get; set; }
    }
}
