namespace MyPortfolio.WebUI.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation Property
        public List<Blog> Blogs { get; set; }
    }
}
