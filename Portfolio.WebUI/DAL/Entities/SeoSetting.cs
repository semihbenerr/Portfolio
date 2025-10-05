namespace MyPortfolio.WebUI.DAL.Entities
{
    public class SeoSetting
    {
        public int Id { get; set; }
        public string PageName { get; set; } // Home, About, Contact vs.
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string OgTitle { get; set; } // Open Graph
        public string OgDescription { get; set; }
        public string OgImage { get; set; }
        public string TwitterCard { get; set; }
        public string CanonicalUrl { get; set; }
        public string Schema { get; set; } // JSON-LD structured data
    }

}
