using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.WebUI.DAL.Entities
{
    public class About
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string SubDescription { get; set; } = string.Empty;

        [Required]
        public string Details { get; set; } = string.Empty;

        [MaxLength(60)]
        public string? MetaTitle { get; set; }

        [MaxLength(160)]
        public string? MetaDescription { get; set; }

        [MaxLength(255)]
        public string? MetaKeywords { get; set; }

        [Url]
        public string? ImageUrl { get; set; }

        [Url]
        public string? CVUrl { get; set; }

        [Range(0, 50)]
        public int YearsOfExperience { get; set; }

        [MaxLength(100)]
        public string? Location { get; set; }
    }


}
