using Projeto_espacial.CasdastrarAstronauta;
using Projeto_espacial.Entidades;
using Projeto_espacial.OperacoesMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial
{
    public class ProjetoEspacial
    {

        public static void ExecutarProjeto()
        {
            Console.Clear();
            int menuEntrada = Util.ConsoleUtil.LerNumero("Menu Projeto espacial:\n" +
                              "1 - Cadastrar Astronautas\n" +
                              "2 - Cadastro de Nova Missão\n" +
                              "3 - Lista de Astronautas\n" +
                              "4 - Apresentar Missões\n" +
                              "5 - Recrutar Astroutas para a missão \n" +
                              "6 - Atualizar Resultado da Missão\n" +
                              "7 - Sair do Menu\n");

            try
            {
 
                switch (menuEntrada)
                {
                    case 1:
                        CadastroAstronauta.CadAstronauta();
                        break;
                    case 2:
                        CriarMissao.CadastrandoMIssao();
                        break;
                    case 3:
                        ListaAstronautas.ListandoAstronautas();
                        break;
                    case 4:
                        ApresentarMIssoes.ApresentarMissão();
                        break;
                    case 5:
                        RecrutarAstronauta.RecrutaAsrtronauta();
                        break;
                    case 6:
                        ListagemLancamento.MostrarLancamento();
                        break;
                    case 7:
                        Util.ConsoleUtil.SairMenu();
                        break;
                }
            }
            catch (Exception erro)
            {
                Console.Clear();
                Console.WriteLine($"Ocorreu um erro ao executar operação!\n Mensagem: {erro.Message}");
                Console.WriteLine("Aperte qualquer tecla para voltar para o menu...");
                Console.ReadKey();
            }
            Console.ReadLine();
        }
    }
}
