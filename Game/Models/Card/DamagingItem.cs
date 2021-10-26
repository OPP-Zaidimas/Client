using System;

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
        public DamagingItem()
        {
        }

        public DamagingItem(DamagingItem other)
        {
            this.Id = other.Id;
            this.Title = other.Title;
            this.Description = other.Description;
            this.Attack = other.Attack;
            this.Defense = other.Defense;
        }

        public DamagingItem Clone()
        {
            return new DamagingItem(this);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

    }
}
