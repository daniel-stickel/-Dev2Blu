using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação.Objeto.Classes
{
    internal class Carro
    {
        public string Marca { get; set; } //get serve para que posso pegar o valor  set serve para que posso alterar o valor

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public void Acelerar() //  ISSO É UM MÉTODO   public = tipo de acesso. void = é o tipo de retorno. 
        {
            Console.WriteLine($"O está acelerando normalmente: ");

        }

        public void Acelerar(int pedal) // ISSO É UMA SOBRACARGA
        {
            if (pedal <= 5)
            {
                Console.WriteLine($"O {Modelo} está acelerendo lentamente.");
            }
            else if (pedal <= 100) 
            {
                Acelerar();// ISSO É UMA FORMA DE SOBRECARGA 
            }
            else 
            {
                Console.WriteLine($"O {Modelo} está acelerando loucamente");

            }
        }

    }
}
