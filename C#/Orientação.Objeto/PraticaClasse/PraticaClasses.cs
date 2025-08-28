using Orientação.Objeto.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Orientação.Objeto.PraticaClasse
{

    public class PraticaClasses
    {
        private const int TAMANHO_BARRIGA = 5;

        private int _Saciedade = 0;
        public string Nome { get; set; }

        public string NomeCientifico { get; set; }

        public int Idade { get; set; }

        public void Fome()
        {
            if (_Saciedade == TAMANHO_BARRIGA)

            {
                Console.WriteLine($"Esse {Nome} não está mais com fome");
            }
            else
            {
                Console.WriteLine($"Esse {Nome} não está mais com fome");

                _Saciedade++;
            }
        }
    }
}





