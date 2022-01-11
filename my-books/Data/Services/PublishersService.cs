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
    }
}
