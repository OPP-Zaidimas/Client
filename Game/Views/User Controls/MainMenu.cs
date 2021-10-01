using System;
using System.Windows.Forms;

namespace Game.Views.User_Controls
{
    public partial class MainMenu : UserControl
    {
        private GameWindow _window;

        public MainMenu(GameWindow window)
        {
            InitializeComponent();

            _window = window;
        }

        private void NewGameButton_Click(object sender, EventArgs e) {


            MatchIdForm openForm = new MatchIdForm();
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
