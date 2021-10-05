using System.Windows.Forms;
using Game.Models;
using Game.ViewModels;

namespace Game.Views.User_Controls
{
    public partial class HandView : UserControl
    {
        private readonly CardViewModel[] _cards;

        public HandView()
        {
            InitializeComponent();

            _cards = new CardViewModel[HandLayoutPanel.ColumnCount];
        }

        public void AddCard(Card card)
        {
            Add(card);
            UpdateHand();
        }

        private void Add(Card c)
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                var card = _cards[i];
                if (card != null) continue;

                _cards[i] = new CardViewModel(c);
                return;
            }
        }

        public void UpdateHand()
        {
            HandLayoutPanel.Controls.Clear();
            for (int i = 0; i < _cards.Length; i++)
            {
                var card = _cards[i];
                if (card == null) continue;

                HandLayoutPanel.Controls.Add(new CardInHandView(card), i, 0);
            }
        }
    }
}
