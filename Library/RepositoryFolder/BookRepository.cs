using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.AutorVM;
using Library.ViewModel.Book_MkitxveliVM;
using Library.ViewModel.BookInfoVM;
using Library.ViewModel.BookVM;
using Microsoft.EntityFrameworkCore;

namespace Library.RepositoryFolder
{
    public class BookRepository : IBookRepository
    {
        public readonly LibraryDbContext _Context;
        public BookRepository(LibraryDbContext context)
        {
            _Context = context;
        }

        public Book BookCreate(AddBookVM addBook)
        {
            var book = new Book()
            {

                Name = addBook.Name,
                Price = addBook.Price,
                AutorId = addBook.AutorId
            };
            _Context.Books.Add(book);
            _Context.SaveChanges();
            return book;
        }

        public List<BookPiradiInf> bookPiradiInfs()
        {
            var boooki = _Context.Books.Include(x => x.Book_Info).Select(z => new BookPiradiInf()
            {
                Id = z.Id,
                Name = z.Name,
                Price = z.Price,
                AddBookInfoVM = new AddBookInfoVM()
                {
                    Page = z.Book_Info.Page,
                    Year = z.Book_Info.Year,
                    Book_Id = z.Book_Info.Id
                }


            }).ToList();
            return boooki;
        }

        public List<Book_mkitxvelebitVM> book_MkitxvelebitVMs()
        {
            var bookinfo = _Context.Books.Include(x => x.Mkitxveli_book).ThenInclude(z => z.Mkitxveli_Mkitxveli)
                .Select(c => new Book_mkitxvelebitVM()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    getBook_MkitsveliVM = c.Mkitxveli_book.Select(x=> new GetBook_MkitsveliVM()
                    {
                        Id = x.Id,
                        BookID = x.BookID,
                        MkitxveliID = x.MkitxveliID,
                        Mkitxveli_Mkitxveli = x.Mkitxveli_Mkitxveli

                    }).ToList(),

                }).ToList();
            

            return bookinfo;
        }

        public bool deleteBook(int Id)
        {
           var delete = _Context.Books.FirstOrDefault(x => x.Id == Id);
            if (delete == null)
            {
                return false;
            }
            _Context.Books.Remove(delete);
            _Context.SaveChanges();
            return true;
        }

        public List<GetBookVM> GetBooks()
        {
            var boooki = _Context.Books.Include(x => x.Book_Autor).Select(z => new GetBookVM()
            {
                Id = z.Id,
                Name = z.Name,
                Price = z.Price,
                AutorId = z.AutorId,
                Book_Autor = new AddAutorVM()
                {
                    Age = z.Book_Autor.Age,
                    FullName = z.Book_Autor.FullName
                }

            }).ToList();



            return boooki;


        }
    }
}
