using Projeto_espacial.Entidades;
using System;
using System.Linq;
using static Projeto_espacial.Entidades.EnumType;

namespace Projeto_espacial.OperacoesMenu
{
    internal class ListagemLancamento
    {
        internal static void MostrarLancamento()
        {
            Console.Clear();
            Console.WriteLine("==============================================\n" +
                              "==          AUTORIZAÇÃO DE LANÇAMENTO       ==\n" +
                              "==============================================\n");


            var missoesProntas = Entidades.Missao._Missoes
                .Where(m => m.Status == StatusMissao.Planejado && m.Tripulacao.Any())
                .ToList();

            if (!missoesProntas.Any())
            {
                Console.WriteLine("Nenhuma missão está pronta para lancamneto, adicione astronautas a Missão \n" +
                                  "Verifique se há missões com o status 'Planejada' e com tripulação recrutada.\n" +
                                  "\nPressione qualquer tecla para voltar ao menu...\n");
                Util.ConsoleUtil.RetornaMenu();
                return;
            }

            Console.WriteLine("Missões prontas para lançamento:\n");
            foreach (var missao in missoesProntas)
            {
                Console.WriteLine($"ID: {missao.Id} | Missão: {missao.Nome} | Tripulantes: {missao.Tripulacao.Count}");
            }

            int idMissaoEscolhida = Util.ConsoleUtil.RecebeInt("\nDigite o ID da missão que deseja lançar:");
            var missaoParaLancar = missoesProntas.FirstOrDefault(m => m.Id == idMissaoEscolhida);

            if (missaoParaLancar == null)
            {
                Console.WriteLine("\nID inválido! Lançamento abortado.");
            }
            else
            {
                missaoParaLancar.Status = StatusMissao.AguardandoPlanejamento;

                Console.Clear();
                Console.WriteLine("...Contagem regressiva...\n");
                Thread.Sleep(1500); // Pausa de 1.5 segundos para efeito dramático

                Console.WriteLine(" LANÇAMENTO REALIZADO COM SUCESSO \r\n"+
                                 $"A missão '{missaoParaLancar.Nome.ToUpper()}' está oficialmente EM CURSO.\n" +
                                 $"Data e Hora do Lançamento: {DateTime.Now}\n"+
                                  "\nBoa Sorte a Todos ");
            }
            Util.ConsoleUtil.RetornaMenu();
        }
    }
}