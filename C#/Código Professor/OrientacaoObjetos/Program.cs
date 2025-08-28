using OrientacaoObjetos.Classes;
using OrientacaoObjetos.MaoNaMassa;

//var hb20 = new Carro();
//hb20.Marca = "Hyundai";
//hb20.Modelo = "HB20";
//hb20.Ano = 2012;

//var corsa = new Carro();
//corsa.Marca = "Chevrolett";
//corsa.Modelo = "Corsa";
//corsa.Ano = 1998;


//corsa.Acelerar(250);
//hb20.Acelerar(500);

//Animal doguinho = new Animal();

//doguinho.Nome = "Henrique";
//doguinho.NomeCientifico = "Dogux";
//doguinho.Idade = 2;

//for (int i = 0; i < 10; i++)
//{
//    doguinho.Comer();
//    Thread.Sleep(100);
//}

//Console.WriteLine($"Informe um novo nome para o {doguinho.Nome}");
//doguinho.Nome = Console.ReadLine();

//Console.WriteLine($"Agora ele se chama: {doguinho.Nome}");

//Livro livro = new Livro("Crepusculo", "Estefani Maier", 384);

//Livro livro2 = new Livro("Baita Livro", "Baita Autor", 8);



//var paginaAtual = 0;
//while (paginaAtual != livro.QuantidadePaginas)
//{
//    paginaAtual = livro.Ler();
//    Thread.Sleep(300);
//}

//Console.WriteLine("Você acabou de ler o livro");

//Sistema.DataInicialização = DateTime.Now;

//Console.WriteLine(Pessoa.Contagem);

//new Pessoa("Marco").Apresentar();
//Pessoa.ApresentarPessoa(new Pessoa("Joãozinho"));

//Console.WriteLine(Pessoa.Contagem);

//var aluno = new Aluno("Joãozinho", 18);


//aluno.CalcularIdadeEmMeses();
//aluno.ExibirInfo();
//aluno.ExibirInfoSb();

//var marco = new ContaBancaria("Marco");
//marco.DeclararRenda(1000);

//var joazinho = new ContaBancaria("Joãozinho", 10000);
//joazinho.DeclararRenda(4000);

//var maria = new ContaBancaria("Maria", 6000);
//maria.DeclararRenda(3000);

//joazinho.Sacar(5000);
//maria.Depositar(2000);
//marco.Depositar(250);

//Console.WriteLine(ContaBancaria.Contagem);
//Console.WriteLine(ContaBancaria.SaldoBanco);

//joazinho.SolicitarEmprestimo(53000);
//marco.SolicitarEmprestimo(5000);
//maria.SolicitarEmprestimo(500);
//maria.SolicitarEmprestimo(600 );

//var produto = new Produto("Camisa Azul", 1200);

//Produto.FormatarPreco(produto.Preco);

//Produto.FormatarPreco(produto.Preco, true);

//var produto = new Produto("Camisa Azul", 12);

//var minhaCaminha = Produto.Comprar(produto, 10, out double troco);

////minhaCaminha.ExibirInfo();
//Console.WriteLine($"Peguei {troco.ToString("C2")} de troco");



//var cestaDeCompras = new List<Produto>()
//{
//    new Produto("Coxinah", 7),
//    new Produto("Pastel", 5),
//    new Produto("Batata", 8 ),
//    new Produto("Suco", 2 ),
//    new Produto("Refri", 8),
//    new Produto("Refrigereco", 4),
//    new Produto("Coxinha", 5)
//};

//var minhasCompras = Produto.Comprar(cestaDeCompras, 10, out double troco2);

//Console.WriteLine($"Troco: {troco2}");

//if (minhasCompras != null)
//{
//    foreach (var produto in minhasCompras)
//    {
//        Console.WriteLine(produto.Nome);
//    }
//}

double n1 = 33;
double n2 = 32;
double n3 = 56;

Produto.AlterarValores(ref n1, ref n2, ref n3);

