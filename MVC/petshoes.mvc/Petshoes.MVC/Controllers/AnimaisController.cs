using Microsoft.AspNetCore.Mvc;
using Petshoes.Models.Animais;
using PetShoes.Database.Entidades;
using PetShoes.Models.Animais;

namespace Petshoes.MVC.Controllers
{
    public class AnimaisController : Controller
    {
        public IActionResult Index()
        {
            var model = new AnimaisResponseModel()
            {
                Animais = Animal.GetAll().Select(i => new AnimalResponseModel(i)),
            };

            return View(model);
        }
    }
}
