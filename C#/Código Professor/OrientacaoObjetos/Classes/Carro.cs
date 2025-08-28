using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public void Acelerar()
        {
            Console.WriteLine($"O {Modelo} está acelerando normalmente :)");
        }

        public void Acelerar(int pedal)
        {
            if (pedal <= 5)
            {
                Console.WriteLine($"O {Modelo} está acelerando lentamente");
            }
            else if (pedal <= 100)
            {
                Acelerar();
            }
            else
            {
                Console.WriteLine($"O {Modelo} está acelerando loucamente :P");
            }
        }
    }
}