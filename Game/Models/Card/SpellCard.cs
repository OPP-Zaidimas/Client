using System.Drawing;

namespace Game.Models.Card
{
    public class SpellCard : ICard, ICloneable<SpellCard>
    {
        public int Id { get ; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Attack { get; set; }
        public int? Defense { get; set; }
        public int CurrentHp { get; set; }
        public Image Image { get; set; }
        public IEffect Effect { get; set; }
        public SpellCard() { }

        public SpellCard(string title, string description, int attack, int defense, IEffect effect, Image image)
        {
            Title = title;
            Description = description;
            Attack = attack;
            Defense = defense;
            CurrentHp = defense;
            Effect = effect;
            Image = image;
        }

        public SpellCard(SpellCard other)
        {
            Id = other.Id;
            Title = other.Title;
            Description = other.Description;
            Attack = other.Attack;
            Defense = other.Defense;
            Effect = other.Effect;
            Image = other.Image;
        }

        public SpellCard Clone()
        {
            return new SpellCard(this);
        }
    }
}
