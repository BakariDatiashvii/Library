using Library.EntityModel;
using Library.ViewModel.BookVM;
using Library.ViewModel.MkitxveliVM;

namespace Library.Repository
{
    public interface IMkitxveliRepository
    {

        Mkitxveli mkitxveliCreate(AddMkitxveliVM addMkitxveliVM);


        List<GetMkitxveliVM> mkitxvelebi();

        Mkitxveli updatemkitxveli(UpdateMkitxveliVM updateMkitxveliVM);

        bool deletemkitxveli(int Id);

    }
}
