namespace Game.Models.Card
{
    public class HealingItem : IItemCard
    {
        public string Title => "Item";
        public string Description => "Heals";
        public int? Attack => null;
        public int? Defense => null;
    }
}
