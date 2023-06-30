using Library.EntityModel;
using Library.ViewModel.BookVM;

namespace Library.ViewModel.AutorVM
{
    public class GetAutorVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public List<AddBookVM> Autor_Books { get; set; }
        
    }
}
