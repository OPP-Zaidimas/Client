using System.Windows.Forms;
using Game.Models;
using Game.Services;
using Game.ViewModels;

namespace Game.Views.User_Controls
{
    public partial class HandView : UserControl
    {
        private readonly CardViewModel[] _cards;
        private SignalRService _signalRService;

        public HandView()
        {
            InitializeComponent();

            _cards = new CardViewModel[HandLayoutPanel.ColumnCount];
        }

        public void AddCard(GameCard gameCard)
        {
            Add(gameCard);
            Invoke((MethodInvoker)UpdateHand);
        }

        private void Add(GameCard c)
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

        private void UpdateHand()
        {
            HandLayoutPanel.Controls.Clear();
            for (int i = 0; i < _cards.Length; i++)
            {
                var card = _cards[i];
                if (card == null) continue;

                var cardView = new CardInHandView(card, this, i, _signalRService);

                HandLayoutPanel.Controls.Add(cardView, i, 0);
            }
        }

        public void RegisterSignalR(SignalRService signalR)
        {
            _signalRService = signalR;
        }
    }
}
