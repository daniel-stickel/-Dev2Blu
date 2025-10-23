namespace PetShoes.Model.Animais
{
    public class AnimalRequestModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int IdadeEmMeses { get; set; }
        public string TipoDeAnimal { get; set; }
        public decimal Peso { get; set; }
        public string CPF { get; set; }

    }
}

