using Pilares.MaosNaMassa.ExercicioAbstrate;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares.MaosNaMassa.ExercicioAbstrate
{
    internal class CalcularQuadrado :Forma
    {
        public  double Comprimento { get; set; }
        public  double Largura { get; set; }
        public double MetroQuadrado { get; set; }
        public CalcularQuadrado()
        {
            //MetroQuadrado = Largura * Comprimento;
            Area = medida * 2;
        }

        public CalcularQuadrado(double comprimento, double largura, double metroQuadrado)
        {
            Comprimento = comprimento;
            Largura = largura;
            MetroQuadrado = metroQuadrado;
        }
    }

    public override double CalcularPerimetro()
    {
        return $"Total de {metroQuadrado} metros quadrados";
    }
}
//public double Raio { get; set; }

//public CalcularCirculo(double raio)
//{
//    Raio = raio;
//}

//public override double CalcularPerimetro()
//{
//    return Math.PI * Raio * Raio;
//}

