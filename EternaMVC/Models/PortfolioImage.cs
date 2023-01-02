namespace EternaMVC.Models
{
    public class PortfolioImage
    {
        public int Id { get; set; }
        public int PortfolioId { get; set; }
        public string ImgUrl { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
