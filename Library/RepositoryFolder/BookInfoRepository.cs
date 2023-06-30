using Library.DbContex;
using Library.EntityModel;
using Library.Repository;
using Library.ViewModel.BookInfoVM;

namespace Library.RepositoryFolder
{
    public class BookInfoRepository : IBookInfoRepository
    {
        public readonly LibraryDbContext _Context;
        public BookInfoRepository(LibraryDbContext context)
        {
            _Context = context;
        }

        public BookInfo createinfo(AddBookInfoVM addBookInfoVM)
        {
            var bookInfo = new BookInfo()
            {
                Page = addBookInfoVM.Page,
                Year = addBookInfoVM.Year,
                Book_Id = addBookInfoVM.Book_Id
            };
            _Context.BookInfos.Add(bookInfo);
            _Context.SaveChanges();
            return bookInfo;

        }

        public bool deleteBookInfo(int Id)
        {
            var delete = _Context.BookInfos.FirstOrDefault(x => x.Id == Id);
            if (delete == null)
            {
                return false;
            
            }

            _Context.BookInfos.Remove(delete);
            _Context.SaveChanges();
            return true;
        }
    }
}
