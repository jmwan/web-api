using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }

        //Navigation Properties
        public List<Book_Author> Book_Authors { get; set; }
    }
}
