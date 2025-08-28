//Instrução If

// 1.Escreva um programa que peça para o usuário um número.O programa deve informar ao usuário se o número é ímpar ou par.

//Console.WriteLine("Digite um número para saber se é impar ou par:");
//int numero = int.Parse(Console.ReadLine());

//if (numero % 2 == 0)
//{
//    Console.WriteLine($"{numero} é par");
//}
//else
//{
//   Console.WriteLine($"{numero} é impar");
//}


// 2.Escreva um programa que peça ao usuário o nome e a idade. Caso o usuário seja menor de idade ou sua idade seja superior a 60 anos, o programa deve indicar que sua entrada será barrada por normas de segurança.

//Console.WriteLine("Digite o seu nome:");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite sua idade:");
//int idade = int.Parse(Console.ReadLine());


//if (idade < 18 )
//{
//    Console.WriteLine($"{nome} é menor de idade!");
//}
//else if (idade >= 18 && idade < 60)
//{
//    Console.WriteLine($"{idade} é jovem!");
//}
//else if(idade >= 60)
//{
//    Console.WriteLine($" é uma pessoa experiente!");
//}


//Instrução Switch

//1. Escreva um programa que peça ao usuário um número de 1 a 7 e após isso, retorne o dia da semana correspondente a esse número. Exemplo: 1 == “Domingo”. 7 == “Sábado”.


//Console.WriteLine("Digete um número para saber o dia da semana:");
//int dia = int.Parse(Console.ReadLine());

//switch (dia)
//{
//    case 1:
//    Console.WriteLine("Hoje é Domingo");
//        break;
//    case 2:
//        Console.WriteLine("Hoje é Segunda ");
//        break;
//    case 3:
//        Console.WriteLine("Hoje é Terça ");
//        break;
//    case 4:
//        Console.WriteLine("Hoje é Quarta ");
//        break;
//    case 5:
//        Console.WriteLine("Hoje é Quinta ");
//        break;
//    case 6:
//        Console.WriteLine("Hoje é Sexta");
//        break;
//    case 7:
//        Console.WriteLine("Hoje é Sábado");
//        break;
//    default:
//        Console.WriteLine("Dia Invalido");
//        break;
//}


//Arrays

//1. Escreva um programa que peça ao usuário 5 valores numéricos e armazene-os em um Array. Calcule a soma de todos esses números e exiba o resultado na tela.

//int[] numero = new int[5];
//int soma = 0;

//for (int i = 0; i < numero.Length; i++)
//{
//    Console.WriteLine("Digite 5 valores para ter uma soma no final:");
//    numero[i] = int.Parse(Console.ReadLine());
//    soma += numero[i];
//}

//Console.WriteLine($"O calculo da soma dos números é de {soma}");

//2. Escreva um programa que peça ao usuário 10 números e armazene-os em um Array. O programa deve identificar o maior e o menor número informado pelo usuário.

//int[] numero = new int[10];
//int menorValor = 0;
//int maiorValor = 0;

//for (int i = 0; i < numero.Length; i++)
//{
//    Console.WriteLine("Digite 10 números para saber o maior e o menor valor:");
//    numero[i] = int.Parse(Console.ReadLine());
//    menorValor = numero > maior ? numero : maior;
//    maiorValor = numero < menor ? numero : menor;

//}
//Console.WriteLine($"O menor valor é {menorValor}");
//Console.WriteLine($"O maior valor é {maiorValor}");

//3.Escreva um programa que peça ao usuário 5 nomes e armazene-os em um Array. Após isso exiba os nomes na ordem inversa da qual foram inseridos.

//string[] nomes = new string[5];


//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine("Digite 5 nomes para sejam apresentados na forma inversa");
//    nomes[i] = Console.ReadLine(); 

//      nomes[1] = nomes;
//}

//Console.WriteLine("APRESENTANDO DE FORMA INVERSA");

//for (int i = nomes.Length - 1; i >= 0; i--)
//        {
//    Console.WriteLine(nomes[i]);
//}

//Listas

//1. Escreva um programa que peça ao usuário uma quantidade indeterminada de nomes. Ao final da execução, exiba todos os nomes informados pelo usuário (Sinta-se à vontade para definir o gatilho desejado para encerrar a coleta de nomes).

//List<string> listAlunos = new List<string>();
//bool finalizar;
//string entrada;


