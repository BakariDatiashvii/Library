using Library.ViewModel.AutorVM;
using Library.ViewModel.BookInfoVM;

namespace Library.ViewModel.BookVM
{
    public class BookPiradiInf
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        
        public  AddBookInfoVM AddBookInfoVM { get; set; }
    }
}
