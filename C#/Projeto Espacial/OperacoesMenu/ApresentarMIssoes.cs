using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.OperacoesMenu
{
    internal class ApresentarMIssoes
    {
        internal static void ApresentarMissão()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\t-------- LISTA DE MISSÕES --------\r\n");
                foreach (var item in Entidades.Missao._Missoes)
                {
                    Console.WriteLine($"\tMissão: {item.Nome,5}\n" +
                                      $"\tDestino da Missão: {item.DestinoMissao,5}\n" +
                                      $"\tNave de Operação: {item.Nave,5}\n" +
                                      $"\tTempo para Concluir: {item.Duracao,5} dias\n" +
                                      $"\tDetalhes da Missão: {item.Detalhes,5}\n");

                    Thread.Sleep(200);
                }
            }
            catch (Exception erro)
            {
                throw new Exception($"ocorreu um erro na Lista de Missões. Erro: {erro.Message}");
            }

            Util.ConsoleUtil.RetornaMenu();
        }
    }
}
