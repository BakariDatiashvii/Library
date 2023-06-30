using Library.EntityModel;

namespace Library.ViewModel.MkitxveliVM
{
    public class DeleteMkitxveliVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PiradiNomeri { get; set; }
        public List<Book_Mkitxveli> Book_mkitxveli { get; set; }
    }
}
