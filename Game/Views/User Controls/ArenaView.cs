using System;
using System.Windows.Forms;
using Game.Models;
using Game.Models.Hero;
using Game.Services;
using Game.Services.AbstractFactory;

namespace Game.Views.User_Controls
{
    public partial class ArenaView : UserControl
    {
        private readonly Deck _deck;
        private SignalRService _service;
        private MatchStats _matchStats;

        public ArenaView()
        {
            InitializeComponent();

            _deck = new Deck(new DamagingCardFactory());
        }

        public ArenaView(string playerName, string enemyName, IHero playerHero, IHero enemyHero, SignalRService service, MatchStats matchStats) : this()
        {
            PlayerArenaSide.CreateControl();
            EnemyArenaSide.CreateControl();

            _service = service;
            _matchStats = matchStats;
            _service.RegisterMatchStats(matchStats);

            SetUsername(PlayerArenaSide, playerName, playerHero.Name);
            SetUsername(EnemyArenaSide, enemyName, enemyHero.Name);
            HandView.RegisterSignalR(service);

            _service.OnReceiveCardDecks += _service_OnReceiveCardDecks;
        }

        private void _service_OnReceiveCardDecks(int[] heroCards, int[] opponentCards)
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
