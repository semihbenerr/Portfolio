using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.WebUI.DAL.Entities
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [MaxLength(300)]
        public string ShortDescription { get; set; } = string.Empty;

        [Url]
        public string? ImageUrl { get; set; }

        [Required]
        [MaxLength(200)]
        public string Slug { get; set; } = string.Empty;

        public int ViewCount { get; set; } = 0;
        public bool Status { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Foreign Key
        public int CategoryID { get; set; }
        public Category Category { get; set; } = null!;

        // SEO Fields
        [MaxLength(60)]
        public string? MetaTitle { get; set; }

        [MaxLength(160)]
        public string? MetaDescription { get; set; }

        [MaxLength(255)]
        public string? MetaKeywords { get; set; }
    }


}
