using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares.MaosNaMassa.ExercicioPolimorfismo
{
    internal class Instrumentos // Tambor, Piano e Violão 
    {
        public string Instrumento { get; set; }  
        public string Tipo { get; set; }

        public Instrumentos(string instrumeto, string tipo)
        {
            Instrumento = instrumeto;
            Tipo = tipo;
        }

        public virtual void Tocar()
        {
            Console.WriteLine("Tocando o instrumento"); 
        }

    }


}
