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
            /* new NaveEspacial(Nave.Vostok1, tripulantes, Carga.CargaPequena),
             new NaveEspacial(Nave.OnibusEspacial, Tripulantes.Exploracao, Carga.CargaMedia),
             new NaveEspacial(Nave.SpaceDragon, Tripulantes.Comercial, Carga.Suprimentos),
             new NaveEspacial(Nave.StarShip, Tripulantes.Transporte, Carga.CargaGrande)*/
        };

        public string Tripulcao { get; set; }
        public Nave Nave { get; set; }
        public Carga Carga { get; set; }



        public NaveEspacial(Nave nave, string tripulantes, Carga carga)
        {
            Nave = nave;
            Tripulantes = tripulantes;
            Carga = carga;
        }



        public void ConfiguracaoNave()
        {

            switch (Nave)
            {
                case Nave.Vostok1:
                    for (int i = 0; i < solo; i++)
                    {

                    }
                    Console.WriteLine($"Nave com capacidade para apenas {solo}, e carga {Carga.CargaPequena}.");
                    break;
                case Nave.OnibusEspacial:
                    Console.WriteLine($"Nave com capacidade para apenas {exploracao}, e carga {Carga.CargaPequena}");
                    break;
                case Nave.SpaceDragon:
                    Console.WriteLine($"Nave com capacidade para apenas {transporte}, e carga {Carga.Suprimentos}.");
                    break;
                case Nave.StarShip:
                    Console.WriteLine($"Nave com capacidade para apenas {comercial}, e carga {Carga.CargaGrande}.");
                    break;



            }

        }

        public static int GetCapacidade(TipoTripulacao tipo)
        {
            switch (tipo)
            {
                case TipoTripulacao.Solo:
                    return 1;
                case TipoTripulacao.Transporte:
                    return 2;
                case TipoTripulacao.Comercial:
                    return 5;
                case TipoTripulacao.Exploracao:
                    return 6;
                default:
                    return 0;
            }
        }

        public static int NaveCapacidade(Nave nave)
        {
            switch (nave)
            {
                case Nave.Vostok1:
                    return 1;
                case Nave.OnibusEspacial:
                    return 2;
                case Nave.SpaceDragon:
                    return 5;
                case Nave.StarShip:
                    return 6;
                default:
                    return 0;
            }
        }
    }

}


