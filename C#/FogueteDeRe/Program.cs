using FogueteDeRe.Foguete;
using System.Collections.Generic;

List<Nasa> astronauta = new List<Nasa>();
string continua;

do
{
    Nasa nasa = new Nasa();

    Console.WriteLine("Digite o nome do futuro Ex-terraplanista");
    nasa.Nome = Console.ReadLine();

    Console.WriteLine("Digite a data Ex-terraplanista ");
    nasa.DataNascimento = Console.ReadLine();

    Console.WriteLine("Pais de naturalidade do Ex-terraplanista");
    nasa.Pais = Console.ReadLine();

    Console.WriteLine("Para parar de adicionar digite qualquer letra");
    continua = Console.ReadLine();


    astronauta.Add(nasa);
}
while (continua == " ");


//Nasa.Exterraplanista()
