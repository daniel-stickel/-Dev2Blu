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

        private static int _Index = 1;
        public static List<Missao> _Missoes = new List<Missao>()
        {
            new Missao("Populando a Lua", TipoNave.OnibusEspacial, 365, "Lua", "Povuar a lua"),
            new Missao("AgroMarte", TipoNave.StarShip, 120, "Marte", "Plantar batatas em Marte"),
            new Missao("Colheita Marte", TipoNave.SpaceDragon, 120, "Marte", "Colheita e análise das plantações"),
            new Missao("Redescobrindo Plutão", TipoNave.Vostok1, 240, "Plutão", "Analisando o solo de Plutão")
        };
        public List<Astronauta> Tripulacao { get; set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public TipoNave Nave { get; set; }
        public int Duracao { get; set; }
        public string DestinoMissao { get; set; }
        public string Detalhes { get; set; }
        public StatusMissao Status { get; set; }

        public Missao(string nome, TipoNave nave, int duracao, string destinoMissao, string detalhes)
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

