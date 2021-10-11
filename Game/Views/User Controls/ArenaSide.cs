using System.Windows.Forms;

namespace Game.Views.User_Controls
{
    public partial class ArenaSide : UserControl
    {
        public string Username
        {
            set
            {
                void SetUsername() => UsernameLabel.Text = value;

                Invoke((MethodInvoker)SetUsername);
            }
        }

        public ArenaSide()
        {
            InitializeComponent();
        }
    }
}
