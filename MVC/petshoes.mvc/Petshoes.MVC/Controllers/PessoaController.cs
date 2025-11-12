
using Microsoft.AspNetCore.Mvc;
using Petshoes.MVC.Models.Pessoas;
using PetShoes.Database.Entidades;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaControler : Controller
    {
        [HttpGet("")]
        public IEnumerable<PessoasResponseModel> GetPessoa()
        {
            return Pessoa.GetAllPessoa().Select(Pessoa => new PessoasResponseModel(Pessoa));
        }

        [HttpGet("{id}")]
        public PessoasResponseModel GetAnimais(int id)
        {
            return new PessoasResponseModel(Pessoa.Get(id));
        }

        [HttpPost("")]
        public int PostAnimais(PessoaRequestModel pessoaRequest)
        {
            var pessoa = pessoaRequest.GetEntidadePessoa();
            pessoa.Save();

            return pessoa.Id.Value;
        }

        [HttpPut("{id}")]
        public PessoasResponseModel PutPessoa(int id, PessoaRequestModel pessoaRequest)
        {
            var pessoa = Pessoa.Get(id);
            if (pessoa == null)
            {
                throw new Exception("Pessoa não existe!");
            }

            {
                pessoa.Nome = pessoaRequest.Nome;
                pessoa.CPF = pessoaRequest.CPF;
                pessoa.Data_Nascimento = pessoaRequest.DataNascimento;
                pessoa.Email = pessoaRequest.Email;
                pessoa.Telefone = pessoaRequest.Telefone;
                pessoa.Endereco = pessoaRequest.Endereco;
                pessoa.Tipo_Usuario = pessoaRequest.TipoUsuario;

                pessoa.Save();
                return new PessoasResponseModel(pessoa);
            }
        }

        [HttpDelete("{id}")]
        public bool DeleteAnimal(int id)
        {
            var pessoa = Pessoa.Get(id);
            if (pessoa == null)
            {
                throw new Exception("pessoa não existe!");
                //return false;
            }
            else
            {
                pessoa.Delete();
                return true;
            }
        }
    }
}

