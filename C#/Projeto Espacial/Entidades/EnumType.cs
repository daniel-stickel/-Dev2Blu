using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.Entidades
{
    public class EnumType
    {
        public enum StatusMissao
        {
            AguardandoPlanejamento,
            Planejado,
            Sucesso,
            Falha
        }

        public enum TipoTripulacao
        {
            Solo,
            Transporte,
            Comercial,
            Exploracao
        }

        public enum TipoNave {
            Vostok1,
            OnibusEspacial,
            SpaceDragon,
            StarShip 
        }

        public enum Carga { 
            CargaPequena,
            CargaMedia,
            Suprimentos,
            CargaGrande 
        }
    }

}
