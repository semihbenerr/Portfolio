using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.WebUI.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameSurname { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Subject { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string MessageDetail { get; set; } = string.Empty;

        public DateTime SendDate { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false; // ✅ Default false
    }
}
