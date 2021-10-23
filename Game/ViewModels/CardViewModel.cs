using System.Drawing;
using Game.Models;
using Game.Models.Card;

namespace Game.ViewModels
{
    public class CardViewModel
    {
        public string Title { get; }

        public string Description { get; }

        public int? Attack { get; }

        public int? Defense { get; }

        public Color? BackgroundColor { get; private set; }

        public CardViewModel(ICard c)
        {
            Title = c.Title;
            Description = c.Description;
            Attack = c.Attack;
            Defense = c.Defense;

            SelectBackgroundColor(c);
        }

        private void SelectBackgroundColor(ICard c)
        {
            if (c is MonsterCard)
            {
                BackgroundColor = CardColors.MonsterBackgroundColor;
            }
        }
    }
}
