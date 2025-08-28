using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OrientacaoObjeto.PraticaClasse
{

    public class Produto
    {

        public const int ValorLucro = 2;

        //Propriedade
        public String Nome { get; set; }
        public double Preco { get; set; }
        public double PrecoVenda { get; set; }
        private int QuantidadeEstoque { get; set; }

        //Construtor / Atalho digitar ctor
        public Produto(string nome, double preco, int quantidade, double precoVenda)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidade;
            PrecoVenda = precoVenda;
        }

        //Método
        public void AtualizarEstoque(int quantidade)
        {
            QuantidadeEstoque = quantidade;
            Console.WriteLine($"A quantidade em estoque é de {quantidade}");
        }

        private void Lucro()
        {

            double lucroTotal = ValorLucro * Preco;
            Console.WriteLine($"Total de lucro com esses produto é de {lucroTotal}");
        }


        public void ExibirInformacao()
        {
            Console.WriteLine($"Produto | Quantidade | Preço Compra \n" +
                              $" {Nome} | {QuantidadeEstoque} | {Preco}\n ");
            
        }


    }
}


