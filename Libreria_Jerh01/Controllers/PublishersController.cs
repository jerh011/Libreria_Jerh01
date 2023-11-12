using Libreria_Jerh01.Data.Services;
using Libreria_Jerh01.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_Jerh01.Controllers
{
    public class PublishersController : Controller
    {
        private PublisherService _publisherService;
        public PublishersController(PublisherService publisherService)
        {
            _publisherService = publisherService;
        }
        [HttpPost("Add-publisher")]
        public IActionResult Addublisher([FromBody] PublisherVM author)
        {
            _publisherService.AddAuthor(author);
            return Ok();
        }

    }
}