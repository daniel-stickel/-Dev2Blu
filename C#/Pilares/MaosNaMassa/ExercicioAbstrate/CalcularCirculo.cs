using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares.MaosNaMassa.ExercicioAbstrate
{
    internal class CalcularCirculo :Forma
    {
        public double Raio { get; set; }

        public CalcularCirculo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * Raio * Raio;
        }

    }
}
