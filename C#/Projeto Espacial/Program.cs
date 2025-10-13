
using Projeto_espacial;

try
{
ProjetoEspacial.ExecutarProjeto();
}
catch(Exception erro)
{
    var mensagem = $"Erro ao executar: {erro.Message}";
    Console.WriteLine(mensagem);
}
