using Game.Models.Card;

namespace Game.Services.Builder
{
    public class MonsterCardBuilder : ICardBuilder
    {
        public ICard Result { get; private set; }

        public MonsterCardBuilder() { }

        public ICardBuilder CreateCard(int id)
        {
            Result = new MonsterCard();
            Result.Id = id;

            return this;
        }

        public ICardBuilder WithCardInformation(string title, string description = null)
        {
            Result.Title = title;
            Result.Description = description;

            return this;
        }

        public ICardBuilder WithStats(int attack, int defense)
        {
            Result.Attack = attack;
            Result.Defense = defense;

            return this;
        }

        public ICardBuilder WithEffect(IEffect effect)
        {
            return this;
        }
    }
}
