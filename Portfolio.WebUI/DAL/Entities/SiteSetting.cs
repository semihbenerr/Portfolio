namespace MyPortfolio.WebUI.DAL.Entities
{
    public class SiteSetting
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }
        public string Logo { get; set; }
        public string Favicon { get; set; }
        public string GoogleAnalyticsId { get; set; }
        public string GoogleSearchConsoleId { get; set; }
        public string FacebookPixelId { get; set; }
        public string DefaultMetaTitle { get; set; }
        public string DefaultMetaDescription { get; set; }
    }

}
