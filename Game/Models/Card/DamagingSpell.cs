using System;
using System.Drawing;

namespace Game.Models.Card
{
    public class DamagingSpell : ISpellCard, IEffect, ICloneable<DamagingSpell>
    {
        public int Id { get; set; }

        public string Title
        {
            get => "Spell";
            set => throw new System.NotImplementedException();
        }

        public string Description
        {
            get => "Damages";
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
        public int CurrentHp { get; set; }
        public Image Image { get; set; }

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            return (card_data.index, EffectStrength < card_data.hp ? card_data.hp - EffectStrength : 0);
        }

        public DamagingSpell() { }

        public DamagingSpell(DamagingSpell other)
        {
            Id = other.Id;
            Title = other.Title;
            Description = other.Description;
            Attack = other.Attack;
            Defense = other.Defense;
            EffectStrength = other.EffectStrength;
        }

        public DamagingSpell Clone()
        {
            return new DamagingSpell(this);
        }
    }
}
