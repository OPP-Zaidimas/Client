using System;
using System.Windows.Forms;
using Game.Models;

namespace Game.Views.User_Controls
{
    public partial class ArenaView : UserControl
    {
        private readonly Deck _deck;

        public ArenaView()
        {
            InitializeComponent();
        }

        public ArenaView(string playerName, string enemyName)
        {
            InitializeComponent();

            PlayerArenaSide.CreateControl();
            EnemyArenaSide.CreateControl();

            _deck = new Deck();


            SetUsername(PlayerArenaSide, playerName);
            SetUsername(EnemyArenaSide, enemyName);
        }

        private static void SetUsername(ArenaSide arenaSide, string username)
        {
            if (arenaSide.IsHandleCreated) arenaSide.Username = username;
        }

        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            var card = _deck.Draw();


            HandView.AddCard(card);
        }
    }
}
