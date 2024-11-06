using Gerenciador_de_Biblioteca.ExceptionHandler;
using Gerenciador_de_Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_de_Biblioteca.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {

            return Ok();
        }

    }
}
