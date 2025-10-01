using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.Util
{
    public class ConsoleUtil
    {
        public static string RecebeString(string mensagem){

            Console.WriteLine(mensagem);
            return Console.ReadLine();
        }

        public static int RecebeInt(string mensagem)
        {
            int.TryParse(RecebeString(mensagem, out int entrada);
            return entrada;
        }


        public static DateOnly RecebeDateOnly(string prompt)
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

    }
}
