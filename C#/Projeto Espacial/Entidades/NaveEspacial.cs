using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Projeto_espacial.Entidades.TypeEnum;

namespace Projeto_espacial.Entidades
{
    public class NaveEspacial
    {
        public static List<NaveEspacial> NaveEspaciais = new List<NaveEspacial>()
        {
            new NaveEspacial(Nave.Vostok1, Tripulantes.Solo, Carga.CargaPequena),
            new NaveEspacial(Nave.OnibusEspacial, Tripulantes.Exploracao, Carga.CargaMedia),
            new NaveEspacial(Nave.SpaceDragon, Tripulantes.Comercial, Carga.Suprimentos),
            new NaveEspacial(Nave.StarShip, Tripulantes.Transporte, Carga.CargaGrande)
        };

        public Nave Nave { get; set; }
        public Tripulantes Tripulantes { get; set; }
        public Carga Carga { get; set; }

  
        public NaveEspacial(Nave nave, Tripulantes tripulantes, Carga carga)
        {
            Nave = nave;
            Tripulantes = tripulantes;
            Carga = carga;
        }


    }

}
