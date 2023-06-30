using Library.EntityModel;
using Library.ViewModel.BookVM;

namespace Library.ViewModel.BookInfoVM
{
    public class GetBookInfoVM
    {
        public int Id { get; set; }
        public int Page { get; set; }

        public int Year { get; set; }
        public int Book_Id { get; set; }

        public AddBookVM Booki { get; set; }
    }
}
