using Game.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Assets;
using Game.Interfaces;
using Game.Models.Hero;

namespace Game.Views.User_Controls
{
    public partial class MainMenu : UserControl, IGameControlsCommands
    {
        // TODO: There should be an event instead of windows reference
        private readonly IGameWindow _window;
        private readonly SignalRService _service;
        private readonly IFactory<IHero> _heroFactory;

        public MainMenu(SignalRService service, IFactory<IHero> factory, IGameWindow window)
        {
            InitializeComponent();

            _service = service;
            _service.OnGameJoinFailureReceived += OnGameFailureReceived;
            _service.OnGameStartSignalReceived += OnGameStartReceived;

            _heroFactory = factory;
            _window = window;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            var openForm = MatchIdForm.ConnectedMatchIdForm(_service, usernameInput.Text);
            openForm.Show();
        }

        private void PlayLocalButton_Click(object sender, EventArgs e)
        {
            var playerHero = _heroFactory.Create(1);
            var enemyHero = _heroFactory.Create(2);

            _window.SetContent(new ArenaView(usernameInput.Text, "Bot", playerHero, enemyHero));
        }

        private void FindGameButton_Click(object sender, EventArgs e)
        {
            _service.Connect().ContinueWith(DisplayError);
            _service.JoinGame(int.Parse(SessionIdInput.Text), usernameInput.Text).ContinueWith(DisplayError);
        }

        private static void DisplayError(Task task)
        {
            if (task.Exception != null)
            {
                MessageBox.Show(Strings.ConnectionError);
            }
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void OnGameFailureReceived(string failureMsg)
        {
            MessageBox.Show(failureMsg, Strings.GameJoinError);
        }

        public void OnGameStartReceived(string opponentUsername)
        {
            // TODO: Create Heroes using id's received from the Backend
            var playerHero = _heroFactory.Create(1);
            var enemyHero = _heroFactory.Create(2);

            _window.SetContent(new ArenaView(usernameInput.Text, opponentUsername, playerHero, enemyHero));
        }
    }
}
