using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mata_v1.WindowsForms
{
    public partial class Configuration : Form
    {
        string path = string.Empty;

        
        public Configuration()
        {
            InitializeComponent();
            var com = MainSettings.Default.COM;
            if (string.IsNullOrWhiteSpace(com))
            {
                foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
                {
                    cComPortList.Items.Add(s);
                }
            }
            else
            {
                cComPortList.Items.Add(com);
                cComPortList.SelectedItem = cComPortList.Items[0]; //  cComPortList.FindString(com);// FindStringExact(com);
            }

            if (!string.IsNullOrWhiteSpace(MainSettings.Default.AreaHeight.ToString()))
                tHeight.Text = MainSettings.Default.AreaHeight.ToString();
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.AreaWidth.ToString()))
                tWidth.Text = MainSettings.Default.AreaWidth.ToString();

            tPatientPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.PatientFolderPath.ToString()))
            {
                tPatientPath.Text = MainSettings.Default.PatientFolderPath;
                path = MainSettings.Default.PatientFolderPath;
            }

            if (!string.IsNullOrWhiteSpace(MainSettings.Default.BaudRate.ToString()))
                tBaudRate.Text = MainSettings.Default.BaudRate.ToString();
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.DataBits.ToString()))
                tDataBits.Text = MainSettings.Default.DataBits.ToString();
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.Handshake))
            {
                cHandshake.DataSource = Enum.GetValues(typeof(Handshake));
                Handshake hand;
                var tmp = Handshake.TryParse(MainSettings.Default.Handshake, out hand);
                if (tmp)
                    cHandshake.SelectedItem = hand;
            }
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.Parity))
            {
                cParity.DataSource = Enum.GetValues(typeof(Parity));
                Parity parity;
                var tmp = Parity.TryParse(MainSettings.Default.Parity, out parity);
                if (tmp)
                    cParity.SelectedItem = parity;
            }
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.StopBits))
            {
                cStopBits.DataSource = Enum.GetValues(typeof(StopBits));
                StopBits stopBits;
                var tmp = StopBits.TryParse(MainSettings.Default.StopBits, out stopBits);
                if (tmp)
                    cStopBits.SelectedItem = stopBits;
            }
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.TimeOut.ToString()))
                tTimeOut.Text = MainSettings.Default.TimeOut.ToString();
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.STX))
                tSTX.Text = MainSettings.Default.STX;
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.ETX))
                tETX.Text = MainSettings.Default.ETX;
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.DLE))
                tDLE.Text = MainSettings.Default.DLE;
            if (!string.IsNullOrWhiteSpace(MainSettings.Default.StartBitmapSign))
                tSBitmap.Text = MainSettings.Default.StartBitmapSign;

            tConnected.Text = "Niepołączony z matą.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bSavePort_Click(object sender, EventArgs e)
        {
            string com = cComPortList.SelectedItem.ToString();
            MainSettings.Default.COM = cComPortList.SelectedItem.ToString();
            MainSettings.Default.Parity = cParity.SelectedItem.ToString();
            MainSettings.Default.Handshake = cHandshake.SelectedItem.ToString();
            MainSettings.Default.StopBits = cStopBits.SelectedItem.ToString();

            MainSettings.Default.DataBits = Convert.ToInt32(tDataBits.Text);
            MainSettings.Default.BaudRate = Convert.ToInt32(tBaudRate.Text);
            MainSettings.Default.TimeOut = Convert.ToInt32(tTimeOut.Text);

            MainSettings.Default.STX = tSTX.Text;
            MainSettings.Default.ETX = tETX.Text;
            MainSettings.Default.DLE = tDLE.Text;
            MainSettings.Default.StartBitmapSign = tSBitmap.Text;


            MainSettings.Default.Save();

            MessageBox.Show("Zapisano ustawienia polaczenia portu szeregowego.");
        }

        private void bTestConnection_Click(object sender, EventArgs e)
        {
            var msg = Receiver.TestConnection();
            MessageBox.Show(msg);
        }

        private void bSaveSize_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tHeight.Text))
                MainSettings.Default.AreaHeight = Convert.ToInt32(tHeight.Text);
            if (!string.IsNullOrWhiteSpace(tWidth.Text))
                MainSettings.Default.AreaWidth = Convert.ToInt32(tWidth.Text);
            MainSettings.Default.Save();

            MessageBox.Show("Zapisano wymiary pola roboczego maty.");
        }

        private void bPatientPath_Click(object sender, EventArgs e)
        {
            
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = (Directory.Exists(path) ? path : @"D:\");
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                    if (!string.IsNullOrWhiteSpace(path))
                    {
                        MainSettings.Default.PatientFolderPath = path;
                        MainSettings.Default.Save();
                        tPatientPath.Text = path;
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private enum Handshake
        {
            None,
            XOnXOff,
            RequestToSend,
            RequestToSendXOnXOff
        }

        private enum Parity
        {
            None,
            Odd,
            Even,
            Mark,
            Space
        }
        private enum StopBits
        {
            None,
            One,
            Two,
            OnePointFive
        }

       
    }
}
