using System;
using System.Drawing;

namespace Game.Models.Card
{
    public class DamagingItem : IItemCard, ICloneable<DamagingItem>
    {
        public int Id { get; set; }

        public string Title
        {
            get => "Item";
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
        public int CurrentHp { get; set; }
        public Image Image { get; set; }

        public DamagingItem() { }

        public DamagingItem(DamagingItem other)
        {
            Id = other.Id;
            Description = other.Description;
            Attack = other.Attack;
            Defense = other.Defense;
        }

        public DamagingItem Clone()
        {
            return new DamagingItem(this);
        }
    }
}
