using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.BookVM;
using Library.ViewModel.MkitxveliVM;
using Microsoft.EntityFrameworkCore;

namespace Library.RepositoryFolder
{
    public class MkitxveliRepository : IMkitxveliRepository
    {
        public readonly LibraryDbContext _Context;
        public MkitxveliRepository(LibraryDbContext context)
        {
            _Context = context;
        }

        public bool deletemkitxveli(int Id)
        {
           var delete = _Context.Mkitxvelis.FirstOrDefault(x => x.Id == Id);
            if (delete == null)
            {
                return false;
            }

            _Context.Mkitxvelis.Remove(delete);
            _Context.SaveChanges();
            return true;
        }

        public List<GetMkitxveliVM> mkitxvelebi()
        {
            var mkitxveli = _Context.Mkitxvelis.Include(x => x.Book_mkitxveli).ThenInclude(z => z.Book_book)
                .Select(c => new GetMkitxveliVM()
                {
                    Id = c.Id,

                    Name = c.Name,

                    PiradiNomeri = c.PiradiNomeri,

                    Book_mkitxveliVM = c.Book_mkitxveli.Select(x=> new AddBookVM()
                    {
                        Name = x.Book_book.Name,
                        Price = x.Book_book.Price,
                        AutorId = x.Book_book.AutorId

                    }).ToList(),
                }).ToList();
                   
            return mkitxveli;
            
        }

        public Mkitxveli mkitxveliCreate(AddMkitxveliVM addMkitxveliVM)
        {
            var mkitxveli = new Mkitxveli()
            {
                Id = addMkitxveliVM.Id,
                Name = addMkitxveliVM.Name,
                PiradiNomeri = addMkitxveliVM.PiradiNomeri
            };
            _Context.Mkitxvelis.Add(mkitxveli);
            _Context.SaveChanges();
            return mkitxveli;
        }

        public Mkitxveli updatemkitxveli(UpdateMkitxveliVM updateMkitxveliVM)
        {
            var update = _Context.Mkitxvelis.FirstOrDefault(x=> x.Id ==  updateMkitxveliVM.Id);

            if (update == null)
            {
                return null;
            }

            var updatemkitxveli = new Mkitxveli()
            {
                
                Name = updateMkitxveliVM.Name,
                PiradiNomeri = updateMkitxveliVM.PiradiNomeri
            };

            _Context.Mkitxvelis.Update(updatemkitxveli);
            _Context.SaveChanges();
            
            return updatemkitxveli;
        }
    }
}
