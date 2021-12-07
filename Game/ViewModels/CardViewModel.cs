using System.Drawing;
using Game.Models;
using Game.Models.Card;

namespace Game.ViewModels
{
    public class CardViewModel
    {
        public int Id { get; }

        public string Title { get; }

        public string Description { get; }

        public int? Attack { get; }

        public int? Defense { get; }

        public int CurrentHp { get; set; }

        public Color? BackgroundColor { get; private set; }

        public CardType Type { get; private set; }

        public Image CardImage { get; }

        public CardViewModel(ICard c)
        {
            Id = c.Id;
            Title = c.Title;
            Description = c.Description;
            Attack = c.Attack ?? 0;
            Defense = c.Defense ?? 0;
            CurrentHp = c.Defense ?? 0;
            SelectBackgroundColor(c);
            CardImage = c.Image;
            SelectCardType(c);
        }

        public void SetCurrentHp(int value)
        {
            CurrentHp = value;
        }

        private void SelectCardType(ICard c)
        {
            Type = c switch
            {
                MonsterCard => CardType.Monster,
                HealingSpell => CardType.HealingSpellCard,
                DamagingSpell => CardType.DamagingSpellCard,
                _ => Type
            };
        }

        private void SelectBackgroundColor(ICard c)
        {
            BackgroundColor = c switch
            {
                MonsterCard => CardColors.MonsterBackgroundColor,
                SpellCard => CardColors.SpellBackgroundColor,
                _ => BackgroundColor
            };
        }
    }
}
