using System.Windows.Forms;

namespace Game.Views.User_Controls
{
    public partial class ArenaSide : UserControl
    {
        public string Username
        {
            set
            {
                void SetUsername() => UsernameLabel.Text = value;

                Invoke((MethodInvoker)SetUsername);
            }
        }

        public ArenaSide()
        {
            InitializeComponent();
        }

        public void UpdateCardDeck(int[] cardDeck)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
            panel5.Controls.Clear();
            if (cardDeck[0] != -1)
            {
                panel1.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new Models.GameCard(cardDeck[0].ToString(), "Lorem ipsum", 99, 99))));
            }

            if (cardDeck[1] != -1)
            {
                panel2.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new Models.GameCard(cardDeck[1].ToString(), "Lorem ipsum", 99, 99))));
            }

            if (cardDeck[2] != -1)
            {
                panel3.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new Models.GameCard(cardDeck[2].ToString(), "Lorem ipsum", 99, 99))));
            }

            if (cardDeck[3] != -1)
            {
                panel4.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new Models.GameCard(cardDeck[3].ToString(), "Lorem ipsum", 99, 99))));
            }

            if (cardDeck[4] != -1)
            {
                panel5.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new Models.GameCard(cardDeck[4].ToString(), "Lorem ipsum", 99, 99))));
            }
        }
    }
}
