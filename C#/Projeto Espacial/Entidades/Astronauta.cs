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
        public static int _Index = 1;

        public static List<Astronauta> _Astronautas = new List<Astronauta>()
        {
            new Astronauta("Marcos Pontes", new DateOnly(1963,03,11), "Brasileiro"),
            new Astronauta("George Futurama", new DateOnly(1987,11,12), "Americano"),
            new Astronauta("Turanga Futurama", new DateOnly(1999,03,27), "Americana"),
            new Astronauta("Pereira Turma da monica", new DateOnly(1990,09,22), "Brasilieiro"),
            new Astronauta("Luke Skywalker", new DateOnly(1977,05,25), "Americano"),
            new Astronauta("Laika Dog", new DateOnly(1957,11,03), "Soviética"),
            new Astronauta("Joana Almeida", new DateOnly(1885,04,17), "Mexicana")
        };
        public int Id { get; set; }
        public string Nome { get; private set; }
        public DateOnly DataNascimento { get; private set; }
        public string Nacionalidade { get; private set; }

        public Astronauta(string nome, DateOnly dataNascimento, string nacionalidade)
        {
            Id = _Index;
            Nome = nome;
            DataNascimento = dataNascimento;
            Nacionalidade = nacionalidade;

            _Index++;
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
