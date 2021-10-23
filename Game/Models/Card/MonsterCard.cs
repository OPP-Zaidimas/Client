namespace Game.Models.Card
{
    public class MonsterCard : ICard
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Attack { get; set; }
        public int? Defense { get; set; }

        public MonsterCard() { }

        public MonsterCard(string title, string description, int attack, int defense)
        {
            Title = title;
            Description = description;
            Attack = attack;
            Defense = defense;
        }
    }
}
