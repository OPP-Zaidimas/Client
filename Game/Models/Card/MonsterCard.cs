using System;

namespace Game.Models.Card
{
    public class MonsterCard : ICard, ICloneable<MonsterCard>
    {
        public int Id { get; set; }
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

        public MonsterCard(MonsterCard other)
        {
            this.Id = other.Id;
            this.Title = other.Title;
            this.Description = other.Description;
            this.Attack = other.Attack;
            this.Defense = other.Defense;
        }

        public MonsterCard Clone()
        {
            return new MonsterCard(this);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }


    }
}
