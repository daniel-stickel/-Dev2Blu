using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.OperacoesMenu
{
    public class ApresentarMIssoes
    {
        public static void ApresentarMissão()
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

            Util.ConsoleUtil.RetornaMenu();
        }
    }
}
