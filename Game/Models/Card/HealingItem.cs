using System;
namespace Game.Models.Card
{
    public class HealingItem : IItemCard, ICloneable
    {
        public int Id { get; set; }

        public string Title
        {
            get => "Item";
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

        public String applyEffect()
        {
            return "Effects:";
        }
        public HealingItem(string title, string description, int attack, int defense)
        {
            Title = title;
            Description = description;
            Attack = attack;
            Defense = defense;
        }
        public HealingItem()
        {
        }

        public HealingItem(HealingItem other)
        {
            this.Id = other.Id;
            this.Title = other.Title;
            this.Description = other.Description;
            this.Attack = other.Attack;
            this.Defense = other.Defense;
        }

        public HealingItem Clone()
        {
            return new HealingItem(this);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
