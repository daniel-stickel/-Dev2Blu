using Microsoft.AspNetCore.Mvc;
using PetShoes.Model.Animais;

namespace PetShoes.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AnimaisController : Controller
    {
        private static List<AnimalResultModel> Animais = new List<AnimalResultModel>()
        {
                new AnimalResultModel()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Pedrinho",
                    IdadeEmMeses = 8,
                    Cor = "Cinza",
                    TipoDeAnimal = "Gato",
                    Peso = 2.100M

                },

                new AnimalResultModel()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Jocão",
                    IdadeEmMeses = 8,
                    Cor = "Caramelo",
                    TipoDeAnimal = "Cachorro",
                    Peso = 8.350M
                },

                new AnimalResultModel()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Pepa",
                    IdadeEmMeses = 9,
                    Cor = "Pardo",
                    TipoDeAnimal = "Porco",
                    Peso = 100
                }

        };

        [HttpGet]
        public IEnumerable<AnimalResultModel> GetAnimais()
        {
            return Animais;
        }

        [HttpPost]
        public Guid PostAnimal(AnimalResultModel animal)
        {
            var animalAux = new AnimalResultModel()
            {
                Id = Guid.NewGuid(),
                Cor = animal.Cor,
                IdadeEmMeses = animal.IdadeEmMeses,
                Nome = animal.Nome,
                TipoDeAnimal= animal.TipoDeAnimal,
                Peso= animal.Peso

            };

            Animais.Add(animalAux);
            return animalAux.Id;    

        }

        [HttpGet("id")]
        public AnimalResultModel PutAnimal(Guid id, AnimalRequestModel animal)
        {
            var animalAux = Animais.First(animal => Id == id);

        }

    }
}
