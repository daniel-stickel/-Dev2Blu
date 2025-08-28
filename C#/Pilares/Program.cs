
//Pilares.Produto.AlterarNome();
//Pilares.Produto.AlterarPreco();
//Pilares.Produto.Exibir();
using Pilares;
using Pilares.MaosNaMassa.ExercicioPolimorfismo;

//var animais = new List<Animal>()
//{
//    new Animal("Bolinha"),
//    new Animal("Quadrado"),
//    new Animal("Tulipa")
//};

//foreach(var animal  in animais)
//{
//    animal.EmitirSom();
//}
//Console.ReadKey();

Instrumentos[] instrumento = { new Violao("", ""), new Piano("", ""), new Tambor("", "")};

foreach (var instrument in instrumento)
{
    instrument.Tocar();
};

Console.ReadLine(); 