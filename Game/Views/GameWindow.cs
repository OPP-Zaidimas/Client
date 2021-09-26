using System.Windows.Forms;
using Game.Views.User_Controls;
using Game.Services;

namespace Game
{
    public partial class GameWindow : Form
    {
        SignalRService _service;
        public GameWindow(SignalRService service)
        {
            InitializeComponent();
            _service = service;
            SetContent(new MainMenu(_service,this));
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
