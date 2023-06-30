using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.Book_MkitxveliVM;
using System.Net;

namespace Library.RepositoryFolder
{
    public class Book_MkitxveliRepository : IBook_MkitxveliRepository
    {
        public readonly LibraryDbContext _Context;
        public Book_MkitxveliRepository(LibraryDbContext context)
        {
            _Context = context;
        }

        public Book_Mkitxveli Book_MkitxveliCreate(AddBook_MkitsveliVM addBook_MkitsveliVM)
        {
            var damateba = new Book_Mkitxveli()
            {
                BookID = addBook_MkitsveliVM.BookID,
                MkitxveliID = addBook_MkitsveliVM.MkitxveliID
            };

            var baziskavshiri = _Context.Book_Mkitxvelis.ToList();


            foreach (var item in baziskavshiri)
            {
                if (item.BookID == damateba.BookID && item.MkitxveliID == damateba.MkitxveliID)
                {
                    return null;
                }
            }
            _Context.Book_Mkitxvelis.Add(damateba);
            _Context.SaveChanges();
            return damateba;
            
        }

        public bool deletemkitxveli(int Id)
        {
            var delete = _Context.Book_Mkitxvelis.FirstOrDefault(x => x.Id == Id);

            if (delete == null)
            {
                return false;
            }
            _Context.Book_Mkitxvelis.Remove(delete);
            _Context.SaveChanges();
            return true;

        }

        
    }
}
