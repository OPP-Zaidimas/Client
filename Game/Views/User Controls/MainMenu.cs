using System;
using System.Windows.Forms;

namespace Game.Views.User_Controls
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, EventArgs e) { }

        private void FindGameButton_Click(object sender, EventArgs e) { }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
