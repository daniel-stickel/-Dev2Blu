using PetShoes.Models.Animais;

namespace Petshoes.Models.Animais
{
    public class AnimaisResponseModel
    {
        public IEnumerable<AnimalResponseModel> Animais { get; set; }
    }
}