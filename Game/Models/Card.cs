namespace Game.Models
{
    public class Card
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public Card(string title, string description, int attack, int defense)
        {
            Title = title;
            Description = description;
            Attack = attack;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"Card Info:\n{Title}\n{Description}\n{Attack} | {Defense}\n";
        }
    }
}
