using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class PraticaFor
    {

        public static void Executar()
        {
            

            Console.WriteLine("Digite um número para ter a tabuada");
            int N = int.Parse(Console.ReadLine());


            Console.WriteLine("TABUADA:");
            for (int i = 0;i < 11;i++)
            {
                int resultado = N * i;
                Console.WriteLine($"\n {N} x {i} =\t\t{resultado} ");
            }

            Console.ReadLine();
        }
    }
}
