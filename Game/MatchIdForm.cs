using Game.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Game
{
    public partial class MatchIdForm : Form
    {
        private SignalRService _service;
        private string message = "Connecting...";
        public string MSG 
        { 
            get { return message; } 
            set 
            { 
                message = value;
                updateLabel();
            } 
        }
        private void updateLabel()
        {
            MethodInvoker labelUpdate = delegate { label1.Text = message; };
            this.Invoke(labelUpdate);
        }
        
        private int id = -1;
        public MatchIdForm(SignalRService service)
        {
            _service = service;
            InitializeComponent();
            _service.MatchIdReceived += _service_MatchIdReceived;
        }

        private void _service_MatchIdReceived(int matchId)
        {
            id = matchId;
            MSG = "Your match id is: " + matchId;
        }

        public static MatchIdForm ConnectedMatchIdForm(SignalRService service)
        {
            MatchIdForm matchIdForm = new MatchIdForm(service);

            service.Connect().ContinueWith((task) =>
            {
                if (task.Exception != null)
                {
                    matchIdForm.MSG = "Failed to connect.";
                }
                else
                {
                    matchIdForm.MSG = "Successfully connected.";
                }
            });
            service.CreateNewGame();

            return matchIdForm;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
