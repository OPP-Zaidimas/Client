using Game.Models.Card;

namespace Game.Services.AbstractFactory
{
    public interface ICardFactory
    {
        public ISpellCard CreateSpell();

        public IItemCard CreateItem();
    }
}
