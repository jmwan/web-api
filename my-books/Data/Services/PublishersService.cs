using my_books.Data.Model;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class PublishersService
    {
        private readonly AppDbContext _context;

        public PublishersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPublisher(PublisherViewModel publisher)
        {
            var _publisher = new Publisher()
            {
               Name = publisher.FullName
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
        
        public PublisherWithBooksAndAuthorViewModel GetPublisherData(int publisherId)
        {
            var _publisherData = _context.Publishers.Where(n => n.Id == publisherId)
                .Select(n => new PublisherWithBooksAndAuthorViewModel()
                {
                    Name = n.Name, 
                    BookAuthors = n.Books.Select(n => new BookAuthorViewModel()
                    {
                        BookName = n.Title,
                        BookAuthors = n.Book_Authors.Select(n => n.Author.FullName).ToList()
                    }).ToList()
                }).FirstOrDefault();

            return _publisherData;
        }

        public void DeletePublisherById(int id)
        {
            var _publisher = _context.Publishers.FirstOrDefault(n => n.Id == id);
            if (_publisher != null)
            {
                _context.Publishers.Remove(_publisher);
                _context.SaveChanges(true);
            }
        }
    }
}
