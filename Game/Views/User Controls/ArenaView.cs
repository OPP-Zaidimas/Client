using System;
using System.Windows.Forms;
using Game.Models;

namespace Game.Views.User_Controls
{
    public partial class ArenaView : UserControl
    {
        private readonly Deck _deck;

        private string HeroName
        {
            set
            {
                if (PlayerArenaSide.IsHandleCreated) PlayerArenaSide.updateLabel(value);
            }
        }

        private string OpponentName
        {
            set
            {   
                if (EnemyArenaSide.IsHandleCreated) EnemyArenaSide.updateLabel(value);
            }
        }

        public ArenaView()
        {
            InitializeComponent();

            _deck = new Deck();
        }

        public ArenaView(string heroName, string opponentName)
        {
            InitializeComponent();
            PlayerArenaSide.CreateControl();
            EnemyArenaSide.CreateControl();
            HeroName = heroName;
            OpponentName = opponentName;
            _deck = new Deck();
        }

        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            var card = _deck.Draw();


            HandView.AddCard(card);
        }
    }
}
