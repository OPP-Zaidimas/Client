using System;
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

        private readonly (CardView, Button)[] _controls;

        public ArenaSide()
        {
            InitializeComponent();

            _controls = new[]
            {
                (CardView1, SelectButton1),
                (CardView2, SelectButton2),
                (CardView3, SelectButton3),
                (CardView4, SelectButton4),
                (CardView5, SelectButton5),
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
                var (card, button) = _controls[i];
                card.ViewModel = ids[i] == -1 ? null : new CardViewModel(Builder.CreateCard(ids[i]));
                button.Enabled = card.ViewModel != null;
            }
        }

        public void LockControls()
        {
            foreach (var (_, button) in _controls)
            {
                button.Enabled = false;
            }
        }

        public void UnlockControls()
        {
            foreach (var (card, button) in _controls)
            {
                button.Enabled = card.ViewModel != null;
            }
        }

        private void SelectButton1_Click(object sender, EventArgs e)
        {
            SelectCard(0);
        }

        private void SelectButton2_Click(object sender, EventArgs e)
        {
            SelectCard(1);
        }

        private void SelectButton3_Click(object sender, EventArgs e)
        {
            SelectCard(2);
        }

        private void SelectButton4_Click(object sender, EventArgs e)
        {
            SelectCard(3);
        }

        private void SelectButton5_Click(object sender, EventArgs e)
        {
            SelectCard(4);
        }

        private void SelectCard(int index)
        {
            try
            {
                var card = _controls[index].Item1;
                Console.WriteLine(card.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Card is null!");
            }
        }
    }
}
