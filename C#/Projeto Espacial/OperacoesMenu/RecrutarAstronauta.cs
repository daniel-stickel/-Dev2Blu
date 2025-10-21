using Projeto_espacial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Projeto_espacial.Entidades.EnumType;

namespace Projeto_espacial.OperacoesMenu
{
    public class RecrutarAstronauta
    {
        internal static void RecrutaAsrtronauta()
        {

            try
            {

                Console.Clear();
                int recebeMissao;
                Missao missaoSelecionada;

                do
                {
                    try
                    {
                        Console.WriteLine("\t-------- LISTA DE MISSÕES --------\r\n");
                        foreach (var item in Entidades.Missao._Missoes)
                        {
                            Console.WriteLine($"INDICE DA MISSÃO = {item.Id} \r\n" +
                                              $"\tMissão: {item.Nome,5}\n" +
                                              $"\tDestino da Missão: {item.DestinoMissao,5}\n" +
                                              $"\tNave de Operação: {item.Nave,5}\n" +
                                              $"\tTempo para Concluir: {item.Duracao,5} dias\n" +
                                              $"\tDetalhes da Missão: {item.Detalhes,5}\n");

                        }

                        recebeMissao = Util.ConsoleUtil.RecebeInt("Escolha a missão e digite o N° do indice para recrutar os astronautas para a missão:");
                        missaoSelecionada = Entidades.Missao._Missoes.FirstOrDefault(missao => missao.Id == recebeMissao);

                        if (missaoSelecionada == null)
                        {
                            Console.WriteLine("\n ID de missão inválido. Pressione qualquer tecla para tentar novamente.");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception erro)
                    {
                        throw new Exception($"ocorreu um erro na Escolha da Missão. Erro: {erro.Message}");
                    }
                } while (missaoSelecionada == null);


                if (missaoSelecionada != null)
                {
                    Console.Clear();
                    Console.WriteLine($"--- Recrutando para a Missão: {missaoSelecionada.Nome.ToUpper()} ---\n");
                    Console.WriteLine($"Nave : {missaoSelecionada.Nave}");

                    int capacidadeDaNave = 0;

                    switch (missaoSelecionada.Nave)
                    {
                        case TipoNave.Vostok1:
                            capacidadeDaNave = 1;
                            break;
                        case TipoNave.OnibusEspacial:
                            capacidadeDaNave = 4;
                            break;
                        case TipoNave.SpaceDragon:
                            capacidadeDaNave = 5;
                            break;
                        case TipoNave.StarShip:
                            capacidadeDaNave = 6;
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine($"Capacidade da Nave: {capacidadeDaNave} astronautas\n" +
                                       "-------------------------------------------------");

                    if (capacidadeDaNave > 0) // pode ter uma forma muito mais fácil de fazer isso, mas funciona. VOU VIVER 3 ANOS A MENOS POR CAUSA DESSE IF
                    {
                        for (int i = 0; i < capacidadeDaNave; i++)
                        {
                            Console.WriteLine($"\nAdicionando tripulante {i + 1} de {capacidadeDaNave}:");
                            Console.WriteLine("--- ASTRONAUTAS DISPONÍVEIS ---");

                            var astronautasDisponiveis = Astronauta._Astronautas
                                .Where(astronauta => !missaoSelecionada.Tripulacao.Contains(astronauta))
                                .ToList(); // testado

                            if (!astronautasDisponiveis.Any())
                            {
                                Console.WriteLine("Não há mais astronautas disponíveis para recrutar.");
                                break;
                            }

                            foreach (var astronauta in astronautasDisponiveis)
                            {
                                Console.WriteLine($"ID: {astronauta.Id} | Nome: {astronauta.Nome} | Nacionalidade: {astronauta.Nacionalidade}");
                            }

                            int idAstronauta = Util.ConsoleUtil.RecebeInt("\nDigite o ID do astronauta para adicionar à missão:");

                            var astronautaEscolhido = astronautasDisponiveis.FirstOrDefault(a => a.Id == idAstronauta);

                            if (astronautaEscolhido != null)
                            {
                                missaoSelecionada.Tripulacao.Add(astronautaEscolhido);
                                Console.WriteLine($"SUCESSO: {astronautaEscolhido.Nome} foi adicionado à missão '{missaoSelecionada.Nome}");
                            }
                            else
                            {
                                Console.WriteLine("Erro, ID do astronauta inválido ou já adicionado. Tente novamente.");
                                i--;
                            }
                        } //testado



                        Console.WriteLine("\n--- TRIPULAÇÃO FINAL ---");
                        foreach (var tripulante in missaoSelecionada.Tripulacao)
                        {
                            Console.WriteLine($"- {tripulante.Nome}");
                        } // testado

                        Console.WriteLine("-------------------------");
                        Console.Clear();
                        Console.WriteLine("==============================================\n" +
                                          $" MISSÃO CONFIGURADA COM SUCESSO!\n" +
                                          $"==============================================\n" +
                                          $"\n--- RESUMO COMPLETO DA MISSÃO ---\n");

                        Console.WriteLine($"INDICE DA MISSÃO: {missaoSelecionada.Id}\n" +
                                          $"\tNome da Missão: {missaoSelecionada.Nome.ToUpper()}\n" +
                                          $"\tDestino: {missaoSelecionada.DestinoMissao} \n" +
                                          $"\tNave de Operação: {missaoSelecionada.Nave} \n" +
                                          $"\tDuração Estimada: {missaoSelecionada.Duracao} dias\n" +
                                          $"\tDetalhes: {missaoSelecionada.Detalhes}");

                        Console.WriteLine("\n\t--- Tripulação Recrutada ---");

                        if (missaoSelecionada.Tripulacao.Any())
                        {
                            foreach (var tripulante in missaoSelecionada.Tripulacao)
                            {
                                Console.WriteLine($"\t- {tripulante.Nome} ({tripulante.Nacionalidade})");
                            }

                        }
                        else
                        {
                            Console.WriteLine("\tNenhum astronauta foi recrutado para esta missão.");
                        }
                        Console.WriteLine("\n=============================================="); // testado
                    }
                }
                else
                {
                    Console.WriteLine($"\nNenhuma missão encontrada com o Id {recebeMissao}.");
                } // testado


                missaoSelecionada.Status = StatusMissao.Planejado;
            }
            catch (Exception erro)
            {
                throw new Exception($"Ocorreu um erro no Recrutamento dos Astronautas. Erro: {erro.Message}");
            }

            Util.ConsoleUtil.RetornaMenu();
        }
    }
}