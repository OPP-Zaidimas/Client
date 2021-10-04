using Game.Services;
using System;
using System.Windows.Forms;
using Game.Interfaces;

namespace Game.Views.User_Controls
{
    public partial class MainMenu : UserControl, IGameControlsCommands
    {
        private readonly GameWindow _window;
        public SignalRService _service;
        public MainMenu(SignalRService service, GameWindow window)
        {
            _service = service;
            _service.OnGameJoinFailureReceived += OnGameFailureReceived;
            InitializeComponent();

            _window = window;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            MatchIdForm openForm = MatchIdForm.ConnectedMatchIdForm(_service, usernameInput.Text);
            //Form openForm = new Form();
            openForm.Show();
        }

        private void FindGameButton_Click(object sender, EventArgs e)
        {
            _service.Connect().ContinueWith((task) =>
            {
                if (task.Exception != null)
                {
                    MessageBox.Show("Yeet nahui", "Gem nahui");
                }
            });
            _service.JoinGame(int.Parse(SessionIdInput.Text), usernameInput.Text)
                .ContinueWith((task) =>
                {
                    if (task.Exception != null)
                    {
                        MessageBox.Show("Yeet nahui v2", "Gem nahui");
                    }
                });
            //_window.SetContent(new ArenaView());
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void OnGameFailureReceived(string failureMsg)
        {
            MessageBox.Show(failureMsg, "This gem just yeeted itself");
        }
    }
}
