namespace Game.Models.Card
{
    public class DamagingItem : IItemCard
    {
        public string Title => "Item";
        public string Description => "Damages";
        public int? Attack => null;
        public int? Defense => null;
    }
}
