using System.Windows.Forms;
using Game.Views.User_Controls;

namespace Game
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();

            ContentPanel.Controls.Add(new MainMenu());
        }
    }
}
