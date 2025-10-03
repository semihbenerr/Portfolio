namespace MyPortfolio.WebUI.DAL.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public string Head { get; set; }         // Company or Project Name
        public string Title { get; set; }        // Position or Role
        public string Date { get; set; }         // Time Period (e.g., "2022-2023")
        public string Description { get; set; }  // Details about the experience
        
    }
}
