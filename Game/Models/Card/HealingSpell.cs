using System;

namespace Game.Models.Card
{
    public class HealingSpell : ISpellCard, IEffect, ICloneable<HealingSpell>
    {
        public int Id { get; set; }

        public string Title
        {
            get => "Spell";
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

        public int EffectStrength { get; set; }

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            return (card_data.index, card_data.hp + EffectStrength);
        }

        public HealingSpell() { }


        public HealingSpell(HealingSpell other)
        {
            Id = other.Id;
            Title = other.Title;
            Description = other.Description;
            Attack = other.Attack;
            Defense = other.Defense;
            EffectStrength = other.EffectStrength;
        }

        public HealingSpell Clone()
        {
            return new HealingSpell(this);
        }
    }
}
