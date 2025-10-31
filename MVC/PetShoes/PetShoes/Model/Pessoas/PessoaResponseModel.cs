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
        public DateTime Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Tipo_Usuario { get; set; }


        public PessoaResponseModel(Pessoa pessoa)
        {
            Nome = pessoa.Nome;
            CPF = pessoa.CPF;
            Data_Nascimento = new DateTime();
            Email = pessoa.Email;
            Telefone = pessoa.Telefone;
            Endereco = pessoa.Endereco;
            Tipo_Usuario = pessoa.Tipo_Usuario;
        }
    }
}
