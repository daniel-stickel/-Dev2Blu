using Projeto_espacial.CasdastrarAstronauta;
using Projeto_espacial.Entidades;
using Projeto_espacial.OperacoesMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial
{
    public class ProjetoEspacial
    {
        public static void ExecutarProjeto()
        {
            Console.Clear();
            Console.WriteLine("Menu Projeto espacial:\n" +
                              "1 - Cadastrar Astronautas\n" +
                              "2 - Cadastro de Nova Missão\n" +
                              "3 - Lista de Astronautas\n" +
                              "4 - Apresentar Missões\n" +
                              "4 - Atualização de lançamentos\n" +
                              "5 - Atualizar Resultado da Missão");

            try
            {
                var menuEntrada = Console.ReadLine();
                switch (menuEntrada)
                {
                    case "1":
                        CadastroAstronauta.CadAstronauta();
                        break;
                    case "2":
                        CriarMissao.CadastrandoMIssao();
                        break;
                    case "3":
                        ListaAstronautas.ListandoAstronautas();
                        break;
                    case "4":
                        ApresentarMIssoes.ApresentarMissão();
                        break;
                        /* case "5":
                         NaveEspacial.NaveAstronautas();
                         break;
                         case "3":
                         AtualizarMIssao.AtualizarResultadoMissao();
                         break;*/

                }

            }
            catch (Exception erro)
            {

            }


        }



    }
}
