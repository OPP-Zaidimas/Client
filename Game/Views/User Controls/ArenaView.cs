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

            _deck = new Deck();
        }

        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            var card = _deck.Draw();
            //  Debug.WriteLine($"\n{card}");

            HandView.AddCard(card);
        }
    }
}
