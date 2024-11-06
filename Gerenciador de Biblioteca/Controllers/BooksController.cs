using Gerenciador_de_Biblioteca.Models;
using Gerenciador_de_Biblioteca.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_de_Biblioteca.Controllers
{

    [Route("api/Books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IConfigService _configService;
        public BooksController(IConfigService configService)
        {
            _configService = configService;
        }
        //get api/projects/search=crm
        [HttpGet]
        public IActionResult Get(string search = "")
        {
            //throw new NotImplementedException();

            return Ok(_configService.GetValue());
        }

        //get api/books/123
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]

        public IActionResult Post(CreateBookInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