//Console.WriteLine("INSIRA O NOME DO ALUNO E QUANDO TERMINAR DIGITE Ok");
//entrada = Console.ReadLine();

//while (entrada.ToLower() != "ok")
//{
//    Console.WriteLine("Nome do aluno");
//    entrada = Console.ReadLine();



//    listAlunos.Add(entrada);


//} 

//Console.Clear();
//Console.WriteLine("TABELAS DOS ALUNOS");

//foreach (var aluno in listAlunos)
//{
//    Console.WriteLine(aluno);
//}

//2. Escreva um programa que possua uma lista com 10 número de sua preferência, os quais devem estar entre 1 e 100. Peça para o usuário informar um número de 1 a 100 e após isso verifique se o número está presente na lista criada inicialmente. Dê três chances para o usuário acertar o máximo de números.


//List<int> listaNumero = new List<int>(1,65,45,65,27,95,84,86,91,24,70);
//int contador = 0;
//const int QUANTIDADE_TENTATIVAS = 3;

//do
//{
//    Console.WriteLine($"Digite {contador + 1} número ");
//    int entrada = int.Parse(Console.ReadLine());

//    listaNumero.Add(entrada);
//   contador++;

//} while (contador < QUANTIDADE_TENTATIVAS);

//Console.WriteLine(" Lista dos Números");
//Console.WriteLine("-=-=-=-=-=-=-=");

//foreach (int i in listaNumero)
//{
//    Console.WriteLine(i);
//}


//Instrução For

//1.Escreva um programa que peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando um loop for. Por exemplo: 5! = 5×4×3×2×1 = 120. 3! = 3×2×1 = 6. 0! = 1(por definição).

//Console.WriteLine("Digite um número positivo para saber o fatorial dele:");
//int numero = int.Parse(Console.ReadLine());

//int recebe;

//int fatorial = 1;
//fatorial = numero;

//for (recebe = numero - 1; recebe >= 1; recebe--)
//{
//    Console.WriteLine($"{fatorial} * {recebe}");

//    fatorial = fatorial * recebe;

//}

//Console.WriteLine($"\nFatorial de {numero} é {fatorial} ");


//2.Escreva um programa que peça ao usuário um número e exiba a tabuada desse número para o usuário


//Console.WriteLine("Digite um número para ter a tabuada");
//int N = int.Parse(Console.ReadLine());


//Console.WriteLine("TABUADA:");
//for (int i = 0; i < 11; i++)
//{
//    int resultado = N * i;
//    Console.WriteLine($"\n {N} x {i} =\t\t{resultado} ");
//}


//Instrução While

//1.Escreva um programa que permita ao usuário inserir números indefinidamente até que um número negativo seja inserido. O programa deve calcular e exibir a soma de todos os números positivos inseridos.

//int soma = 0;
//int numero = 0;

//Console.WriteLine("Digite números inteiros para somar e um negativo para finalizar ");

//while (numero >= 0)
//{
//    numero = int.Parse(Console.ReadLine());
//    if (numero >= 0)
//    {
//        soma += numero;
//    }
//}

//Console.WriteLine($"Somando os núemros positivos o total é de {soma}.");

//2.Escreva um programa que permita ao usuário inserir números indefinidamente e conte quantos números pares foram inseridos. O programa deve parar quando o número 0 for inserido.

//int numero;
//int pares = 0;

//Console.WriteLine("Digite quantos números desejar para ter a conta dos números pares. Para finalizar digite 0");

//while (true)
//{
//    numero = int.Parse(Console.ReadLine());

//    if (numero == 0)
//        break;

//    if (numero % 2 == 0)
//        pares++;
//}

//Console.WriteLine($"Você digitou {pares} número(s) par(es).");



//Instrução Foreach

//2. Escreva um programa que declare uma lista com 5 nomes e exiba-os em tela.


//List<string> nomes = new List<string>(); //{ "Daniel", "Daiane", "Alice", "Matheus", "Mel" };Muito fácil assim. Como o professor pediu para dar uma inclementada, usuário insere os nomes, Pode ser?


//Console.WriteLine("Digite 5 nomes para exibir ao uma lista no final:");

//int contador = 1;

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"Digite o {i} nome");
//    string nome = Console.ReadLine();
//    nomes.Add(nome);
//}

//Console.WriteLine("Lista com os 5 nomes ");

//foreach(string nome in nomes )
//{
//    Console.WriteLine($"{contador++}° Nome: {nome}.");
//}



