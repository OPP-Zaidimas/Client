
using Game.ViewModels;
using System.Windows.Forms;

namespace Game.Views.User_Controls
{
    public partial class CardView : UserControl
    {
        public CardView()
        {
            InitializeComponent();
        }

        public CardView(CardViewModel viewModel)
        {
            InitializeComponent();

            UpdateContent(viewModel);
        }

        public void UpdateContent(CardViewModel viewModel)
        {
            TitleLabel.Text = viewModel.Title;
            DescriptionLabel.Text = viewModel.Description;
            AtkLabel.Text = viewModel.Attack.ToString();
            DefLabel.Text = viewModel.Defense.ToString();
        }
    }
}
