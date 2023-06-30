using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.BookInfoVM;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookInfoController : ControllerBase
    {
        private readonly LibraryDbContext _conetxt;
        public readonly IBookInfoRepository _repositorys;

        public BookInfoController(LibraryDbContext context, IBookInfoRepository repository)
        {
            _conetxt = context;
            _repositorys = repository;
        }

        [HttpPost("bookinfo-create")]

        public ActionResult<BookInfo> create(AddBookInfoVM bookInfo)
        {
            return _repositorys.createinfo(bookInfo);
        }

        [HttpDelete("delete-bookinfo")]

        public ActionResult<bool> Delete(int id)
        {
            return _repositorys.deleteBookInfo(id);
        }
    }
}
