using Microsoft.AspNetCore.Routing;
using PetShoes.Database.Entidades;
using static System.Net.Mime.MediaTypeNames;

namespace PetShoes.Model.Pessoas
{
    public class PessoaResponseModel

    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string TipoUsuario { get; set; }


        public PessoaResponseModel(Pessoa pessoa)
        {

            Nome = pessoa.Nome;
            CPF = pessoa.CPF;
            DataNascimento = new DateTime();
            Email = pessoa.Email;
            Telefone = pessoa.Telefone;
            Endereco = pessoa.Endereco;
            TipoUsuario = pessoa.TipoUsuario;
        }
    }
}
