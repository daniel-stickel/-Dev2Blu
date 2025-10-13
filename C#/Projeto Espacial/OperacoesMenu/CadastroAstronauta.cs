using Projeto_espacial.Entidades;
using Projeto_espacial.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_espacial.CasdastrarAstronauta
{
    public class CadastroAstronauta
    {

        public static void CadAstronauta()
        {
            bool continuar = false;

            do 
            {
                try
                {
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        continuar = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Cadastrando Nossos Astronautas");

                        string nome = Util.ConsoleUtil.RecebeString("Digite o nome do astronauta");

                        DateOnly dataNascimento = Util.ConsoleUtil.RecebeDateOnly("Digite a data de nascimento no formato dd/mm/aaaa ");

                        string nacionalidade = Util.ConsoleUtil.RecebeString("Digite a Nacionalidade do Astronauta");

                        var astronauta = new Astronauta(nome, dataNascimento, nacionalidade);
                        astronauta.Create();

                        Console.Clear();

                        Console.WriteLine($"\r\n\tCadastro do Astronauta {nome} com data de nascimento {dataNascimento} de origem {nacionalidade} cadastrado com sucesso\n");

                        Thread.Sleep(4000);
                        Console.WriteLine("\r");
                        Console.WriteLine("Digite Qualquer tecla para cadastrar mais um Astronauta, ou ESC para voltar para o menu principal");

                        continuar = true;
                    }
                }

                catch (Exception erro)
                {
                    throw new Exception($"ocorreu um erro no Cadastramento de Astronautas. Erro: {erro.Message}");
                } 
            } while (continuar);

            Projeto_espacial.ProjetoEspacial.ExecutarProjeto();
        }

    }
}
