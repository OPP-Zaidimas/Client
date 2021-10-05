using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
>>>>>>> signalr join
using System.Windows.Forms;
using Game.Models;

namespace Game.Views.User_Controls
{
    public partial class ArenaView : UserControl
    {
<<<<<<< HEAD
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
=======
        private string _heroname {  
            set 
            {
                Debug.WriteLine(value);

                if(arenaSide1.IsHandleCreated) arenaSide1.updateLabel(value);
            } 
        }
        private string _opponentname
        {
            set
            {
                Debug.WriteLine(value);
                if(arenaSide2.IsHandleCreated) arenaSide2.updateLabel(value);
            }
        }

        public ArenaView(string hero_name, string opponent_name)
        {
            InitializeComponent();
            arenaSide1.CreateControl();
            arenaSide2.CreateControl();
            _heroname = hero_name;
            _opponentname = opponent_name;
>>>>>>> signalr join
        }

    }
}
