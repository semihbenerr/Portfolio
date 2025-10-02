using System;

namespace MyPortfolio.WebUI.DAL.Entities
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsApproved { get; set; } = false;
        public string LinkedInUrl { get; set; }
    }
}