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



        public List<NaveEspacial> NaveEspaciais = new List<NaveEspacial>();


        public string Tripulcao { get; set; }
        public TipoNave Nave { get; set; }
        public Carga Carga { get; set; }



        public NaveEspacial(TipoNave nave, string tripulantes, Carga carga)
        {
            Nave = nave;
            Carga = carga;
        }



        public void ConfiguracaoNave()
        {

            switch (Nave)
            {
                case TipoNave.Vostok1:
                    for (int i = 0; i < solo; i++)
                    {

                    }
                    Console.WriteLine($"Nave com capacidade para apenas {solo}, e carga {Carga.CargaPequena}.");
                    break;
                case TipoNave.OnibusEspacial:
                    Console.WriteLine($"Nave com capacidade para apenas {exploracao}, e carga {Carga.CargaPequena}");
                    break;
                case TipoNave.SpaceDragon:
                    Console.WriteLine($"Nave com capacidade para apenas {transporte}, e carga {Carga.Suprimentos}.");
                    break;
                case TipoNave.StarShip:
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

        public static int NaveCapacidade(TipoNave nave)
        {
            switch (nave)
            {
                case TipoNave.Vostok1:
                    return 1;
                case TipoNave.OnibusEspacial:
                    return 2;
                case TipoNave.SpaceDragon:
                    return 5;
                case TipoNave.StarShip:
                    return 6;
                default:
                    return 0;
            }
        }
    }

}


