namespace Library.EntityModel
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public BookInfo Book_Info { get; set; }
        public int AutorId { get; set; }
        public Autor Book_Autor { get; set; }
        public List<Book_Mkitxveli> Mkitxveli_book { get; set; }
        

    }
}
