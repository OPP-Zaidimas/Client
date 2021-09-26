using Game.Services;
using System;
using System.Windows.Forms;

namespace Game.Views.User_Controls
{
    public partial class MainMenu : UserControl
    {
        public SignalRService _service;
        public MainMenu(SignalRService service, GameWindow window)
        {
            _service = service;
            InitializeComponent();

            _window = window;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            MatchIdForm openForm = MatchIdForm.ConnectedMatchIdForm(_service);
            //Form openForm = new Form();
            openForm.Show();
        }

        private void FindGameButton_Click(object sender, EventArgs e)
        {
            _window.SetContent(new ArenaView());
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
