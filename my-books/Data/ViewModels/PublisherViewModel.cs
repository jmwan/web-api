using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels
{
    public class PublisherViewModel
    {
        public string FullName { get; set; }
    }

    public class PublisherWithBooksAndAuthorViewModel
    {
        public string Name { get; set; }
        public List<BookAuthorViewModel> BookAuthors { get; set; }
    }
    public class BookAuthorViewModel
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }
    }
}
