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

        public override string ToString()
        {
            return $"GameCard Info:\n{Title}\n{Description}\n{Attack} | {Defense}\n";
        }
    }
}
