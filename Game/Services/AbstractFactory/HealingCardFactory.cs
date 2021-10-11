using Game.Models.Card;

namespace Game.Services.AbstractFactory
{
    public class HealingCardFactory : ICardFactory
    {
        public ISpellCard CreateSpell()
        {
            return new HealingSpell();
        }

        public IItemCard CreateItem()
        {
            return new HealingItem();
        }
    }
}
