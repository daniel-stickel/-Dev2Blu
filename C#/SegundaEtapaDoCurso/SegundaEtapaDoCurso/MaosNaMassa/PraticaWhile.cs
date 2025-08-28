using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class PraticaWhile
    {
        public static void Executar()
        {

            double maior = double.MinValue;
            double menor = double.MaxValue;

            Console.WriteLine("Me informe um número, ou Ok para sair:");
            string entrada = Console.ReadLine();

            while (entrada.ToLower() != "ok")
            {

                var valor = double.Parse(entrada);

                maior = valor > maior ? valor : maior;
                menor = valor < menor ? valor : menor;

                Console.WriteLine("Me informe um número, ou Ok para sair:");
                entrada = Console.ReadLine();

            }

            Console.WriteLine("Terminamos aqui");
            Console.WriteLine($"Menor: {menor}");
            Console.WriteLine($"Maior: {maior}");
        }

    }
}
