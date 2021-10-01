using System.Windows.Forms;
using Game.Views.User_Controls;

namespace Game
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();

            SetContent(new MainMenu(this));
        }

        public void SetContent(UserControl control)
        {
            control.Dock = DockStyle.Fill;

            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(control);
        }
    }
}
