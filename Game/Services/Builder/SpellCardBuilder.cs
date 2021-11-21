using Game.Models.Card;

namespace Game.Services.Builder
{
    public class SpellCardBuilder : ICardBuilder
    {
        public ICard Result => _card;
        private SpellCard _card;

        public SpellCardBuilder() { }

        public ICardBuilder CreateCard(int id)
        {
            _card = new SpellCard
            {
                Id = id
            };

            return this;
        }

        public ICardBuilder WithCardInformation(string title, string description = null)
        {
            _card.Title = title;
            _card.Description = description;

            return this;
        }

        public ICardBuilder WithStats(int attack, int defense)
        {
            _card.Attack = attack;
            _card.Defense = defense;
            _card.CurrentHp = defense;
            return this;
        }

        public ICardBuilder WithEffect(IEffect effect)
        {
            _card.Effect = effect;
            return this;
        }
    }
}
