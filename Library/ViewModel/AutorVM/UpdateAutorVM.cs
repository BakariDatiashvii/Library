using Library.EntityModel;

namespace Library.ViewModel.AutorVM
{
    public class UpdateAutorVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public List<Book> Autor_Books { get; set; }
    }
}
