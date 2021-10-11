﻿using System;
using System.Windows.Forms;
using Game.Models;
using Game.Models.Hero;

namespace Game.Views.User_Controls
{
    public partial class ArenaView : UserControl
    {
        private readonly Deck _deck;

        public ArenaView()
        {
            InitializeComponent();
        }

        public ArenaView(string playerName, string enemyName, IHero playerHero, IHero enemyHero)
        {
            InitializeComponent();

            PlayerArenaSide.CreateControl();
            EnemyArenaSide.CreateControl();

            _deck = new Deck();


            SetUsername(PlayerArenaSide, playerName, playerHero.Name);
            SetUsername(EnemyArenaSide, enemyName, enemyHero.Name);
        }

        private static void SetUsername(ArenaSide arenaSide, string username, string heroName)
        {
            string text = $"{username} ({heroName})";

            if (arenaSide.IsHandleCreated) arenaSide.Username = text;
        }

        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            var card = _deck.Draw();


            HandView.AddCard(card);
        }
    }
}
