using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares
{
    internal class Gato : Animal
    {
        public Gato(string barrulho, string nomeAnimal, int patas) : base(barrulho, nomeAnimal, patas)
        {
            Barrulho = barrulho;
            NomeAnimal = nomeAnimal;
            Patas = patas;
        }

        public void EmitirSom()
        {   
            base.EmitirSom();
            Console.WriteLine("O gato faz miau"); 
        }
    }
}
