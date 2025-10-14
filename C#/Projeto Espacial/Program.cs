
using Projeto_espacial;

try
{
     Projeto_espacial.Util.ConsoleUtil.Tocar();
    ProjetoEspacial.ExecutarProjeto();
}
catch (Exception erro)
{
    var mensagem = $"Erro ao executar: {erro.Message}";
    Console.WriteLine(mensagem);
}
