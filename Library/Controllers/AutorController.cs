using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.AutorVM;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class AutorController : ControllerBase
    {
        private readonly LibraryDbContext _conetxt;
        public readonly IAutorRepository _repository;

        public AutorController(LibraryDbContext context, IAutorRepository repository)
        {
            _conetxt = context;
            _repository = repository;
        }

        [HttpPost("create-autor")]
        public ActionResult<Autor> ActionResult(AddAutorVM autor)
        {
            return _repository.AutorCreate(autor);
        }

        [HttpGet("autor-book")]

        public ActionResult<GetAutorVM> saxeli(int Id)
        {
            return _repository.GetAutorVM(Id);
        }

        [HttpGet("autor-book-all")]

        public ActionResult<List<GetAutorVM>> saxeli()
        {
            return _repository.GetAutorVMs();
        }
        [HttpDelete("deleteAutor-autor")]
        public ActionResult<bool> DeleteAutor(int id)
        {
            return _repository.deleteAutor(id);
        }
    }
}
