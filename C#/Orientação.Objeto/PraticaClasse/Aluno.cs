using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.PraticaClasse
{
  
    public class Aluno

    {
        private const int mes = 12;


        public string Nome {get;set;}
        public int Idade { get;set;}
        public string Matricula { get;set;}


        public Aluno(string nome, int idade, string matricula)
        {
            Nome = nome;    //Propriedade = Pararamtro;
            Idade = idade;
            Matricula = matricula;
        }

        public void CalcularIdadeEmMesses()
        {
             int recebe = Idade * mes;
            Console.WriteLine($"Esse idade do {Nome} em messes é igual {recebe}");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"\nO nome do aluno é {Nome}\n" +
                $"Sua matricula é N° {Matricula}" +
                $"idade {Idade} anos\n ");
        }

        public void ExibirInfoSB()

        {
            var sb = new StringBuilder();

            sb.AppendLine($"Presentação do aluno ");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Idade: {Idade}");
            sb.AppendLine($"Matricula: {Matricula}");
            sb.AppendLine($"");

            Console.WriteLine(StringBuilder());

        }
    }
}
