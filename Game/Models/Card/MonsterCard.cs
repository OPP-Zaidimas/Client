using System.Drawing;

namespace Game.Models.Card
{
    public class MonsterCard : ICard, ICloneable<MonsterCard>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Attack { get; set; }
        public int? Defense { get; set; }
        public int CurrentHp { get; set; }
        public Image Image { get; set; }

        public MonsterCard() { }

        public MonsterCard(string title, string description, int attack, int defense, Image image)
        {
            Title = title;
            Description = description;
            Attack = attack;
            Defense = defense;
            CurrentHp = defense;
            Image = image;
        }

        public MonsterCard(MonsterCard other)
        {
            Id = other.Id;
            Title = other.Title;
            Description = other.Description;
            Attack = other.Attack;
            Defense = other.Defense;
            Image = other.Image;
        }

        public MonsterCard Clone()
        {
            return new MonsterCard(this);
        }
    }
}
