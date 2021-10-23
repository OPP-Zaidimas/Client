namespace Game.Models.Card
{
    public class HealingItem : IItemCard
    {
        public string Title
        {
            get => "Item";
            set => throw new System.NotImplementedException();
        }

        public string Description
        {
            get => "Heals";
            set => throw new System.NotImplementedException();
        }

        public int? Attack
        {
            get => null;
            set => throw new System.NotImplementedException();
        }

        public int? Defense
        {
            get => null;
            set => throw new System.NotImplementedException();
        }
    }
}
