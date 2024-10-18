namespace MyPortfolio.WebUI.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; } = "test";
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = true;
    }
}
