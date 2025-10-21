using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.OperacoesMenu
{
    internal class ResultadoMissão
    {

        private static int contadorLancamentos = 0;

        internal static void ContagemLancamento()
        {
            try
            {
                Console.Clear();
                contadorLancamentos++;

                Console.WriteLine($"--- TENTATIVA DE LANÇAMENTO Nº {contadorLancamentos} ---");
                Console.WriteLine("A missão foi lançada ao espaço.\n");

                string resultadoInput;

                do
                {
                    resultadoInput = Util.ConsoleUtil.RecebeString("Se a missão foi um Sucesso digite 'S' mas se o Falhou Digite 'F'").ToUpper();

                    if (resultadoInput != "S" && resultadoInput != "F")
                    {
                        Console.WriteLine("Entrada inválida. Por favor, digite apenas 'S' ou 'F'.");
                    }

                } while (resultadoInput != "S" && resultadoInput != "F");

                Console.WriteLine();
                if (resultadoInput == "S")
                {
                    Console.WriteLine("Resultado Registrado: A MISSÃO FOI UM SUCESSO!");
                }
                else
                {
                    Console.WriteLine("Resultado Registrado: A MISSÃO FALHOU!");
                }

                Console.WriteLine("\n==========================================");
                Console.WriteLine($"Total de lançamentos realizados até agora: {contadorLancamentos}");

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            }
            catch (Exception erro)
            {
                throw new Exception($"ocorreu um erro no Resultado da Missão. Erro: {erro.Message}");
            }

            Util.ConsoleUtil.RetornaMenu();
        }
    }


}

