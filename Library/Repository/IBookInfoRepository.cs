using Library.EntityModel;
using Library.ViewModel.BookInfoVM;

namespace Library.Repository
{
    public interface IBookInfoRepository
    {
        BookInfo createinfo(AddBookInfoVM  addBookInfoVM);

        bool deleteBookInfo(int Id);
    }
}
