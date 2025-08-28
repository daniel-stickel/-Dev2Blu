using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares.MaosNaMassa.ExercicioPolimorfismo
{
    internal class Piano : Instrumentos
    {
        public Piano(string instrumento, string tipo) : base(instrumento, tipo)
        {
            Instrumento = instrumento;
            Tipo = tipo;    
        }

        public override void Tocar()
        {
            Console.WriteLine("O Piano faz Plim, Plim, Plim");
        }
    }
}
