using Microsoft.AspNetCore.Routing;
using PetShoes.Database.Entidades;
using static System.Net.Mime.MediaTypeNames;

namespace PetShoes.Model.Pessoas
{
    public class PessoaRequestModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string TipoUsuario { get; set; }


        public Pessoa GetEntidadePessoa()
        {
            return new Pessoa
            {
                Nome = Nome,
                CPF = CPF,
                DataNascimento = new DateTime(),
                Email = Email,
                Telefone = Telefone,
                Endereco = Endereco,
                TipoUsuario = TipoUsuario,
            };
        }
    }
}
