using Game.Models.Card;

namespace Game.Services.AbstractFactory
{
    public class DamagingCardFactory : ICardFactory
    {
        public ISpellCard CreateSpell()
        {
            return new DamagingSpell();
        }

        public IItemCard CreateItem()
        {
            return new DamagingItem();
        }
    }
}
