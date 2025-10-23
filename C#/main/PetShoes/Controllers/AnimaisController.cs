using Microsoft.AspNetCore.Mvc;
using PetShoes.Model.Animais;
using PetShoess.Database.Entidades;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimaisController : Controller
    {

        [HttpGet("")]
        public IEnumerable<AnimalResponseModel> GetAnimais()
        {
            return Animal.GetAll().Select(animal => new AnimalResponseModel(animal));
        
        }
        //    var result = new List<AnimalResponseModel>();
        //    var dadosBanco = Animal.GetAll();
        //    foreach (var animal in dadosBanco)
        //    {
        //        var animalAux = new AnimalResponseModel()
        //        {
        //            Nome = animal.Name
        //        };

        //        result.Add(animalAux);
        //    }

        //    return result;
        //}

        //[HttpPost("")]
        //public Guid PostAnimais(AnimalRequestModel animalRequest)
        //{
        //    var auxGuid = Guid.NewGuid();
        //    Animais.Add(new AnimalResponseModel()
        //    {
        //        Id = auxGuid,
        //        Nome = animalRequest.Nome,
        //        Cor = animalRequest.Cor,
        //        IdadeEmMeses = animalRequest.IdadeEmMeses,
        //        TipoDeAnimal = animalRequest.TipoDeAnimal,
        //        Peso = animalRequest.Peso

        //    });

        //    return auxGuid;
        //}

        //[HttpPut("{id}")]
        //public AnimalResponseModel PutAnimal(Guid id, AnimalRequestModel animalRequest)
        //{
        //    // Substituivel por foreach
        //    var animal = Animais.First(animalBusca => animalBusca.Id == id);

        //    animal.Nome = animalRequest.Nome;
        //    animal.Cor = animalRequest.Cor;
        //    animal.IdadeEmMeses = animalRequest.IdadeEmMeses;
        //    animal.TipoDeAnimal= animalRequest.TipoDeAnimal;
        //    animal.Peso = animal.Peso;

        //    return animal;
        //}

        //[HttpDelete("{id}")]
        //public bool DeleteAnimal(Guid id)
        //{
        //    var animal = Animais.First(animalBusca => animalBusca.Id == id);
        //    Animais.Remove(animal);

        //    return true;
        
    }
}