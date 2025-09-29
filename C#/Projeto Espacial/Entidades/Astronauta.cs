using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.Entidades
{
    public class Astronauta
    {
        public static List<Astronauta> _Astronautas = new List<Astronauta>();
        public string Nome {  get ; private set; }
        public DateOnly DataNascimento { get; private set; }
        public string Nacionalidade { get; private set; }

        public Astronauta(string nome, DateOnly dataNascimento, string nacionalidade)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Nacionalidade = nacionalidade;
        }

        public void Create()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                throw new Exception("sem nome para o Astronauta, por favor digite um Nome");
            }
            _Astronautas.Add(this);
        }

    }
}
