using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Projeto_espacial.Entidades.EnumType;

namespace Projeto_espacial.Entidades
{
    internal class Missao
    {

        private static int _Index = 1;
        internal static List<Missao> _Missoes = new List<Missao>()
        {
            new Missao("Populando a Lua", TipoNave.OnibusEspacial, 365, "Lua", "Povuar a lua"),
            new Missao("AgroMarte", TipoNave.StarShip, 120, "Marte", "Plantar batatas em Marte"),
            new Missao("Colheita Marte", TipoNave.SpaceDragon, 120, "Marte", "Colheita e análise das plantações"),
            new Missao("Redescobrindo Plutão", TipoNave.Vostok1, 240, "Plutão", "Analisando o solo de Plutão")
        };
        internal List<Astronauta> Tripulacao { get; set; }
        internal int Id { get; private set; }
        internal string Nome { get; set; }
        internal TipoNave Nave { get; set; }
        internal int Duracao { get; set; }
        internal string DestinoMissao { get; set; }
        internal string Detalhes { get; set; }
        internal StatusMissao Status { get; set; }

        internal Missao(string nome, TipoNave nave, int duracao, string destinoMissao, string detalhes)
        {
            Id = _Index;
            Nome = nome;
            Nave = nave;
            Duracao = duracao;
            DestinoMissao = destinoMissao;
            Detalhes = detalhes;
            Tripulacao = new List<Astronauta>();
            Status = StatusMissao.AguardandoPlanejamento;
            _Index++;
        }
    }
}

