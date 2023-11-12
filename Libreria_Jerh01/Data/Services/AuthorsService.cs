
using Libreria_Jerh01.Data.Models;
using Libreria_Jerh01.Data.ViewModels;
using System;
namespace Libreria_Jerh01.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        //metodos para agregar un nuevo Author en BD
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
                

            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
