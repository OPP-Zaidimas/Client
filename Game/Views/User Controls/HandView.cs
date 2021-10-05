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

        public void Remove(int i)
        {
            _cards[i] = null;
            UpdateHand();
        }

        public void UpdateHand()
        {
            HandLayoutPanel.Controls.Clear();
            for (int i = 0; i < _cards.Length; i++)
            {
                var card = _cards[i];
                if (card == null) continue;

                var cardView = new CardInHandView(card, this, i);

                HandLayoutPanel.Controls.Add(cardView, i, 0);
            }
        }
    }
}
