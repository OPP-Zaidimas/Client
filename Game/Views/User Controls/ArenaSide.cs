using System.Windows.Forms;
using Game.Interfaces;
using Game.Services;
using Game.ViewModels;

namespace Game.Views.User_Controls
{
    public partial class ArenaSide : UserControl, IObserver
    {
        public string Username
        {
            set
            {
                void SetUsername() => UsernameLabel.Text = value;

                Invoke((MethodInvoker)SetUsername);
            }
        }

        public ArenaSideViewModel ViewModel { get; set; }
        public CardBuilder Builder { get; set; }

        private readonly CardView[] _cards;

        public ArenaSide()
        {
            InitializeComponent();

            _cards = new[]
            {
                CardView1,
                CardView2,
                CardView3,
                CardView4,
                CardView5,
            };
        }

        public ArenaSide(ArenaSideViewModel viewModel) : this()
        {
            ViewModel = viewModel;
            ViewModel.Subscribe(this);
        }

        public void Update(IObservable observable)
        {
            UpdateCardDeck(ViewModel.Cards);
        }

        public void UpdateCardDeck(int[] ids)
        {
            for (int i = 0; i < ids.Length; i++)
            {
                _cards[i].ViewModel = ids[i] == -1 ? null : new CardViewModel(Builder.CreateCard(ids[i]));
            }
        }
    }
}
