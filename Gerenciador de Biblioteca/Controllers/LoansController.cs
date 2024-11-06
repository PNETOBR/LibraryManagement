using Gerenciador_de_Biblioteca.Models;
using Gerenciador_de_Biblioteca.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_de_Biblioteca.Controllers
{
    [Route("api/Loans")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly IConfigService _configService;
        public LoansController(IConfigService configService)
        {
            _configService = configService;
        }

        [HttpPost]
        public IActionResult Post(CreateLoanInputModel model)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //GET api/loans/search="livro"
        [HttpGet]
        public IActionResult Get(string search = "")
        {
            return Ok(_configService.GetValue());
        }





    }
}
