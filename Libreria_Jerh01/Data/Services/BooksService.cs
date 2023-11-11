using Libreria_JERH.Data.ViewModels;
using Libreria_Jerh01.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Libreria_Jerh01.Data.Sercices
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        //metodos para agregar un nuevo libro en BD
        public void AddBook(BookVM book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now

            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
      /*  //Metodo que nos permite optener una lista de todos los libros
        public List<Book> GetAllBks() => _context.Books.ToList();
        //Metodo que nos permite optener el libro que estamos pidiendo de la BD
        public Book GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.Id == bookid);
        //metodo que nos permite modificar un libro que se encuentra en la BD

        public Book UpdateBookByID(int bookid, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookid);
            if (_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.Descripcion;
                _book.IsRead = book.IsRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.Autor = book.Autor;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
        }

        public void DeleteBookbyId(int bookid)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookid);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();

            }
        }*/
    }
}
