using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa
{
    public class Calculadora
    {
        public void Somar(decimal numero1, decimal numero2)
        {
            Console.WriteLine($"Resultado: {numero1 + numero2}");
        }

        public void Subtracao(decimal numero1, decimal numero2)
        {
            Console.WriteLine($"Resultado: {numero1 - numero2}");
        }

        public void Multiplicacao(decimal numero1, decimal numero2)
        {
            Console.WriteLine($"Resultado: {numero1 * numero2}");
        }

        public void Divisao(decimal numero1, decimal numero2)
        {
            Console.WriteLine($"Resultado: {numero1 / numero2}");
        }
    }
}