using Microsoft.AspNetCore.Mvc;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class SystemController : Controller
    {
        [HttpGet("")]
        public bool ValidarConexao()
        {
            return PetShoess.Database.Connection.ValidarConexaoBanco();
        }
    }
}
