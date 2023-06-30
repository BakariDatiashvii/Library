using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.MkitxveliVM;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class MkitxveliController
    {
        private readonly LibraryDbContext _conetxt;
        public readonly IMkitxveliRepository _repository;

        public MkitxveliController(LibraryDbContext context, IMkitxveliRepository repository)
        {
            _conetxt = context;
            _repository = repository;
        }

        [HttpPost("mkitxveli-create")]

        public ActionResult<Mkitxveli> saxeli (AddMkitxveliVM addMkitxveliVM)
        {
            return _repository.mkitxveliCreate(addMkitxveliVM);
        }

        [HttpGet("mkitxveli-books")]
        public ActionResult<List<GetMkitxveliVM>> saxeli ()
        {
            return _repository.mkitxvelebi();
        }

        [HttpPut("update-mkitxveli")]

        public ActionResult<Mkitxveli> saxeli (UpdateMkitxveliVM updateMkitxveliVM)
        {
            return _repository.updatemkitxveli(updateMkitxveliVM);
        }

        [HttpDelete("delete-mkitxveli")]

        public ActionResult<bool> name (int Id)
        {
            return _repository.deletemkitxveli(Id);
        }


    }
}
