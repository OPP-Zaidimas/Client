using System;
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

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            return (card_data.index, EffectStrength < card_data.hp ? card_data.hp - EffectStrength : 0);
        }

        public DamagingSpell()
        {
        }

        public DamagingSpell(DamagingSpell other)
        {
            this.Id = other.Id;
            this.Title = other.Title;
            this.Description = other.Description;
            this.Attack = other.Attack;
            this.Defense = other.Defense;
            this.EffectStrength = other.EffectStrength;
        }

        public DamagingSpell Clone()
        {
            return new DamagingSpell(this);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
