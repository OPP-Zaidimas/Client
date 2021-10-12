using Game.ViewModels;
using System.Windows.Forms;
using Game.Views.User_Controls;
using Game.Services;

namespace Game.Views
{
    public partial class CardInHandView : UserControl
    {
        private int _index;
        private HandView _hand;
        public SignalRService _service;

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
            _service.PlaceCard(_service.matchStats.GetMatchId(),_index, _service.matchStats.GetHeroUsername()).ContinueWith((task)=>
            {
            });
            _hand.Remove(_index);
        }
    }
}
