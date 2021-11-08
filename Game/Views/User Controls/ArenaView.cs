﻿using System;
using System.Windows.Forms;
using Game.Commands;
using Game.Interfaces;
using Game.Models;
using Game.Models.Hero;
using Game.Services;
using Game.Services.AbstractFactory;
using Game.Services.Builder;
using Game.ViewModels;

namespace Game.Views.User_Controls
{
    public partial class ArenaView : UserControl
    {
        private readonly Deck _deck;

        private readonly ArenaSideViewModel _playerArenaViewModel;
        private readonly ArenaSideViewModel _enemyArenaViewModel;
        private readonly CardBuilder _builder;

        private ICommand _drawCard;
        private ICommand _endturn;

        private const int ArenaCardLimit = 5;

        private (int, CardView) _chosenCard;
        private SignalRService _service;

        public ArenaView()
        {
            InitializeComponent();

            _builder = new CardBuilder(new MonsterCardBuilder());
            _deck = new Deck(new DamagingCardFactory(), _builder);
            _playerArenaViewModel = new ArenaSideViewModel(ArenaCardLimit);
            _enemyArenaViewModel = new ArenaSideViewModel(ArenaCardLimit);

            PlayerArenaSide.Builder = _builder;
            EnemyArenaSide.Builder = _builder;
        }
        (int, CardView) herocard = (0, null);

        private bool _isMyTurn;

        public ArenaView(string playerName, string enemyName, IHero playerHero, IHero enemyHero, SignalRService service,
            MatchStats matchStats) : this()
        {
            service.RegisterMatchStats(matchStats);

            SetupArenaSide(PlayerArenaSide, playerName, playerHero.Name, _playerArenaViewModel, PlayerArenaSelectClicked);
            SetupArenaSide(EnemyArenaSide, enemyName, enemyHero.Name, _enemyArenaViewModel, EnemyArenaSelectClicked);

            HandView.RegisterSignalR(service);
            
            _endturn = new EndTurnCommand(service);
            _drawCard = new DrawCardCommand(_deck, this.HandView);

            service.OnReceiveCardDecks += OnCardsUpdateReceived;
            service.OnReceiveEndTurn += EndTurn;
            _service = service;
        }

        public void UpdateHPs(int[] herohps, int[] opponenthps)
        {
            PlayerArenaSide.UpdateHPs(herohps);
            EnemyArenaSide.UpdateHPs(opponenthps);
        }

        private static void SetupArenaSide(ArenaSide arenaSide, string username, string heroName,
            ArenaSideViewModel viewModel, Action<int, CardView> onSelect)
        {
            arenaSide.CreateControl();
            SetUsername(arenaSide, username, heroName);
            arenaSide.ViewModel = viewModel;
            arenaSide.SetupOnSelectListener(onSelect);
        }

        private void OnCardsUpdateReceived(int[] heroCards, int[] heroHPs, int[] opponentCards, int[] opponentHPs)
        {
            //visualize in different arena sides
            PlayerArenaSide.ViewModel.UpdateCards(heroCards, heroHPs);
            EnemyArenaSide.ViewModel.UpdateCards(opponentCards, opponentHPs);
            PlayerArenaSide.UpdateCardDeck(heroCards, heroHPs, _isMyTurn);
            EnemyArenaSide.UpdateCardDeck(opponentCards, opponentHPs, false);
        }

        public void EndTurn(bool buttonStatus)
        {
            _isMyTurn = buttonStatus;
            UpdateButtons(buttonStatus);
            if(buttonStatus)
            {
                _drawCard.Execute();
                PlayerArenaSide.ViewModel.ResetCardStatus();
            }
        }

        public void UpdateButtons(bool buttonStatus)
        {
            EndTurnButton.Enabled = buttonStatus;
            DrawCardButton.Enabled = buttonStatus;
            PlayerArenaSide.ChangeCardsSelectionStatus(buttonStatus);
            EnemyArenaSide.ChangeCardsSelectionStatus(false);
        }

        public void PlayerArenaSelectClicked(int id, CardView cardView)
        {
            _chosenCard = (id, cardView);
            EnemyArenaSide.ChangeCardsSelectionStatus(true);
        }

        public void EnemyArenaSelectClicked(int id, CardView cardView)
        {
            //send indices and hps to server
            if(_chosenCard.Item2!=null)
                _service.MonsterAttack(_chosenCard.Item1, (int) _chosenCard.Item2.ViewModel.Attack, id, cardView.ViewModel.CurrentHp);
            //disable enemyarenaside cards
            EnemyArenaSide.ChangeCardsSelectionStatus(false);
            //disable attacker
            PlayerArenaSide.ViewModel.SetCardStatus(_chosenCard.Item1, true);
        }

        private static void SetUsername(ArenaSide arenaSide, string username, string heroName)
        {
            string text = $"{username} ({heroName})";

            if (arenaSide.IsHandleCreated) arenaSide.Username = text;
        }

        private async void DrawCardButton_Click(object sender, EventArgs e)
        {
            if(! (await _drawCard.Execute()))
            {
                MessageBox.Show("The hand is full");
            }
            DrawCardButton.Enabled = false;
        }

        private async void EndTurnButton_Click(object sender, EventArgs e)
        {
            await _endturn.Execute();
        }
    }
}
