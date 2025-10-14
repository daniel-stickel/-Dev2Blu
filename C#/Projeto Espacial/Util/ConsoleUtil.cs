using Projeto_espacial.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_espacial.Util
{
    internal class ConsoleUtil
    {
        internal static string RecebeString(string mensagem)
        {

            Console.WriteLine(mensagem);
            return Console.ReadLine();
        }

        internal static int RecebeInt(string mensagem)
        {
            int.TryParse(RecebeString(mensagem), out int entrada);
            return entrada;
        }


        internal static DateOnly RecebeDateOnly(string prompt) // Esse método eu estava usando em mais locais onde fiz alterações, mas dicidi deixar aqui para manter a classe astronauta mais organizada e com o mesmo padrão para chamar os métodos
        {
            Console.WriteLine(prompt);

            while (true)
            {
                string? input = Console.ReadLine();

                if (DateOnly.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateOnly data))
                {
                    return data;
                }

                Console.WriteLine("Formato de data inválido. Use o formato dd/mm/aaaa.");
            }
        }

        internal static void RetornaMenu()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\n\nPressione Enter para voltar ao Menu Principal");
            }
            Projeto_espacial.ProjetoEspacial.ExecutarProjeto();
        }

        internal static void SairMenu()
        {
            Console.WriteLine(" -------- Obrigado Por Usar o PROJETO ESPACIAL -------- ");
            Environment.Exit(0);
            Thread.Sleep(5000);
            Console.ReadLine();
        }

        internal static int LerNumero(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int numero))
                {
                    return numero;
                }

                Console.WriteLine("Inválido! Por favor, digite apenas um número.");
            }
        }

        internal static void Tocar()  
        {
            SoundPlayer player = new SoundPlayer("C:\\Users\\Daniel\\Desktop\\+Dev2Blu\\-Dev2Blu\\C#\\Projeto Espacial\\Util\\Documentos\\musica.wav");
            player.Play();
        }
    }
}

