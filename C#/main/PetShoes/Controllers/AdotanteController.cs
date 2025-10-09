using Microsoft.AspNetCore.Mvc;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[Controler]")]
    public class AdotanteController : Controller
    {
        private static List<AdotanteController> Adotante = new List<AdotanteController>()
        {
            new AdotanteController()
            {
                Id = Guid.NewGuid(),
                Nome = "Zequinha",
                DataNascimento = "12/10/1987",
                CPF = 012.123.123-12,
                IdAnimal = AnimaisController.Animais.Id,
                NomeAnimal = AnimaisController.Animais.Nome // Professor, ta errado, eu sei. Hoje faltou tempo 
            }

        };

    }
}
