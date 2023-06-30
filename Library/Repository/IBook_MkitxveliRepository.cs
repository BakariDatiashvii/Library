using Library.EntityModel;
using Library.ViewModel.Book_MkitxveliVM;
using Library.ViewModel.BookVM;

namespace Library.Repository
{
    public interface IBook_MkitxveliRepository
    {
        Book_Mkitxveli Book_MkitxveliCreate(AddBook_MkitsveliVM addBook_MkitsveliVM);

        bool deletemkitxveli(int  Id);
    }
}
