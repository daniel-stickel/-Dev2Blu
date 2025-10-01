using Projeto_espacial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.OperacoesMenu
{
    public class CriarMissao
    {
        public static void CadastrandoMIssao()
        {

            bool continuar = false;

            do
            {
                Console.Clear();
                Console.WriteLine("-------Cadastrando Missão-------");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    continuar = false;
                }
                else
                {
                    string nome = Util.ConsoleUtil.RecebeString("Informe o nome para a Missão");
                    int Nave = Util.ConsoleUtil.RecebeInt("Escolha a Nave para a Missão\n" +
                                                                          "Digite 1 para  Vostok1\n" +
                                                                          "Digite 2 para  Onibus Espacial\n" +
                                                                          "Digite 3 para Space Dragon\n" +
                                                                          "Digite 4 para StarShip");
                    int duracao = Util.ConsoleUtil.RecebeInt("Informe o tempo necessário para a Missão");
                    string destino = Util.ConsoleUtil.RecebeString("Informe o Destino da Missão");
                    string detalhes = Util.ConsoleUtil.RecebeString("Informe detalhes da Missão");

                    var missao = new Missao(nome, duracao, destino, detalhes);
                    missao.CreateMissao();

                    Console.WriteLine($"Missão {nome} que vai usar a nave {Nave}" +
                                      $" com duração de {duracao} dias\n" +
                                      $" Destino à {destino}\n" +
                                      $" com os seguintes objetios {detalhes}\n" +
                                      ""+
                                      "------ CADASTRADA COM SUCESSO ------");

                    continuar = true;
                };

            } while (continuar);
            Projeto_espacial.ProjetoEspacial.ExecutarProjeto();

        }

    }
}
