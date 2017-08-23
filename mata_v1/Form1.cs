using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mata_v1
{
    public partial class Form1 : Form
    {
        private Logic _logic;
        
        public Form1()
        {
            InitializeComponent();
            _logic = new Logic(tConsole,tConnect, pBox, tConsoleDuo);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bStart_Click(object sender, EventArgs e)
        {
            _logic.startReceiver();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            _logic.stopReceiver();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            _logic.connect();
        }
    }
}
