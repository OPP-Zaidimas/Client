using Game.Models.Card;

namespace Game.Models
{
    public class GameCard
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public GameCard(string title, string description, int attack, int defense)
        {
            Title = title;
            Description = description;
            Attack = attack;
            Defense = defense;
        }

        public GameCard(ICard card)
        {
            Title = card.Title;
            Description = card.Description;
            Attack = card.Attack ?? 0;
            Defense = card.Defense ?? 0;
        }

        public override string ToString()
        {
            return $"GameCard Info:\n{Title}\n{Description}\n{Attack} | {Defense}\n";
        }
    }
}
