using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.PraticaClasse
{


    public class ContaBancaria
    {
        private static int _Contagem = 0;
        public static int Contagem { get => _Contagem; }
        public string Titular { get; set; }
        private Decimal Saldo { get; set; }
        public TipoPessoa TipoConta { get; set; }
        

        public ContaBancaria(string titular)
        {
            Titular = titular;
            _Contagem++;
        }


        public ContaBancaria(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
            _Contagem++;
        }

        public ContaBancaria()
        {
            Saldo = Saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void ApresentaDesafio1()
        {
            int contador = Titular.Length;
            contador = contador + 1;
            Console.WriteLine($"Total de contas nesse banco {contador}\n" +
                $"Total de investimentos nesse banco\n" +
                $"");
        }

        public static void ApresentaDesfio2(decimal preco) // Método estático não instancia o objeto 
        {

            //Console.WriteLine($"{preco.Tostring("C", CultureInfo.CreateSpecificCulture("pt - BR))}");

        }

        public void Score(int nivelScore)
        {
            if (nivelScore == 0)
            { Console.WriteLine($"Seu nivel de Score Baixo"); }

            if (nivelScore == 1) 
            { Console.WriteLine($"Seu nivel de Score Médio"); };

            if (nivelScore == 2)
            { Console.WriteLine($"Seu nivel de Score é Alto");
            

        }

    }
}
