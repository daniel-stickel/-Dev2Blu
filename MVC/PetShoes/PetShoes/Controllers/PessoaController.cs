
using Microsoft.AspNetCore.Mvc;
using PetShoes.Database.Entidades;
using PetShoes.Model.Pessoas;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaControler : Controller
    {
        [HttpGet("")]
        public IEnumerable<PessoaResponseModel> GetPessoa()
        {
            return Pessoa.GetAllPessoa().Select(Pessoa => new PessoaResponseModel(Pessoa));
        }

        [HttpGet("{id}")]
        public PessoaResponseModel GetAnimais(int id)
        {
            return new PessoaResponseModel(Pessoa.Get(id));
        }

        [HttpPost("")]
        public int PostAnimais(PessoaRequestModel pessoaRequest)
        {
            var pessoa = pessoaRequest.GetEntidadePessoa();
            pessoa.Save();

            return pessoa.Id.Value;
        }

        [HttpPut("{id}")]
        public PessoaResponseModel PutPessoa(int id, PessoaRequestModel pessoaRequest)
        {
            var pessoa = Pessoa.Get(id);
            if (pessoa == null)
            {
                throw new Exception("Animal não existe!");
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
                return new PessoaResponseModel(pessoa);
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

