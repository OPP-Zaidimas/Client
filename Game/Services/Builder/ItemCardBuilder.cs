using System.Drawing;
using Game.Models.Card;

namespace Game.Services.Builder
{
    public class ItemCardBuilder : ICardBuilder
    {
        public ICard Result => _realBuilder.Result;


        private readonly SpellCardBuilder _realBuilder;

        public ItemCardBuilder()
        {
            _realBuilder = new SpellCardBuilder();
        }

        public ICardBuilder CreateCard(int id)
        {
            return _realBuilder.CreateCard(id);
        }

        public ICardBuilder WithCardInformation(string title, string description = null)
        {
            return _realBuilder.WithCardInformation(title, description);
        }

        public ICardBuilder WithStats(int attack, int defense)
        {
            return _realBuilder.WithStats(attack, defense);
        }

        public ICardBuilder WithEffect(IEffect effect)
        {
            return _realBuilder.WithEffect(effect);
        }

        public ICardBuilder WithImage(Image image)
        {
            return _realBuilder.WithImage(image);
        }
    }
}
