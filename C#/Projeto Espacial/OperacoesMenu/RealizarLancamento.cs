using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Projeto_espacial.OperacoesMenu
{
    public class RealizarLancamento
    {
        public static void Lancamento()
        {


            if (Entidades.Astronauta._Astronautas.Count > 0)
            {
                var i = 0;

                Console.WriteLine("-------Lista de Astronautas-------\n" +
                                  "     Nome     |     Nacionalidade ");

                foreach (var item in Entidades.Astronauta._Astronautas)
                {
                    Console.WriteLine($"{i + 1} - {item.Nome}, {item.Nacionalidade}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Astronauta Cadastrado");
            }

        Projeto_espacial.ProjetoEspacial.ExecutarProjeto();
        }
    }
}
