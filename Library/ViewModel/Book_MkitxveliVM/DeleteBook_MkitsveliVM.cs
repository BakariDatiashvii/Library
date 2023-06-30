using Library.EntityModel;

namespace Library.ViewModel.Book_MkitxveliVM
{
    public class DeleteBook_MkitsveliVM
    {
        public int Id { get; set; }
        public int BookID { get; set; }
        public int MkitxveliID { get; set; }
        public Book Book_book { get; set; }
        public Mkitxveli Mkitxveli_Mkitxveli { get; set; }
    }
}
