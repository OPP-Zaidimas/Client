using System;
using Game.Models.Card;
using Game.Services.Builder;

namespace Game.Services
{
    public class CardBuilder
    {
        private readonly MonsterCardBuilder _builder;

        private readonly (string, string, int, int)[] _cardInfo =
        {
            new("Card 1", "Card", 1, 1),
            new("Card 2", "Card", 2, 3),
            new("Card 3", "Card", 3, 1),
            new("Card 4", "Card", 2, 2),
            new("Card 5", "Card", 0, 3),
        };

        private static (string, string, int, int) DefaultCard => ("Default", "Placeholder", 1, 1);

        public CardBuilder(MonsterCardBuilder builder)
        {
            _builder = builder;
        }

        public MonsterCard CreateCard(int id)
        {
            (string title, string desc, int atk, int def) info;
            try
            {
                info = _cardInfo[id - 1];
            }
            catch (Exception)
            {
                info = DefaultCard;
            }

            var card = _builder.CreateCard()
                .WithCardInformation(info.title, info.desc)
                .WithStats(info.atk, info.def)
                .Result;

            return card as MonsterCard;
        }
    }
}
