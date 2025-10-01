using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.Entidades
{
    public class Enum
    {
        public enum StatusMissao
        {
            Planejada,
            EmAndamento,
            Sucesso,
            Falha
        }

        public enum Tripulantes 
        {
            Solo = 1,
            Transporte = 4,
            Comercial = 5,
            Exploracao = 6
        }

        public enum Carga
        {
            CargaPequena,
            CargaMedia,
            Suprimentos,
            CargaGrande
        }

        public enum Nave
        {
            Vostok1,
            OnibusEspacial,
            SpaceDragon,
            StarShip,
        }
    }
}
