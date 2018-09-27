using mata_v1.WindowsForms;
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
           var msg =  _logic.stopReceiver();
           tConsole.Text += msg;
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            var msg = _logic.connect();
            tConsole.Text += msg;
        }

        private void menedzerPacjentowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientManager manager = new PatientManager();
            manager.Show();
        }

        private void zakonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void konfiguracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var msg = _logic.stopBitmaper();
            tConsole.Text += msg;
        }
    }
}
