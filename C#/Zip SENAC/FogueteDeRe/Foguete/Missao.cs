using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogueteDeRe.Foguete
{
    public class Missao
    {
        public string Nome { get; set; }
        public List<Astronauta> Astronautas { get; set; }
        public int DuracaoDias { get; set; }
        public bool Sucesso { get; set; }
        public string Detalhes { get; set; }

        public Missao(string nome, List<Astronauta> astronautas, int duracaoDias)
        {
            Nome = nome;
            Astronautas = astronautas;
            DuracaoDias = duracaoDias;
            Sucesso = false;
            Detalhes = "";
        }


        //public static void AtualizarResultadoMissao() //usar enum para status da missão se der tempo. fracasada, parcial e sucesso
        //{
        //    Console.Write("Nome da Missão:");
        //    string nomeMissao = Console.ReadLine();

        //    foreach (Missao missao in missoes)
        //    {
        //        if (missao.Nome == nomeMissao)
        //        {
        //            Console.Write("Sucesso (S/N): ");
        //            string sucesso = Console.ReadLine();
        //            missao.Sucesso = sucesso.ToLower() == "s";

        //            Console.Write("Detalhes: ");
        //            missao.Detalhes = Console.ReadLine();

        //            Console.WriteLine("Status da missão atualizada com sucesso!");
        //        }
        //    }

        //    Console.WriteLine("status não encontrado.");
        //}
    }
}

