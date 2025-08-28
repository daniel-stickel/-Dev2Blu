
using FogueteDeRe.Foguete;
using System.Runtime.CompilerServices;

const string MENU = "Menu de Opções:\n" +
    "1 - Cadastrar Ex-Terraplanista \n" +
    "2 - Cadastrar missão\n" +
    // "3 - Status da Missão\n" +
    "4 - Sair";


//public static List<Astros> astros = new List<Astros>();
//List<Astronauta> astronautaslista = new List<Astronauta>();
//List<Missao> missaolista = new List<Missao>();


Console.WriteLine(MENU);
Console.Write("Escolha uma opção: ");
int opcao = int.Parse(Console.ReadLine());

do //não vai adiantar de nada, mas eu fiquei indignado com esse meu código, não finalizar e o que eu fiz reconheço agora que está tudo errado de certa forma
    
{

    switch (opcao)
    {
        case 1:
            Astronauta.CadastrarAstronauta();
            break;
        case 2:
            //Missao missao = Missao.CadastrarMissao(); // Professor tive dificuldade de entender essa logica mas quando entendi ja era tarde 
            //missao.Astronautas = AddAStros;           // infelismente não daria mais tempo para finalizar 
                                                        // iria dar certo... talvez, mas a lógica eu entendi 
                                                        // na proxima eu acerto
            //Missao.Lancar(missao); 
            Astronauta.RealizarLancamento();
            break;
        //case 3:
        //    Missao.AtualizarResultadoMissao();
        //    break;
        case 4:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
    Console.WriteLine(MENU);
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

} while (opcao != 3);



//static void Main()
//{
//    int opcao;

//    do
//    {
//        Console.WriteLine("\n===== Menu Espacial =====");
//        Console.WriteLine("1 - Cadastrar Ex-Terraplanista");
//        Console.WriteLine("5 - Sair");
//        Console.Write("Escolha uma opção: ");

//        while (!int.TryParse(Console.ReadLine(), out opcao))
//        {
//            Console.Write("Entrada inválida. Digite um número entre 1 e 5: ");
//        }

//        switch (opcao)
//        {
//            case 1:
//                CadastrarAstronauta();
//                break;
//            default:
//                Console.WriteLine("Opção inválida. Tente novamente.");
//                break;
//        }

//    } while (opcao != 5);
//}

//foreach (var astronauta in astronautas)
//{
//    Console.WriteLine(nome, datanascimento, pais);

//}


////Nasa.Exterraplanista()
