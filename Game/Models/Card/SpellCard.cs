using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    class SpellCard : ICard
    {
        public int Id { get ; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Attack { get; set; }
        public int? Defense { get; set; }
        public int CurrentHp { get; set; }
        public IEffect Effect { get; set; }
        public SpellCard() { }

        public SpellCard(string title, string description, int attack, int defense, IEffect effect)
        {
            Title = title;
            Description = description;
            Attack = attack;
            Defense = defense;
            CurrentHp = (int)defense;
            Effect = effect;
        }

        public SpellCard(SpellCard other)
        {
            Id = other.Id;
            Title = other.Title;
            Description = other.Description;
            Attack = other.Attack;
            Defense = other.Defense;
            Effect = other.Effect;
        }

        public SpellCard Clone()
        {
            return new SpellCard(this);
        }

        
    }

}
