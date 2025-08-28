using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pilares
{
    public class Produto
    {
        private static string Nome {get; set; }
        public static decimal Preco { get; set; }

        public Produto(string nome, decimal preco )
        {
            Nome = nome;
            Preco = preco;          
        }

        public static void AlterarNome()
        {
            Console.WriteLine("Digite o nome do produto");
            Nome = Console.ReadLine();
        }

        public static void AlterarPreco()
        {
            Console.WriteLine("Digite o valor do produto");
            Preco = int.Parse(Console.ReadLine());
        }

        public static void Exibir()
        {
            Console.WriteLine($"{Nome}, está com o preço de {Preco}");
        }

    }
}
