using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Projeto_espacial.Entidades.EnumType;

namespace Projeto_espacial.Entidades
{
    public class NaveEspacial
    {
        private const int solo = 1;
        private const int transporte = 2;
        private const int comercial = 5;
        private const int exploracao = 6;

        public List<NaveEspacial> NaveEspaciais = new List<NaveEspacial>()
        {
            new NaveEspacial(Nave.Vostok1, tripulantes, Carga.CargaPequena),
            new NaveEspacial(Nave.OnibusEspacial, Tripulantes.Exploracao, Carga.CargaMedia),
            new NaveEspacial(Nave.SpaceDragon, Tripulantes.Comercial, Carga.Suprimentos),
            new NaveEspacial(Nave.StarShip, Tripulantes.Transporte, Carga.CargaGrande)
        };

        public string Tripulantes { get; set; }
        public Nave Nave { get; set; }
        public Carga Carga { get; set; }



        public NaveEspacial(Nave nave, string tripulantes, Carga carga)
        {
            Nave = nave;
            Tripulantes = tripulantes;
            Carga = carga;
        }

        //CargaPequena,
        //CargaMedia,
        //Suprimentos,
        //CargaGrande

        //precisa organizar se a nave for ex vortok1 ele adiciona tantos astronautas e especifica o tipo de carga

        public void ConfiguracaoNave()
        {

            switch (Nave)
            {
                case Nave.Vostok1:
                     == solo && Carga.Suprimentos;
                    break;
                case Nave.OnibusEspacial:
                    == exploracao && Carga.CargaPequena;
                    break;
                case Nave.SpaceDragon:
                    == comercial && transporte && Carga.CargaMedia;
                    break;
                case Nave.StarShip:
                    == exploracao && exploracao && comercial && Carga.CargaGrande;
                    break;
            }

        }

    }

}
