using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    public class Pessoa
    {
        private static int _Contagem = 0;
        public static int Contagem { get => _Contagem; }

        public string Nome { get; set; }

        public Pessoa()
        {
            _Contagem++;
        }

        public Pessoa(string nome)
        {
            _Contagem++;

            Nome = nome;
        }

        public static void ResetarContagem()
        {
            _Contagem = 0;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}!");
        }

        public static void ApresentarPessoa(Pessoa pessoa)
        {
            Console.WriteLine($"Olá meu nome é {pessoa.Nome}!");
        }
    }
}