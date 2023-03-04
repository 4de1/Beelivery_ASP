namespace PP_LAB3.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        
        public Announcement(string Name, string Description, int Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price; 
        }
    }
}

