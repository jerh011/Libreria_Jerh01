using Libreria_Jerh01.Data.ViewModels;
using Libreria_Jerh01.Data.Models;
using Libreria_Jerh01.Data.Sercices;
using Libreria_Jerh01.Data.Services;
using Libreria_Jerh01.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Libreria_Jerh01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class AuthorsController : Controller
    {
        private AuthorsService _authorsServices;
        public AuthorsController(AuthorsService authorsServices)
        {
            _authorsServices = authorsServices;
        }
        [HttpPost("Add-author")]
        public IActionResult AddBook([FromBody] AuthorVM author)
        {
            _authorsServices.AddAuthor(author);
            return Ok();
        }

        [HttpGet("get-author-with-books-by-id/{id}")]
        public IActionResult GetAuthorWithBooks(int id)
        {
           var response= _authorsServices.GetAuthorWithBooksVM(id);
            return Ok(response);
        }


    }
}
