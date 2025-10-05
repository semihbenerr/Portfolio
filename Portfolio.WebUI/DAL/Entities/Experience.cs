using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.WebUI.DAL.Entities
{
    public class Experience
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Head { get; set; } = string.Empty; // Company Name

        [Required, MaxLength(100)]
        public string Title { get; set; } = string.Empty; // Position

        [MaxLength(50)]
        public string Date { get; set; } = string.Empty; // Display format

        [Required]
        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCurrent { get; set; } = false;

        [Url]
        public string? CompanyUrl { get; set; }

        public int OrderIndex { get; set; } = 0;

        // Yeni alanlar
        [MaxLength(100)]
        public string? CompanyLocation { get; set; }

        public ExperienceType Type { get; set; } = ExperienceType.FullTime;
    }

    public enum ExperienceType
    {
        FullTime,
        PartTime,
        Contract,
        Freelance,
        Internship
    }

}
