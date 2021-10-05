using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Game.Views.User_Controls
{
    public partial class ArenaSide : UserControl
    {
        private string clearName;
        public ArenaSide()
        {
            InitializeComponent();

        }
        internal void updateLabel(string name)
        {
            clearName = name;
            Thread.Sleep(5);
            MethodInvoker labelUpdate = delegate { label1.Text = clearName; };
            this.Invoke(labelUpdate);
        }
    }
}
