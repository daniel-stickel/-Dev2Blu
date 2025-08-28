using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class PraticandoArrays
    {
        public static void Executar()
        {
            string[] nome = new string[5];
            decimal[] nota = new decimal[5];    

            System.Console.WriteLine("Digite o nome do aluno:");
            nome[0] = Console.ReadLine();

            System.Console.WriteLine("Digite o nota do aluno");
            nota[0] = decimal.Parse(Console.ReadLine());


            System.Console.WriteLine("Digite o nome do aluno:");
            nome[1] = Console.ReadLine();

            System.Console.WriteLine("Digite o nota do aluno");
            nota[1] = decimal.Parse(Console.ReadLine());


            System.Console.WriteLine("Digite o nome do aluno:");
            nome[2] = Console.ReadLine();

            System.Console.WriteLine("Digite o nota do aluno");
            nota[2] = decimal.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite o nome do aluno:");
            nome[3] = Console.ReadLine();

            System.Console.WriteLine("Digite o nota do aluno");
            nota[3] = decimal.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite o nome do aluno:");
            nome[4] = Console.ReadLine();

            System.Console.WriteLine("Digite o nota do aluno");
            nota[4] = decimal.Parse(Console.ReadLine());

            System.Console.WriteLine("Notas dos alunos");
            System.Console.WriteLine("=-=-=--=-==--=-=-=");
            System.Console.WriteLine($"{nome[0]} : \t\t\t{nota[0].ToString("F2")}");
            System.Console.WriteLine($"{nome[1]} : \t\t\t{nota[1].ToString("F2")}");
            System.Console.WriteLine($"{nome[2]} : \t\t\t{nota[2].ToString("F2")}");
            System.Console.WriteLine($"{nome[3]} : \t\t\t{nota[3].ToString("F2")}");
            System.Console.WriteLine($"{nome[4]} : \t\t\t{nota[4].ToString("F2")}");
            System.Console.WriteLine("=-=-=--=-==--=-=-=");




            //string[] nomes = new string[5];
            //string[] nomesPreenchidos = new[] { "Maria", "João", "Ana" };

            //nomes[0] = "Marco";
            //nomes[4] = "Daniel";


            //Console.WriteLine(nomes.ToString()); //Vai apresentar uma mensagem dizendo system.tostring   
            //Console.WriteLine(nomes);


        }


    }
}
