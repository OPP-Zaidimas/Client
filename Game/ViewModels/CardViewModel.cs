using Game.Models;
using Game.Models.Card;

namespace Game.ViewModels
{
    public class CardViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int? Attack { get; set; }

        public int? Defense { get; set; }

        public CardViewModel(ICard c)
        {
            Title = c.Title;
            Description = c.Description;
            Attack = c.Attack;
            Defense = c.Defense;
        }
    }
}
