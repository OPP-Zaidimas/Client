using Game.Models.Card;
using Game.Services.Builder;

namespace Game.Services
{
    public class CardBuilder
    {
        private readonly MonsterCardBuilder _builder;

        public CardBuilder(MonsterCardBuilder builder)
        {
            _builder = builder;
        }

        public MonsterCard CreateCard(int id)
        {
            var card = _builder.CreateCard()
                .WithCardInformation($"Card {id}", "Card")
                .WithStats(id, id * 2)
                .Result;

            return card as MonsterCard;
        }
    }
}
