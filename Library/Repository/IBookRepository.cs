using Library.EntityModel;
using Library.ViewModel.AutorVM;
using Library.ViewModel.BookVM;

namespace Library.Repository
{
    public interface IBookRepository
    {
        
        Book BookCreate(AddBookVM addBook);

        List<GetBookVM> GetBooks();  

        List<BookPiradiInf> bookPiradiInfs();


        List<Book_mkitxvelebitVM> book_MkitxvelebitVMs();

        bool deleteBook(int Id);
    }
}
