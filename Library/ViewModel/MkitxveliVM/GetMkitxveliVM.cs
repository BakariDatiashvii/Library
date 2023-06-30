using Library.EntityModel;
using Library.ViewModel.BookVM;

namespace Library.ViewModel.MkitxveliVM
{
    public class GetMkitxveliVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PiradiNomeri { get; set; }
        public List<AddBookVM> Book_mkitxveliVM { get; set; }
    }
}
