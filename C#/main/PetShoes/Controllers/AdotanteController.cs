using Microsoft.AspNetCore.Mvc;

namespace PetShoes.Controllers
{
    using global::PetShoes.Model.Adotantes;
    using Microsoft.AspNetCore.Mvc;


    namespace PetShoes.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class AdotantesController : Controller
        {
            public static List<AdotanteResponseModel> Adotantes = new List<AdotanteResponseModel>
        {
            new AdotanteResponseModel
            {
                Id = Guid.NewGuid(),
                Nome = "João Silva",
                DataNascimento = "12/12/2020",
                CPF = "123.456.789-00",
                Ativo = true
            },
            new AdotanteResponseModel
            {
                Id = Guid.NewGuid(),
                Nome = "Maria Oliveira",
                DataNascimento ="14/12/2020",
                CPF = "987.654.321-00",
                Ativo = true
            }
        };

            [HttpGet]
            public IEnumerable<AdotanteResponseModel> GetAdotantes()
            {
                var adotantesAtivos = Adotantes.Where(adotantes => adotantes.Ativo).ToList();
                return adotantesAtivos;
            }

            [HttpPost("")]
            public Guid PostAdotantes(AdotanteResponseModel adotantesRequest)
            {
                var auxAdotantes = Guid.NewGuid();
                Adotantes.Add(new AdotanteResponseModel()
                {
                    Id = auxAdotantes,
                    Nome = adotantesRequest.Nome,
                    DataNascimento = adotantesRequest.DataNascimento,
                    CPF = adotantesRequest.CPF,
                    Ativo = true,
                });

                return auxAdotantes;
            }

            [HttpPut("{id}")]
            public AdotanteResponseModel PutAdotantes(Guid id, AdotanteResponseModel adotantesRequest)
            {
                var adotantes = Adotantes.First(adotantesBusca => adotantesBusca.Id == id);
                adotantes.Nome = adotantesRequest.Nome;
                adotantes.DataNascimento = adotantesRequest.DataNascimento;
                adotantes.CPF = adotantesRequest.CPF;
                adotantes.Ativo = adotantesRequest.Ativo;

                return adotantes;
            }

            [HttpPut("inativar/{id}")]
            public bool InativarAdotantes(Guid id)
            {
                var adotantes = Adotantes.First(adotantesBusca => adotantesBusca.Id == id);
                adotantes.Ativo = false;

                return true;
            }


        }
    }
}
