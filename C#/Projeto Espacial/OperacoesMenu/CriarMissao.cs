using Projeto_espacial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.OperacoesMenu
{
    internal class CriarMissao
    {
        internal static void CadastrandoMIssao()
        {
            bool continuar = true; 
            do
            {
                try
                {

                    Console.Clear();
                    Console.WriteLine("-------Cadastrando Missão-------\n");


                    string nome = Util.ConsoleUtil.RecebeString("\r\nInforme o nome para a Missão\n");

                    int nave;

                    while (true)
                    {
                        nave = Util.ConsoleUtil.RecebeInt("\r\nEscolha a Nave para a Missão\r\n\n" +
                                                          "\tDigite 1 para  Vostok1\n" +
                                                          "\tDigite 2 para  Onibus Espacial\n" +
                                                          "\tDigite 3 para Space Dragon\n" +
                                                          "\tDiigte 4 para StarShip\n");

                        if (nave >= 1 && nave <= 4)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Digite um número entre 1 e 4.");
                        }
                    }

                    int duracao = Util.ConsoleUtil.RecebeInt("\r\nInforme o tempo necessário em dias para a Missão\n");
                    string destino = Util.ConsoleUtil.RecebeString("\r\nInforme o Destino da Missão\n");
                    string detalhes = Util.ConsoleUtil.RecebeString("\r\nInforme detalhes da Missão\n");

                    var missao = new Missao(nome, (EnumType.TipoNave)nave, duracao, destino, detalhes);
                    Missao._Missoes.Add(missao);

                    Console.Clear();
                    Console.WriteLine($"\r\tNome da Missão: {nome.ToUpper()}");
                    Thread.Sleep(400);
                    Console.WriteLine($"\tDestino: {destino}");
                    Thread.Sleep(400);
                    Console.WriteLine($"\tNave de Operação: {(EnumType.TipoNave)nave}");
                    Thread.Sleep(400);
                    Console.WriteLine($"\tDuração Estimada: {duracao} dias");
                    Thread.Sleep(400);
                    Console.WriteLine($"\tDetalhes: {detalhes}");


                    Thread.Sleep(3000);
                    Console.WriteLine("\nPressione qualquer tecla para cadastrar uma nova missão ou ESC para sair.");

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        continuar = false;
                    }
                }
                catch (Exception erro)
                {
                    throw new Exception($"ocorreu um erro na Criação da MIssão. Erro: {erro.Message}");
                }
            } while (continuar);
            Projeto_espacial.ProjetoEspacial.ExecutarProjeto();
        }
    }
}