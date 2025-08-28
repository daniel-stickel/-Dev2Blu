using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class PraticaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Digite seu nome para saber sua fila:");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();
            char PrimeiraLetra = nome[0];

            switch (PrimeiraLetra)
            {
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q': 
                case 'R':
                case 'S':
                
                    System.Console.WriteLine($"{nome}, você vai ficar na primeira fila 1");
                    break;
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                    System.Console.WriteLine($"{nome}, você vai ficar na primeira fila 2");
                    break;

                case 'T':
                case 'U':
                case 'V':
                case 'X':
                case 'Y':
                case 'Z':
                    Console.WriteLine($"{nome}, você vai ficar na primeira fila 3");
                    break;
            }
        }
    }
}
