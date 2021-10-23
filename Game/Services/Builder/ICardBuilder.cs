using Game.Models.Card;

namespace Game.Services.Builder
{
    public interface ICardBuilder
    {
        public ICardBuilder CreateCard(int id);

        public ICardBuilder WithCardInformation(string title, string description = null);

        public ICardBuilder WithStats(int attack, int defense);

        public ICardBuilder WithEffect(IEffect effect);

        public ICard Result { get; }
    }
}
