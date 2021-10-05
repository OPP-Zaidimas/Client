using System;
using System.Windows.Forms;
using Game.Models;

namespace Game.Views.User_Controls
{
    public partial class ArenaView : UserControl
    {
<<<<<<< HEAD
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
=======
        private readonly Deck _deck = new();
>>>>>>> 42f87c111ddf85379ae22a68f0b643205a9d7f59

        public ArenaView()
        {
            InitializeComponent();
        }

        public ArenaView(string playerName, string enemyName)
        {
            InitializeComponent();

            PlayerArenaSide.CreateControl();
            EnemyArenaSide.CreateControl();
<<<<<<< HEAD
            HeroName = heroName;
            OpponentName = opponentName;
            _deck = new Deck();
=======

            SetUsername(PlayerArenaSide, playerName);
            SetUsername(EnemyArenaSide, enemyName);
        }

        private void SetUsername(ArenaSide arenaSide, string username)
        {
            if (arenaSide.IsHandleCreated) arenaSide.Username = username;
>>>>>>> 42f87c111ddf85379ae22a68f0b643205a9d7f59
        }

        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            var card = _deck.Draw();


            HandView.AddCard(card);
        }
    }
}
