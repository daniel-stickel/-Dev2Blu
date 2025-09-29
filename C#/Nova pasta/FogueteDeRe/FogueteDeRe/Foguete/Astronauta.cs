using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogueteDeRe.Foguete
{
    public class Astronauta
    {


        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string PaisOrigem { get; set; }

        public static List<Astronauta> astronautas = new List<Astronauta>();

       // public static List<Astros> astros = new List<Astros>();
        public Astronauta(string nome, string dataNascimento, string paisOrigem)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            PaisOrigem = paisOrigem;
        }

        public static void CadastrarAstronauta()
        {

            Console.Write("Nome do Ex-Terraplanista:");
            string nome = Console.ReadLine();

            Console.Write("Data de nascimento (dd/mm/aaaa): ");
            string dataNascimento = Console.ReadLine();

            //if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
            //{
            //    Console.WriteLine($"Data válida: {.ToString("dd/MM/yyyy")}");
            //}
            //else
            //{
            //    Console.WriteLine("Data inválida.");
            //}


            Console.Write("Natural de qual pais: ");
            string paisOrigem = Console.ReadLine();

            var astronauta = new Astronauta(nome, dataNascimento, paisOrigem);
            astronautas.Add(astronauta);


            Console.WriteLine("Astronauta cadastrado com sucesso!");
            Console.Clear();
        }

        public static void RealizarLancamento() //esse ta errado mas ta funcionando por enquanto :)
        {
            Console.Write("Nome da Missão: ");
            string nomeMissao = Console.ReadLine();

            Console.Write("Quantidade de dias: ");
            int duracaoDias = int.Parse(Console.ReadLine());

            List<Astronauta> astronautasMissao = new List<Astronauta>();

            Console.WriteLine("Selecione os Ex-Terraplanista:");
            foreach (Astronauta astronauta in astronautas)
            {
                Console.WriteLine($"{astronauta.Nome}");
            }

            while (true)
            {
                Console.Write("Nome do Ex-Terraplanista (ou 'fim' para terminar): ");
                string nomeAstronauta = Console.ReadLine();

                if (nomeAstronauta.ToLower() == "fim")
                    break;

                foreach (Astronauta astronauta in astronautas)
                {
                    if (astronauta.Nome == nomeAstronauta)
                    {
                        astronautasMissao.Add(astronauta);
                        Console.WriteLine("Ex-Terraplanistas adicionado com sucesso!");
                        break;
                    }
                }
            }

            //static void CadastrarMissao()
            //{
            //    var missao.Astronautas = AddAStros;

            //}

        }
    }
}
