namespace mata_v1.WindowsForms
{
    partial class Configuration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bSavePort = new System.Windows.Forms.Button();
            this.cComPortList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bTestConnection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cStopBits = new System.Windows.Forms.ComboBox();
            this.cParity = new System.Windows.Forms.ComboBox();
            this.cHandshake = new System.Windows.Forms.ComboBox();
            this.tSBitmap = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tDLE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tETX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tSTX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tTimeOut = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tDataBits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBaudRate = new System.Windows.Forms.TextBox();
            this.BaudRate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSaveSize = new System.Windows.Forms.Button();
            this.tWidth = new System.Windows.Forms.TextBox();
            this.tHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tPatientPath = new System.Windows.Forms.TextBox();
            this.bPatientPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tConnected = new System.Windows.Forms.TextBox();
            this.cAutoConnect = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port COM";
            // 
            // bSavePort
            // 
            this.bSavePort.Location = new System.Drawing.Point(274, 214);
            this.bSavePort.Name = "bSavePort";
            this.bSavePort.Size = new System.Drawing.Size(124, 23);
            this.bSavePort.TabIndex = 2;
            this.bSavePort.Text = "Zapisz";
            this.bSavePort.UseVisualStyleBackColor = true;
            this.bSavePort.Click += new System.EventHandler(this.bSavePort_Click);
            // 
            // cComPortList
            // 
            this.cComPortList.FormattingEnabled = true;
            this.cComPortList.Location = new System.Drawing.Point(92, 26);
            this.cComPortList.Name = "cComPortList";
            this.cComPortList.Size = new System.Drawing.Size(102, 21);
            this.cComPortList.TabIndex = 3;
            this.cComPortList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Test połączenia";
            // 
            // bTestConnection
            // 
            this.bTestConnection.Location = new System.Drawing.Point(100, 214);
            this.bTestConnection.Name = "bTestConnection";
            this.bTestConnection.Size = new System.Drawing.Size(124, 23);
            this.bTestConnection.TabIndex = 5;
            this.bTestConnection.Text = "Test połączenia";
            this.bTestConnection.UseVisualStyleBackColor = true;
            this.bTestConnection.Click += new System.EventHandler(this.bTestConnection_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cAutoConnect);
            this.groupBox1.Controls.Add(this.cStopBits);
            this.groupBox1.Controls.Add(this.cParity);
            this.groupBox1.Controls.Add(this.cHandshake);
            this.groupBox1.Controls.Add(this.tSBitmap);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tDLE);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tETX);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tSTX);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tTimeOut);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tDataBits);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tBaudRate);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.bSavePort);
            this.groupBox1.Controls.Add(this.bTestConnection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cComPortList);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 254);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Połączenie";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cStopBits
            // 
            this.cStopBits.FormattingEnabled = true;
            this.cStopBits.Location = new System.Drawing.Point(92, 160);
            this.cStopBits.Name = "cStopBits";
            this.cStopBits.Size = new System.Drawing.Size(102, 21);
            this.cStopBits.TabIndex = 30;
            // 
            // cParity
            // 
            this.cParity.FormattingEnabled = true;
            this.cParity.Location = new System.Drawing.Point(92, 132);
            this.cParity.Name = "cParity";
            this.cParity.Size = new System.Drawing.Size(102, 21);
            this.cParity.TabIndex = 29;
            // 
            // cHandshake
            // 
            this.cHandshake.FormattingEnabled = true;
            this.cHandshake.Location = new System.Drawing.Point(92, 105);
            this.cHandshake.Name = "cHandshake";
            this.cHandshake.Size = new System.Drawing.Size(102, 21);
            this.cHandshake.TabIndex = 28;
            // 
            // tSBitmap
            // 
            this.tSBitmap.Location = new System.Drawing.Point(296, 131);
            this.tSBitmap.Name = "tSBitmap";
            this.tSBitmap.Size = new System.Drawing.Size(102, 20);
            this.tSBitmap.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(215, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Bitmap start";
            // 
            // tDLE
            // 
            this.tDLE.Location = new System.Drawing.Point(296, 105);
            this.tDLE.Name = "tDLE";
            this.tDLE.Size = new System.Drawing.Size(102, 20);
            this.tDLE.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(215, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "DLE";
            // 
            // tETX
            // 
            this.tETX.Location = new System.Drawing.Point(296, 79);
            this.tETX.Name = "tETX";
            this.tETX.Size = new System.Drawing.Size(102, 20);
            this.tETX.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "ETX";
            // 
            // tSTX
            // 
            this.tSTX.Location = new System.Drawing.Point(296, 52);
            this.tSTX.Name = "tSTX";
            this.tSTX.Size = new System.Drawing.Size(102, 20);
            this.tSTX.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "STX";
            // 
            // tTimeOut
            // 
            this.tTimeOut.Location = new System.Drawing.Point(296, 26);
            this.tTimeOut.Name = "tTimeOut";
            this.tTimeOut.Size = new System.Drawing.Size(102, 20);
            this.tTimeOut.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "ReadTimeout";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "StopBits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Parity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Handshake";
            // 
            // tDataBits
            // 
            this.tDataBits.Location = new System.Drawing.Point(92, 79);
            this.tDataBits.Name = "tDataBits";
            this.tDataBits.Size = new System.Drawing.Size(102, 20);
            this.tDataBits.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "DataBits";
            // 
            // tBaudRate
            // 
            this.tBaudRate.Location = new System.Drawing.Point(92, 53);
            this.tBaudRate.Name = "tBaudRate";
            this.tBaudRate.Size = new System.Drawing.Size(102, 20);
            this.tBaudRate.TabIndex = 7;
            // 
            // BaudRate
            // 
            this.BaudRate.AutoSize = true;
            this.BaudRate.Location = new System.Drawing.Point(10, 56);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(55, 13);
            this.BaudRate.TabIndex = 6;
            this.BaudRate.Text = "BaudRate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSaveSize);
            this.groupBox2.Controls.Add(this.tWidth);
            this.groupBox2.Controls.Add(this.tHeight);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mata";
            // 
            // bSaveSize
            // 
            this.bSaveSize.Location = new System.Drawing.Point(313, 41);
            this.bSaveSize.Name = "bSaveSize";
            this.bSaveSize.Size = new System.Drawing.Size(75, 23);
            this.bSaveSize.TabIndex = 4;
            this.bSaveSize.Text = "Zapisz";
            this.bSaveSize.UseVisualStyleBackColor = true;
            this.bSaveSize.Click += new System.EventHandler(this.bSaveSize_Click);
            // 
            // tWidth
            // 
            this.tWidth.Location = new System.Drawing.Point(195, 65);
            this.tWidth.Name = "tWidth";
            this.tWidth.Size = new System.Drawing.Size(100, 20);
            this.tWidth.TabIndex = 3;
            // 
            // tHeight
            // 
            this.tHeight.Location = new System.Drawing.Point(195, 27);
            this.tHeight.Name = "tHeight";
            this.tHeight.Size = new System.Drawing.Size(100, 20);
            this.tHeight.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Szeroksoc pola pomiaru [px]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wysokosc pola pomiaru [px]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tPatientPath);
            this.groupBox3.Controls.Add(this.bPatientPath);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 109);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Katalogi plików";
            // 
            // tPatientPath
            // 
            this.tPatientPath.Enabled = false;
            this.tPatientPath.Location = new System.Drawing.Point(13, 39);
            this.tPatientPath.Multiline = true;
            this.tPatientPath.Name = "tPatientPath";
            this.tPatientPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tPatientPath.Size = new System.Drawing.Size(256, 41);
            this.tPatientPath.TabIndex = 2;
            // 
            // bPatientPath
            // 
            this.bPatientPath.Location = new System.Drawing.Point(296, 39);
            this.bPatientPath.Name = "bPatientPath";
            this.bPatientPath.Size = new System.Drawing.Size(75, 23);
            this.bPatientPath.TabIndex = 1;
            this.bPatientPath.Text = "Wybierz";
            this.bPatientPath.UseVisualStyleBackColor = true;
            this.bPatientPath.Click += new System.EventHandler(this.bPatientPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pacjenci";
            // 
            // tConnected
            // 
            this.tConnected.Enabled = false;
            this.tConnected.Location = new System.Drawing.Point(286, 496);
            this.tConnected.Name = "tConnected";
            this.tConnected.Size = new System.Drawing.Size(144, 20);
            this.tConnected.TabIndex = 9;
            // 
            // cAutoConnect
            // 
            this.cAutoConnect.AutoSize = true;
            this.cAutoConnect.Location = new System.Drawing.Point(266, 164);
            this.cAutoConnect.Name = "cAutoConnect";
            this.cAutoConnect.Size = new System.Drawing.Size(132, 17);
            this.cAutoConnect.TabIndex = 31;
            this.cAutoConnect.Text = "Łączyć automatycznie";
            this.cAutoConnect.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 528);
            this.Controls.Add(this.tConnected);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSavePort;
        private System.Windows.Forms.ComboBox cComPortList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bTestConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSaveSize;
        private System.Windows.Forms.TextBox tWidth;
        private System.Windows.Forms.TextBox tHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tPatientPath;
        private System.Windows.Forms.Button bPatientPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tConnected;
        private System.Windows.Forms.TextBox tSBitmap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tDLE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tETX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tSTX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tTimeOut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBaudRate;
        private System.Windows.Forms.Label BaudRate;
        private System.Windows.Forms.ComboBox cParity;
        private System.Windows.Forms.ComboBox cHandshake;
        private System.Windows.Forms.ComboBox cStopBits;
        private System.Windows.Forms.CheckBox cAutoConnect;
    }
}