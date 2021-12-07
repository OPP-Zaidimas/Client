using System;
using System.Drawing;
using Game.Assets;
using Game.Models.Card;
using Game.Services.Builder;

namespace Game.Services
{
    public class CardBuilder
    {
        private readonly MonsterCardBuilder _monsterCardBuilder;
        private readonly SpellCardBuilder _spellCardBuilder;
        private readonly ItemCardBuilder _itemCardBuilder;


        private readonly (string, string, int, int, Bitmap)[] _cardInfo =
        {
            new("Card 1", "Card", 1, 1, Images.Monster1),
            new("Card 2", "Card", 2, 3, Images.Monster2),
            new("Card 3", "Card", 3, 1, Images.Monster3),
            new("Card 4", "Card", 2, 2, Images.Monster4),
            new("Card 5", "Card", 0, 3, Images.Monster5),
        };

        private static (string, string, int, int, Bitmap) DefaultCard =>
            ("Default", "Placeholder", 1, 1, Images.ErrorIcon);

        public CardBuilder(MonsterCardBuilder monsterCardBuilder, SpellCardBuilder spellCardBuilder)
        {
            _monsterCardBuilder = monsterCardBuilder;
            _spellCardBuilder = spellCardBuilder;
            _itemCardBuilder = new ItemCardBuilder();
        }

        public ICard CreateCard(int id)
        {
            if (id <= 5)
            {
                return CreateMonsterCard(id);
            }

            return CreateSpellCard(id);
        }


        private MonsterCard CreateMonsterCard(int id)
        {
            (string title, string desc, int atk, int def, Bitmap image) info;
            try
            {
                info = _cardInfo[id - 1];
            }
            catch (Exception)
            {
                info = DefaultCard;
            }

            var card = _monsterCardBuilder.CreateCard(id)
                .WithCardInformation(info.title, info.desc)
                .WithStats(info.atk, info.def)
                .WithImage(info.image)
                .Result;

            return card as MonsterCard;
        }

        private SpellCard CreateSpellCard(int id)
        {
            var card = _spellCardBuilder.CreateCard(id)
                .WithCardInformation("spellCard", "spell")
                .WithEffect(new SpellEffect(2))
                .WithImage(Images.Spell1)
                .Result;

            return card as SpellCard;
        }
    }
}
