using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogueteDeRe.Foguete
{
    public class Nasa
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Pais { get; set; }

        public Nasa(string nome, string datanascimento, string pais)
        {
            Nome = nome;
            DataNascimento = datanascimento;
            Pais = pais;

        }

         static void List<Nasa> Exterraplanista(List<Nasa> astronautas, string nome, string datanascimento, string pais)
        {
            foreach (var astronauta in astronautas)
            {
                Console.WriteLine(nome, datanascimento, pais);

            }

        }

        public void Exterraplanista()
        {
        }




    }
}
