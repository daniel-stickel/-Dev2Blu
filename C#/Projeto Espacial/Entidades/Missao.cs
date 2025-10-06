using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Projeto_espacial.Entidades.EnumType;

namespace Projeto_espacial.Entidades
{
    public class Missao
    {
        public static List<Missao> _Missoes = new List<Missao>()
        {
            new Missao("Populando a Lua", Nave.OnibusEspacial, 365, "Lua", "Povuar a lua"),
            new Missao("AgroMarte", Nave.StarShip, 120, "Marte", "Plantar batatas em Marte"),
            new Missao("Colheita Marte", Nave.SpaceDragon, 120, "Marte", "Colheita e análise das plantações"),
            new Missao("Redescobrindo Plutão", Nave.Vostok1, 240, "Plutão", "Analisando o solo de Plutão")
        };

        public string Nome { get; set; }
        public Nave Nave { get; set; }
        public int Duracao { get; set; }
        public string DestinoMissao { get; set; }
        public string Detalhes { get; set; }
        public StatusMissao StatusMissao { get; set; }

        public Missao(string nome, Nave nave, int duracao, string destinoMissao, string detalhes)
        {
            Nome = nome;
            Nave = nave;
            Duracao = duracao;
            DestinoMissao = destinoMissao;
            Detalhes = detalhes;

        }

        //public void CreateMissao()
        //{
        //    if (string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(DestinoMissao) || string.IsNullOrEmpty(Detalhes) || Duracao != null)
        //    {
        //        throw new Exception("Você deixou algum campo em branco, por favor verifique.");
        //    }
        //    _Missoes.Add(this);
    }

}

