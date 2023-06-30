using Library.EntityModel;
using Library.RepositoryFolder;
using Library.ViewModel.AutorVM;
using Library.ViewModel.BookVM;

namespace Library.Repository
{
    public interface IAutorRepository 
    {
        Autor AutorCreate(AddAutorVM addAutorVM);

        List<GetAutorVM> GetAutorVMs();

        GetAutorVM GetAutorVM(int id);

        bool deleteAutor(int Id);
    }
}
