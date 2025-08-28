using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class PratiqueForeach
    {
        public static void Executar()
        {
            List<string> listAlunos = new List<string>();
            bool finalizar;
            string entrada;


            Console.WriteLine("DIGITE O NOME DO ALUNO E QUANDO TERMINAR DIGITE Ok");

            do
            {
                Console.WriteLine("Nome do aluno");
                entrada = Console.ReadLine();

                if (entrada.ToLower() == "ok") 
                {
                
                    finalizar = true;
                }
                

            } while (finalizar = true);
            listAlunos.ForEach(Console.WriteLine);
            int contador = 1;

            Console.Clear();
            Console.WriteLine("CADASTRADA A TURMA\n" +
                "=-=-=---=-=-==-=-=-=--");

            foreach (var aluno in listAlunos)
            {
                Console.WriteLine($"#{contador}\t {aluno}");
                contador++;
            }
            Console.WriteLine(" =-=-=---=-=-==-=-=-=--");

        }

    }
}
