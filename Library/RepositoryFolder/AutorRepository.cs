using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.AutorVM;
using Library.ViewModel.BookVM;
using Microsoft.EntityFrameworkCore;

namespace Library.RepositoryFolder
{
    public class AutorRepository : IAutorRepository
    {
        public readonly LibraryDbContext _Context;
        public AutorRepository(LibraryDbContext context)
        {
                _Context = context;
        }
        public Autor AutorCreate(AddAutorVM addAutorVM)
        {
            var autor = new Autor()
            {
                
                FullName = addAutorVM.FullName,
                Age = addAutorVM.Age
            };
            _Context.Autors.Add(autor);
            _Context.SaveChanges();

            return autor;
        }

        public bool deleteAutor(int Id)
        {
            var delete = _Context.Autors.FirstOrDefault(x => x.Id == Id);

            if (delete == null)
            {
                return false;
            }
            _Context.Autors.Remove(delete);
            _Context.SaveChanges();
            return true;
        }

        public GetAutorVM GetAutorVM(int id)
        {
            var autorr = _Context.Autors.FirstOrDefault(a => a.Id == id);

            if (autorr == null)
            {
                return null;
            }

            var getautor = new GetAutorVM()
            {
                Id = autorr.Id,
                FullName = autorr.FullName,
                Age = autorr.Age,
                Autor_Books = new List<AddBookVM>()
            }; 
            getautor.Autor_Books = _Context.Books.Where(x=> x.AutorId == autorr.Id).Select(z=> new AddBookVM()
            {
                Name = z.Name,
                Price = z.Price,
                AutorId = z.AutorId
            }).ToList();
            return getautor;
            
        }

        public List<GetAutorVM> GetAutorVMs()
        {
            var getautor = _Context.Autors.Include(x=> x.Autor_Books).Select(z=> new GetAutorVM() 
            { 
                Id = z.Id,
                FullName = z.FullName,
                Age = z.Age,
                Autor_Books = z.Autor_Books.Select(x=> new AddBookVM()
                {
                    Name= x.Name,
                    Price = x.Price,
                    AutorId= x.AutorId
                }).ToList(),

            }).ToList();
            return getautor;
        }
    }
}