//Instrução Do-While

//1. Escreva um programa que exiba o seguinte Menu para o usuário:


//double saldo = 1804.34;
//var opcao = "0";

//Console.WriteLine("\n   Bem vindo ao Banco +Dev2Blu, Seja Bem Vindo\n" +

//    "\n" +
//    "\n" +
//    "   1 -  Consulta de Saldo \n" +
//    "   2 -  Realizar Depósito\n" +
//    "   3 -  Realizar Saque\n" +
//    "   4 -  Sair\n" +
//    "\n" +
//    "   Seu dinheiro é Nossa Alegria ;) \n" +
//    "\n");

//do
//{
//    Console.WriteLine("Digite o valor da opção desejada");
//    opcao = Console.ReadLine();

//    if (opcao == "1")
//    {
//        Console.WriteLine($"Seu saldo é de R$ {saldo}");
//    }
//    else if (opcao == "2")
//    {
//        Console.WriteLine($"Digite o valor que deseja depositar");
//        double valor = double.Parse(Console.ReadLine());
//        saldo = valor + saldo;
//        Console.WriteLine($"Você depositou R$ {valor}" +
//            $"\nSeu saldo atual é de R$ {saldo}.");
//    }
//    else if (opcao == "3")
//    {
//        Console.WriteLine("Digite o valor que deseja sacar");
//        double valor = double.Parse(Console.ReadLine());
//        saldo = saldo - valor;
//        Console.WriteLine($"Seu saldo é de R$ {saldo}");
//    }
//} while (opcao == "4");

//Console.WriteLine($"Você escolheu a opção de sair\n" +
//    $"=-=-=-=---=-=--=--==-=-=-=-\n" +
//$"Seu saldo atual é de R$ {saldo}\n" +
//$"\n" +
//$"=-=-=-=---=-=--=--==-=-=-=-");


//double saldo = 1804.34;
//int opcao;

//Console.WriteLine("\n   Bem vindo ao Banco +Dev2Blu, Seja Bem Vindo\n" +
//    "\n" +
//    "   1 -  Consulta de Saldo \n" +
//    "   2 -  Realizar depósito\n" +
//    "   3 -  Realizar Saque\n" +
//    "   4 -  Sair\n" +
//    "\n" +
//    "DIGITE UM OPÇÂO");

//do
//{


//    string entrada = Console.ReadLine();
//    bool sucesso = int.TryParse(entrada, out opcao);

//    if (!sucesso)
//    {
//        Console.WriteLine("Entrada inválida. Por favor, digite um número de 1 a 4.");
//        continue;
//    }

//    switch (opcao)
//    {
//        case 1:
//            Console.WriteLine($"Seu saldo é de R$ {saldo}\n" +
//                "\n" +
//                "Digite uma nova opção, ou 4 para sair");
//            break;

//        case 2:

//                Console.WriteLine($"Digite o valor que deseja depositar");
//            if (double.TryParse(Console.ReadLine(), out double deposito) && deposito > 0)
//            {
//                saldo += deposito;
//                Console.WriteLine($"Você depositou R$ {deposito}\n" +
//                    $"" +
//                    $"\nSeu saldo atual é de R$ {saldo}.\n" +
//                    $"\n" +
//                    $"Digite uma nova opção, ou 4 para sair");
//            }
//            else
//            {
//                Console.WriteLine("Valor de depósito inválido.");
//            }
//            break;

//        case 3:
//            Console.Write("Digite o valor do saque: R$ ");
//            if (double.TryParse(Console.ReadLine(), out double saque) && saldo > 0)
//            {
//                if (saque <= saldo)
//                {
//                    saldo -= saque;
//                    Console.WriteLine("Saque cocluido com sucesso.\n" +
//                        $"Seu saldo é de R$ {saldo}\n" +
//                        $"\n" +
//                        "Digite uma nova opção, ou 4 para sair");
//                }
//                else
//                {
//                    Console.WriteLine("Saldo insuficiente.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Valor de saque inválido.");
//            }
//            break;

//        case 4:
//            Console.WriteLine("Você selecionou a opção de sair !\n" +
//                "\n" +
//                "   Seu dinheiro é Nossa Alegria ;)");
//            break;

//        default:
//            Console.WriteLine("Opção inválida. Tente novamente.");
//            break;
//    }

//} while (opcao != 4);