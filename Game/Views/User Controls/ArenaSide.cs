﻿using System.Diagnostics;
using System.Windows.Forms;
using Game.Interfaces;
using Game.Models.Card;
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

        public ArenaSide()
        {
            InitializeComponent();
        }

        public ArenaSide(ArenaSideViewModel viewModel) : this()
        {
            ViewModel = viewModel;
            ViewModel.Subscribe(this);
        }

        public void UpdateCardDeck(int[] cardDeck)
        {
            foreach (int id in cardDeck)
            {
                Debug.Write($"{id} ");
            }

            Debug.WriteLine("");


            /*panel1.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
            panel5.Controls.Clear();

            if (cardDeck[0] != -1)
            {
                panel1.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new MonsterCard(cardDeck[0].ToString(), "Lorem ipsum", 99, 99))));
            }

            if (cardDeck[1] != -1)
            {
                panel2.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new MonsterCard(cardDeck[1].ToString(), "Lorem ipsum", 99, 99))));
            }

            if (cardDeck[2] != -1)
            {
                panel3.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new MonsterCard(cardDeck[2].ToString(), "Lorem ipsum", 99, 99))));
            }

            if (cardDeck[3] != -1)
            {
                panel4.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new MonsterCard(cardDeck[3].ToString(), "Lorem ipsum", 99, 99))));
            }

            if (cardDeck[4] != -1)
            {
                panel5.Controls.Add(new CardView(
                    new ViewModels.CardViewModel(new MonsterCard(cardDeck[4].ToString(), "Lorem ipsum", 99, 99))));
            }*/
        }

        public void Update(IObservable observable)
        {
            UpdateCardDeck(ViewModel.Cards);
        }
    }
}
