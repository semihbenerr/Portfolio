using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.WebUI.DAL.Entities
{
    public class Portfolio
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(300)]
        public string SubTitle { get; set; } = string.Empty;

        [Url]
        public string? ImageUrl { get; set; }

        [Url]
        public string? Url { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Slug { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Technologies { get; set; } = string.Empty;

        [Url]
        public string? GithubUrl { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public int OrderIndex { get; set; } = 0;
    }
}
