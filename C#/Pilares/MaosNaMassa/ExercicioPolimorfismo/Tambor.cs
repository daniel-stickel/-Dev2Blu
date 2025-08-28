using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares.MaosNaMassa.ExercicioPolimorfismo
{
    internal class Tambor : Instrumentos
    {
        public Tambor(string instrumento, string tipo) : base(instrumento, tipo)
        {
            Instrumento = instrumento;
            Tipo = tipo;    
        }
        public override void Tocar()
        {
            Console.WriteLine("O Tambor faz TOM, TOM, TOM");;
        }
    }
}
