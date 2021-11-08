using Game.ViewModels;
using System.Windows.Forms;

namespace Game.Views.User_Controls
{
    public partial class CardView : UserControl
    {
        public CardViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                _viewModel = value;
                UpdateContent(ViewModel);
            }
        }

        private CardViewModel _viewModel;

        public CardView()
        {
            InitializeComponent();
        }

        public CardView(CardViewModel viewModel) : this()
        {
            ViewModel = viewModel;
        }

        public void UpdateCardInfo()
        {
            UpdateContent(ViewModel);
        }
        private void UpdateContent(CardViewModel viewModel)
        {
            if (viewModel == null)
            {
                Visible = false;
                return;
            }

            Visible = true;
            TitleLabel.Text = viewModel.Title;
            DescriptionLabel.Text = viewModel.Description;
            AtkLabel.Text = viewModel.Attack.ToString();
            DefLabel.Text = viewModel.CurrentHp.ToString();

            BackColor = viewModel.BackgroundColor ?? BackColor;
        }
    }
}
