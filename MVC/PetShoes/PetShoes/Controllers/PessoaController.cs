using Microsoft.AspNetCore.Mvc;

namespace PetShoes.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
