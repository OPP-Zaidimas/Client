using System;
using Game.Models.Card;
using Game.Services.Builder;

namespace Game.Services
{
    public class CardBuilder
    {
        private readonly MonsterCardBuilder _monsterCard;
        private readonly SpellCardBuilder _spellCard;


        private readonly (string, string, int, int)[] _cardInfo =
        {
            new("Card 1", "Card", 1, 1),
            new("Card 2", "Card", 2, 3),
            new("Card 3", "Card", 3, 1),
            new("Card 4", "Card", 2, 2),
            new("Card 5", "Card", 0, 3),
        };

        private static (string, string, int, int) DefaultCard => ("Default", "Placeholder", 1, 1);

        public CardBuilder(MonsterCardBuilder monsterCardBUilder, SpellCardBuilder spellCardBuilder)
        {
            _monsterCard = monsterCardBUilder;
            _spellCard = spellCardBuilder;

        }

        public ICard CreateCard(int id) 
        {
            if( id <= 5)
            {
                return CreateMonsterCard(id);
            }
            else
            {
                return CreateSpellCard(id);
            }
            
        }
            
        
        private MonsterCard CreateMonsterCard(int id)
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

            var card = _monsterCard.CreateCard(id)
                .WithCardInformation(info.title, info.desc)
                .WithStats(info.atk, info.def)
                .Result;

            return card as MonsterCard;
        }
        private SpellCard CreateSpellCard(int id)
        {           
            var card = _spellCard.CreateCard(id)
                .WithCardInformation("spellCard", "spell")
                .WithEffect(new SpellEffect(2))
                .Result;

            return card as SpellCard;
        }
     
    }
}
