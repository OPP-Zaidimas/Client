using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Game.Interfaces;
using Game.Models.Card;
using Game.Services;
using Game.ViewModels;

namespace Game.Views.User_Controls
{
    public partial class HandView : UserControl, IObserver
    {
        private SignalRService _service;

        private readonly HandViewModel _viewModel;
        private readonly (CardView, Button)[] _controls;

        private const int TotalCardPlacements = 2;

        private int _cardsPlaced = 0;

        public bool CheckHandStatus => _viewModel.Cards.Any(t => t == null);

        public HandView()
        {
            InitializeComponent();

            _viewModel = new HandViewModel(HandLayoutPanel.ColumnCount);
            _viewModel.Subscribe(this);

            _controls = new[]
            {
                (CardView1, PlaceButton1),
                (CardView2, PlaceButton2),
                (CardView3, PlaceButton3),
                (CardView4, PlaceButton4),
                (CardView5, PlaceButton5),
                (CardView6, PlaceButton6),
                (CardView7, PlaceButton7),
                (CardView8, PlaceButton8)
            };
        }

        public void AddCard(ICard card)
        {
            _viewModel.AddCard(card);
        }

        public void RegisterSignalR(SignalRService signalR)
        {
            _service = signalR;
            _cardsPlaced = 0;
            _service.OnReceiveEndTurn += UpdatePlaceButtons;
        }

        public void Update(IObservable observable)
        {
            UpdateHand(_viewModel.Cards);
        }

        public void UpdatePlaceButtons(bool buttonStatus)
        {
            for (int i = 0; i < _viewModel.Cards.Count; i++)
            {
                if (_viewModel.Cards[i] != null)
                {
                    var (_, button) = _controls[i];
                    button.Enabled = buttonStatus;
                }
            }
        }

        private void UpdateHand(IReadOnlyList<ICard> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                var (cardView, button) = _controls[i];

                button.Enabled = cards[i] != null && _cardsPlaced != TotalCardPlacements;
                cardView.ViewModel = cards[i] != null ? new CardViewModel(cards[i]) : null;
            }
        }

        private void PlaceButton1_Click(object sender, System.EventArgs e)
        {
            PlaceCard(0);
        }

        private void PlaceButton2_Click(object sender, System.EventArgs e)
        {
            PlaceCard(1);
        }

        private void PlaceButton3_Click(object sender, System.EventArgs e)
        {
            PlaceCard(2);
        }

        private void PlaceButton4_Click(object sender, System.EventArgs e)
        {
            PlaceCard(3);
        }

        private void PlaceButton5_Click(object sender, System.EventArgs e)
        {
            PlaceCard(4);
        }

        private void PlaceButton6_Click(object sender, System.EventArgs e)
        {
            PlaceCard(5);
        }

        private void PlaceButton7_Click(object sender, System.EventArgs e)
        {
            PlaceCard(6);
        }

        private void PlaceButton8_Click(object sender, System.EventArgs e)
        {
            PlaceCard(7);
        }

        private void PlaceCard(int index)
        {
            _service.PlaceCard(_viewModel.IdAt(index)).ContinueWith(_ =>
            {
                Invoke((MethodInvoker)delegate { _viewModel.RemoveCard(index); });
            });
            _cardsPlaced++;
        }
    }
}
