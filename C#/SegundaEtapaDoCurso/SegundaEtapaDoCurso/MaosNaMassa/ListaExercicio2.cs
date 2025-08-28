using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class ListaExercicio2
    {

        public static void Executar()
        {

            //1.Escreva um programa que peça para o usuário um número.O programa deve informar ao usuário se o número é ímpar ou par.

            Console.WriteLine("Digite um número para saber se é impar ou par:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) 
            {
                Console.WriteLine($"{numero} é impar");
            }
            else
            {
                Console.WriteLine($"{numero} é par");
            }



        }

    }
}
