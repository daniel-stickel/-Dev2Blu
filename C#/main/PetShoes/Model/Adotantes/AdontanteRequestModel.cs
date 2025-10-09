namespace PetShoes.Model.Adotantes
{
    public class AdontanteRequestModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento  { get; set; }
        public int CPF { get; set; }
        public string IdAnimal { get; set; }
        public string NomeAnimal { get; set; }
    }
}
