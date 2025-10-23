namespace PetShoes.Model.Adotantes
{
    public class AdotanteResponseModel // Responsével pela o retorno da resposta para o FrontEnd
    {
        public Guid Id { get; set; }
        public string IdAnimal { get; set; }
        public string NomeAnimal { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string CPF { get; set; }
        public bool Ativo { get; set; }
}
    }
