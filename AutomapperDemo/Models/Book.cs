namespace AutomapperDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? Created { get; set; }
        public DateTime?Updated { get; set; }
    }

    
}
