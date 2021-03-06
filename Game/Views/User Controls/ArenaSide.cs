using System;
using System.Windows.Forms;
using Game.Interfaces;
using Game.Services;
using Game.ViewModels;
using System.Linq;

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

        public string HeroHP
        {
            set
            {
                void SetHP() => HeroHpLabel.Text = value;

                Invoke((MethodInvoker)SetHP);
            }
        }

        private event Action<int, CardView> OnSelectClicked;
        private event Action OnHeroSelectClicked;

        public ArenaSideViewModel ViewModel { get; set; }
        public CardBuilder Builder { get; set; }

        private readonly (CardView, Button)[] _controls;

        public bool CanAttackHero => _controls.All(t => t.Item1.ViewModel == null);

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

        public void MakeHeroSelectButtonInvisible()
        {
            HeroSelectButton.Visible = false;
        }

        public void DisableHeroSelection()
        {
            HeroSelectButton.Enabled = false;
        }

        public void EnableHeroSelection()
        {
            HeroSelectButton.Enabled = true;
        }

        public ArenaSide(ArenaSideViewModel viewModel) : this()
        {
            ViewModel = viewModel;
            ViewModel.Subscribe(this);
        }

        public void SetupOnSelectListener(Action<int, CardView> onSelectClicked)
        {
            OnSelectClicked = onSelectClicked;
        }

        public void SetupOnHeroSelectListener(Action onHeroSelected)
        {
            OnHeroSelectClicked = onHeroSelected;
        }

        public void Update(IObservable observable)
        {
//            UpdateCardDeck(ViewModel.Cards);
        }

        public void UpdateCardDeck(int[] ids, int[] hps, bool isPlayerSide)
        {
            for (int i = 0; i < ids.Length; i++)
            {
                var (card, button) = _controls[i];
                card.ViewModel = ids[i] == -1 ? null : new CardViewModel(Builder.CreateCard(ids[i]));
                if (card.ViewModel != null)
                {
                    card.ViewModel.CurrentHp = hps[i];
                    card.UpdateCardInfo();
                }

                button.Enabled = card.ViewModel != null && !ViewModel.GetStatusAtId(i) && isPlayerSide;
            }
        }

        public void UpdateHPs(int[] hps)
        {
            for (int i = 0; i < hps.Length; i++)
            {
                var (card, button) = _controls[i];
                if (hps[i] == 0)
                {
                    card.ViewModel = null;
                }
                else
                {
                    card.ViewModel.SetCurrentHp(hps[i]);
                    card.UpdateCardInfo();
                }
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
                OnSelectClicked.Invoke(index, _controls[index].Item1);
            }
            catch (Exception)
            {
                Console.WriteLine("Card is null!");
            }
        }

        public void ChangeCardsSelectionStatus(bool status)
        {
            foreach (var (cardView, button) in _controls)
            {
                button.Enabled = cardView.ViewModel != null && status;
            }
        }

        private void HeroSelectButton_Click(object sender, EventArgs e)
        {
            OnHeroSelectClicked.Invoke();
        }
    }
}
