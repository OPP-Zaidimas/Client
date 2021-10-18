using System;
using System.Windows.Forms;
using Game.Models;
using Game.Models.Hero;
using Game.Services;
using Game.Services.AbstractFactory;
using Game.ViewModels;

namespace Game.Views.User_Controls
{
    public partial class ArenaView : UserControl
    {
        private readonly Deck _deck;

        private readonly ArenaSideViewModel _playerArenaViewModel;
        private readonly ArenaSideViewModel _enemyArenaViewModel;

        private const int ArenaCardLimit = 5;

        public ArenaView()
        {
            InitializeComponent();

            _deck = new Deck(new DamagingCardFactory());
            _playerArenaViewModel = new ArenaSideViewModel(ArenaCardLimit);
            _enemyArenaViewModel = new ArenaSideViewModel(ArenaCardLimit);
        }

        public ArenaView(string playerName, string enemyName, IHero playerHero, IHero enemyHero, SignalRService service,
            MatchStats matchStats) : this()
        {
            service.RegisterMatchStats(matchStats);

            SetupArenaSide(PlayerArenaSide, playerName, playerHero.Name, _playerArenaViewModel);
            SetupArenaSide(EnemyArenaSide, enemyName, enemyHero.Name, _enemyArenaViewModel);

            HandView.RegisterSignalR(service);

            service.OnReceiveCardDecks += OnCardsUpdateReceived;
        }

        private static void SetupArenaSide(ArenaSide arenaSide, string username, string heroName,
            ArenaSideViewModel viewModel)
        {
            arenaSide.CreateControl();
            SetUsername(arenaSide, username, heroName);
            arenaSide.ViewModel = viewModel;
        }

        private void OnCardsUpdateReceived(int[] heroCards, int[] opponentCards)
        {
            //visualize in different arena sides
            PlayerArenaSide.UpdateCardDeck(heroCards);
            EnemyArenaSide.UpdateCardDeck(opponentCards);
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
