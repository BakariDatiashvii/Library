using Library.EntityModel;
using Library.ViewModel.AutorVM;
using Library.ViewModel.MkitxveliVM;

namespace Library.ViewModel.BookVM
{
    public class GetBookVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public AddAutorVM Book_Autor { get; set; }
        public int AutorId { get; set; }
        
    }
}

