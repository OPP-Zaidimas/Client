using Game.ViewModels;
using System.Windows.Forms;
using Game.Views.User_Controls;

namespace Game.Views
{
    public partial class CardInHandView : UserControl
    {
        private int _index;
        private HandView _hand;

        public CardInHandView()
        {
            InitializeComponent();
        }

        public CardInHandView(CardViewModel viewModel, HandView handView, int index)
        {
            InitializeComponent();

            CardView.UpdateContent(viewModel);

            _hand = handView;
            _index = index;
        }

        private void PlaceButton_Click(object sender, System.EventArgs e)
        {
            _hand.Remove(_index);
        }
    }
}
