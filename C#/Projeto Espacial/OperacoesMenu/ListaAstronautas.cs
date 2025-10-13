using Projeto_espacial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.OperacoesMenu
{
    public class ListaAstronautas
    {
        public static void ListandoAstronautas() 
        {
            Console.Clear();
            Console.WriteLine("---- Lista de Astronautas ----\r\n");

            foreach( var item in Entidades.Astronauta._Astronautas)
            {
                Console.WriteLine($"\t{item.Id}- Nome: {item.Nome, -23} | Cidadania: {item.Nacionalidade,-15}");
                Thread.Sleep(100);

            }
            Util.ConsoleUtil.RetornaMenu();
        }
    }
}
