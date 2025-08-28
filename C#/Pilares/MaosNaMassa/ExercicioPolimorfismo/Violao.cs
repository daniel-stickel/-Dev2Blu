using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Pilares.MaosNaMassa.ExercicioPolimorfismo
{
    internal class Violao : Instrumentos
    {
        public Violao(string instrumeto, string tipo) : base(instrumeto, tipo)
        {
            Instrumento = instrumeto;
            Tipo = tipo;
        }

        public override void Tocar()
        {
            Console.WriteLine("O Violão faz som de violão");
        }
    }
}
