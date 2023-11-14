using Libreria_Jerh01.Data.Services;
using Libreria_Jerh01.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
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
            try
            {
                _publisherService.AddAuthor(author);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

           
        }

        [HttpGet ("get-publisher-books-with-authors/{id}")]
        public IActionResult GetPublisherData (int id)
        {
            var _response=_publisherService.GetPublisherData(id);
            return Ok(_response);
        }

        [HttpDelete("delete-publisher-by-id/{id}")]
        public IActionResult DeletePublisherById (int id)
        {
            try
            {  
                _publisherService.DeletePublisherById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
            
         }
    }
}