using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.Book_MkitxveliVM;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class Book_MkitxveliController : ControllerBase
    {

        private readonly LibraryDbContext _conetxt;
        public readonly IBook_MkitxveliRepository _repositorys;

        public Book_MkitxveliController(LibraryDbContext context, IBook_MkitxveliRepository repository)
        {
            _conetxt = context;
            _repositorys = repository;
        }

        [HttpPost("Book_Mkitxveli-create")]

        public ActionResult<Book_Mkitxveli> saxeli (AddBook_MkitsveliVM addBook_MkitsveliVM)
        {
            return _repositorys.Book_MkitxveliCreate(addBook_MkitsveliVM);
        }

        [HttpDelete("delete-Book_Mkitxveli")]

        public ActionResult<bool> DeleteBook (int id) 
        { 
            return  _repositorys.deletemkitxveli(id);    
        }

    }
}
