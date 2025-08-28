using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEtapaDoCurso.MaosNaMassa
{
    internal class PraticaDoWhile
    {
        const string SENHA = "senha";

        public static void Executar()
        {

            string recebeSenha;


            do //do-Wile é usado quando você precisa fazer algo que você precise
               //receber algo já no inicio para entrar no loop
            {
                Console.WriteLine("Digite a senha para saber se está correta!");
                recebeSenha= Console.ReadLine();

                recebeSenha = recebeSenha.ToLower(); //faz e senha ter um parametro para comparação

                if (string.IsNullOrEmpty(recebeSenha))
                {
                    Console.WriteLine("A senha não pode ser em branco");
                }
                
            } while (recebeSenha != SENHA);

            Console.Clear();
            Console.WriteLine($"\nAcertouuu!!!!!" +
                $"Login efetuado com sucesso ");
        }

    }
}
