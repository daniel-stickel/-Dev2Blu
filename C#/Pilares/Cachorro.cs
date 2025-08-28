using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pilares
{
    internal class Cachorro : Animal
    {
        public Cachorro(string barrulho, string nomeAnimal, int patas) : base(barrulho, nomeAnimal, patas)
        {
            Barrulho = barrulho;
            NomeAnimal = nomeAnimal;
            Patas = Patas;
        }

        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("O cachorro late: AU, AU AU ....");
        }       
    }
}
