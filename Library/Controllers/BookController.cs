using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.BookVM;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : ControllerBase
    {
        private readonly LibraryDbContext _conetxt;
        public readonly IBookRepository _repositorys;

        public BookController(LibraryDbContext context, IBookRepository repository)
        {
            _conetxt = context;
            _repositorys = repository;
        }


        [HttpPost("create-book")]
        public ActionResult<Book> ActionResultt(AddBookVM books)
        {
            return _repositorys.BookCreate(books);
        }

        [HttpGet("vabrunebt-books-autor")]

        public ActionResult<List<GetBookVM>> getii ()
        {
            return _repositorys.GetBooks();
        }

        [HttpGet("all-book-info")]

        public ActionResult<List<BookPiradiInf>> dddd ()
        {
            return _repositorys.bookPiradiInfs();
        }

        [HttpGet("get-book-mkitxveli")]

        public ActionResult<List<Book_mkitxvelebitVM>> saxeli ()
        {
            return _repositorys.book_MkitxvelebitVMs();
        }

        [HttpDelete("delete-book")]

        public ActionResult<bool> delete (int Id)
        {
            return _repositorys.deleteBook(Id);
        }
        
    }
}
