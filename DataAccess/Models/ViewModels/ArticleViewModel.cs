namespace DataAccess.Models.ViewModels
{
    public class ArticleViewModel
    {
        public Product Product { get; set; } = null!;
        public int ReviewCount { get; set; } = 0;
        public int CurrentAmount { get; set; } = 0;
        public List<Size> Sizes { get; set; } = new List<Size>();
        public List<Color> Colors { get; set; } = new List<Color>();
        public List<SizeColorCombination> Combinations { get; set; } = null!;


    }
}
