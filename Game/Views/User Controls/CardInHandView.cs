using Game.ViewModels;
using System.Windows.Forms;

namespace Game.Views
{
    public partial class CardInHandView : UserControl
    {
        public CardInHandView()
        {
            InitializeComponent();
        }

        public CardInHandView(CardViewModel viewModel)
        {
            InitializeComponent();

            CardView.UpdateContent(viewModel);
        }
    }
}
