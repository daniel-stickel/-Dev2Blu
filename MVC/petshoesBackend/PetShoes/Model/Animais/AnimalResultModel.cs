namespace PetShoes.Model.Animais
{
    public class AnimalResultModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int IdadeEmMeses { get; set; }
        public string Cor { get; set; }
        public string TipoDeAnimal { get; set; }
        public decimal Peso { get; set; }
    }

    public class AnimalRequestModel
    {
        public string Nome { get; set; }    
        public int IdadeEmMesese { get; set; }
        public string Cor { get; set; }
        public string TipoDeAnimal { get; set; }
        public decimal Peso { get; set; }
    }
}
