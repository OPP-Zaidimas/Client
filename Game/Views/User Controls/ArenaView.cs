using System;
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
        private Button endTurn;
        private Button drawCard;

        private ICommand _drawCard;
        private ICommand _endturn;

        private const int ArenaCardLimit = 5;

        public ArenaView()
        {
            InitializeComponent();

            _builder = new CardBuilder(new MonsterCardBuilder());
            _deck = new Deck(new DamagingCardFactory(), _builder);
            _playerArenaViewModel = new ArenaSideViewModel(ArenaCardLimit);
            _enemyArenaViewModel = new ArenaSideViewModel(ArenaCardLimit);

            PlayerArenaSide.Builder = _builder;
            EnemyArenaSide.Builder = _builder;

            endTurn = EndTurnButton;
            drawCard = DrawCardButton;
        }

        public ArenaView(string playerName, string enemyName, IHero playerHero, IHero enemyHero, SignalRService service,
            MatchStats matchStats) : this()
        {
            service.RegisterMatchStats(matchStats);

            SetupArenaSide(PlayerArenaSide, playerName, playerHero.Name, _playerArenaViewModel);
            SetupArenaSide(EnemyArenaSide, enemyName, enemyHero.Name, _enemyArenaViewModel);

            HandView.RegisterSignalR(service);
            
            _endturn = new EndTurnCommand(service);
            _drawCard = new DrawCardCommand(_deck, this.HandView);

            service.OnReceiveCardDecks += OnCardsUpdateReceived;
            service.OnReceiveEndTurn += UpdateButtons;

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

        public void UpdateButtons(bool buttonStatus)
        {
            endTurn.Enabled = buttonStatus;
            drawCard.Enabled = buttonStatus;
        }

        private static void SetUsername(ArenaSide arenaSide, string username, string heroName)
        {
            string text = $"{username} ({heroName})";

            if (arenaSide.IsHandleCreated) arenaSide.Username = text;
        }



        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            _drawCard.execute();
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            _endturn.execute();
        }
    }
}
