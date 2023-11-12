
using Libreria_Jerh01.Data.Models;
using Libreria_Jerh01.Data.ViewModels;
using System;
namespace Libreria_Jerh01.Data.Services
{
    public class PublisherService
    {
        private AppDbContext _context;
        public PublisherService(AppDbContext context)
        {
            _context = context;
        }
        //metodos para agregar un nuevo Author en BD
        public void AddAuthor(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
                

            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
