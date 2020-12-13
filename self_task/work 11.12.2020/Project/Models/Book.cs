namespace Project.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int CountOfPages { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}