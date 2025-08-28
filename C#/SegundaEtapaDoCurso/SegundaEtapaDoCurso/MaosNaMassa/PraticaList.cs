using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class PraticaList
    {

        public static void Executar()

        {
            //List<string> pessoas = new List<string>();

            //pessoas.Add("Marco"); // para adicionar
            //pessoas.Add("Maria");
            //pessoas.Add("João");

            //pessoas.Remove("Maria"); // Para remover da lista



            //foreach (var pessoa in pessoas)
            //{
            //    Console.WriteLine(pessoas);
            //}

            //List<string> pessoasInicializadas = new List<string>("Marco", "Pedro", "Maria");

            //pessoasInicializadas.Add("Maria");

            //foreach (string pessoa in pessoasInicializadas)
            //{
            //    Console.WriteLine(pessoas);
            //}

            //List<string> nome = new List<string>();
            //List<double> nota  = new List<double>();

            //Console.WriteLine("Digite o nome do aluno:");
            //nome.Add(Console.ReadLine());

            //Console.WriteLine($"Digite a note do Aluno {nome}");
            //nota.Add(double.Parse(Console.WriteLine());


            //foreach (string nome in nomes)
            //{
            //    Console.WriteLine(nome);
            //}


            List<string> nomes = new List<string>();
            List<double> nota = new List<double>();


            System.Console.WriteLine("Digite o nome do aluno:");
            nomes.Add(Console.ReadLine());

            System.Console.WriteLine("Digite o nota do aluno");
            nota.Add(double.Parse(Console.ReadLine()));


            System.Console.WriteLine("Digite o nome do aluno:");
            nomes.Add(Console.ReadLine());

            System.Console.WriteLine("Digite o nota do aluno");
            nota.Add(double.Parse(Console.ReadLine()));


            System.Console.WriteLine("Digite o nome do aluno:");
            nomes.Add(Console.ReadLine());

            System.Console.WriteLine("Digite o nota do aluno");
            nota.Add(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Digite o nome do aluno:");
            nomes.Add(Console.ReadLine());

            System.Console.WriteLine("Digite o nota do aluno");
            nota.Add(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Digite o nome do aluno:");
            nomes.Add(Console.ReadLine());

            System.Console.WriteLine("Digite o nota do aluno");
            nota.Add(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Notas dos alunos");
            System.Console.WriteLine("=-=-=--=-==--=-=-=");
            System.Console.WriteLine($"{nomes[0]} : \t\t\t{nota[0].ToString("F2")}");
            System.Console.WriteLine($"{nomes[1]} : \t\t\t{nota[1].ToString("F2")}");
            System.Console.WriteLine($"{nomes[2]} : \t\t\t{nota[2].ToString("F2")}");
            System.Console.WriteLine($"{nomes[3]} : \t\t\t{nota[3].ToString("F2")}");
            System.Console.WriteLine($"{nomes[4]} : \t\t\t{nota[4].ToString("F2")}");
            System.Console.WriteLine("=-=-=--=-==--=-=-=");








        }
    }
}
