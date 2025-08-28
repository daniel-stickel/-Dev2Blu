using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class PraticaIfElse
    {
        public static void Executar()
        {
            System.Console.WriteLine("Informe o seu nome: ");
            var nome = System.Console.ReadLine();

            nome = nome.ToUpper();

            if (nome == "ANA" || nome == "MARIA" || nome == "JOÃO" || nome == "JOSÉ" || nome == "CARLOS")
            {
                System.Console.WriteLine($"Pode entrar {nome}!");
            }
            else
            {
                System.Console.WriteLine($"Desculpe {nome}, mas seu nome não está na lista!"); 

            }
        }

    }
}
