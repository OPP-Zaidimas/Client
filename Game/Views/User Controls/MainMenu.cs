using Game.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Assets;
using Game.Interfaces;

namespace Game.Views.User_Controls
{
    public partial class MainMenu : UserControl, IGameControlsCommands
    {
        private readonly GameWindow _window;
        private readonly SignalRService _service;

        public MainMenu(SignalRService service, GameWindow window)
        {
            _service = service;
            _service.OnGameJoinFailureReceived += OnGameFailureReceived;
            _service.OnGameStartSignalReceived += OnGameStartReceived;
            InitializeComponent();

            _window = window;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            var openForm = MatchIdForm.ConnectedMatchIdForm(_service, usernameInput.Text);
            openForm.Show();
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
            _window.SetContent(new ArenaView(usernameInput.Text, opponentUsername));
        }
    }
}
