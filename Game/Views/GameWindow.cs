using System.Windows.Forms;

namespace Game.Views
{
    public partial class GameWindow : Form, IGameWindow
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        public void SetContent(UserControl control)
        {
            control.Dock = DockStyle.Fill;

            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(control);

            ContentPanel.Controls.Add(control);
        }
    }
}
