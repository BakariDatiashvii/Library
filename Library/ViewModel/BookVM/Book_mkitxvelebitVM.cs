using Library.EntityModel;
using Library.ViewModel.Book_MkitxveliVM;

namespace Library.ViewModel.BookVM
{
    public class Book_mkitxvelebitVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        
        public List<GetBook_MkitsveliVM> getBook_MkitsveliVM { get; set; }
    }
}
