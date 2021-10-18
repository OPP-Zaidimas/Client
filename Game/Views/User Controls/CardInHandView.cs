using Game.ViewModels;
using System.Windows.Forms;
using Game.Views.User_Controls;
using Game.Services;

namespace Game.Views
{
    public partial class CardInHandView : UserControl
    {
        private readonly int _index;
        private readonly HandView _hand;
        private readonly SignalRService _service;

        public CardInHandView()
        {
            InitializeComponent();
        }

        public CardInHandView(CardViewModel viewModel, HandView handView, int index, SignalRService service)
        {
            InitializeComponent();

            CardView.UpdateContent(viewModel);

            _hand = handView;
            _index = index;
            _service = service;
        }

        private void PlaceButton_Click(object sender, System.EventArgs e)
        {
            _service.PlaceCard(_index).ContinueWith(_ =>
            {
                Invoke((MethodInvoker)delegate { _hand.Remove(_index); });
            });
        }
    }
}
