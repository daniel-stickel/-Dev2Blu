using Projeto_espacial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.OperacoesMenu
{
    public class RecrutarAstronauta
    {
        public static void RecrutaAsrtronauta()
        {

            Console.Clear();
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

            int recebeMissao = Util.ConsoleUtil.RecebeInt("Escolha a missão para recrutar os astronautas");

            var missaoSelecionada = Entidades.Missao._Missoes.FirstOrDefault(m => m.Id == recebeMissao);

            if (missaoSelecionada == null)
            {
                
                return;
            }

            int capacidade = NaveEspacial.GetCapacidade(missaoSelecionada.TipoTripulacao);

            for (int i = 0; i < NaveEspacial.NaveCapacidade; i++)
            {
                Console.Write($"Nome do Astronauta {i + 1}: ");
                string nomeAstronauta = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nomeAstronauta))
                {
                    Console.WriteLine("O nome não pode ser vazio. Tente novamente.");
                    i--;
                    continue;
                }

                missaoSelecionada.Tripulacao.Add(new Astronauta(nomeAstronauta));
            }

            Console.WriteLine("\nTripulação recrutada e adicionada à missão com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();

        }
    }
}
