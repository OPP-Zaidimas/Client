using System;
using System.Windows.Forms;
using Game.Services.SignalR;

namespace Game.Views
{
    public partial class MatchIdForm : Form
    {
        private SignalRService _service;
        private string message = "Connecting...";
        private string _username;

        public string MSG
        {
            get => message;
            set
            {
                message = value;
                updateLabel();
            }
        }

        private void updateLabel()
        {
            MethodInvoker labelUpdate = delegate { label1.Text = message; };
            Invoke(labelUpdate);
        }

        private int id = -1;

        public MatchIdForm(SignalRService service)
        {
            _service = service;
            InitializeComponent();
            _service.MatchIdReceived += _service_MatchIdReceived;
            _service.CloseMatchWindow += ReceiveGameStart;
        }

        private void _service_MatchIdReceived(int matchId)
        {
            id = matchId;
            MSG = "Waiting for Player 2 to join. Copy the following match id";
            MethodInvoker textUpdate = delegate { MatchIdTextField.Text = "" + id; };
            Invoke(textUpdate);
        }

        public static MatchIdForm ConnectedMatchIdForm(SignalRService service, string username)
        {
            var matchIdForm = new MatchIdForm(service);
            matchIdForm._username = username;

            service.Connect().ContinueWith((task) =>
            {
                matchIdForm.MSG = task.Exception != null ? "Failed to connect." : "Successfully connected.";
            });
            service.CreateNewGame(matchIdForm._username).ContinueWith((task) =>
            {
                if (task.Exception != null) matchIdForm.MSG = "Failed to get id";
            });

            return matchIdForm;
        }

        public void ReceiveGameStart()
        {
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MatchIdTextField.Text);
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
