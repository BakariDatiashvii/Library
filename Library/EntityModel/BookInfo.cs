namespace Library.EntityModel
{
    public class BookInfo
    {
        public int Id { get; set; }
        public int Page { get; set; }

        public int Year { get; set; }
        public int Book_Id { get; set; }

        public Book Booki { get; set; }

    }
}
