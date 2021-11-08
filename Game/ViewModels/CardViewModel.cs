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

        public CardViewModel(ICard c)
        {
            Id = c.Id;
            Title = c.Title;
            Description = c.Description;
            Attack = c.Attack;
            Defense = c.Defense;
            CurrentHp = (int) c.Defense;
            SelectBackgroundColor(c);
        }

        public void SetCurrentHp(int value)
        {
            CurrentHp = value;
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
