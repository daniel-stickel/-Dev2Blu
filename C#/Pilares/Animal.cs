using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Pilares
{
    internal class Animal
    {
        private string v;

        public string NomeAnimal { get; set; }
        public string Barrulho { get; set; }
        public int Patas { get; set; }

        public Animal(string barrulho, string nomeAnimal, int patas)
        {
            NomeAnimal = nomeAnimal;
            Barrulho = barrulho;
            Patas = patas;
        }

        public Animal(string v)
        {
            this.v = v;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine($"O animal faz {NomeAnimal}");
            Thread.Sleep( 400 );
            Console.Write(".");

        }
    }
}
