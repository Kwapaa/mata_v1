namespace mata_v1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox = new System.Windows.Forms.PictureBox();
            this.tConsole = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.bConnectAgain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tConnect = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tConsoleDuo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakonczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacjenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menedzerPacjentowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(336, 51);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(400, 200);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            // 
            // tConsole
            // 
            this.tConsole.Location = new System.Drawing.Point(336, 338);
            this.tConsole.Multiline = true;
            this.tConsole.Name = "tConsole";
            this.tConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tConsole.Size = new System.Drawing.Size(389, 108);
            this.tConsole.TabIndex = 1;
            this.tConsole.WordWrap = false;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(358, 270);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(110, 35);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(601, 270);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(110, 35);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(22, 19);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 4;
            this.bConnect.Text = "polacz";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bConnectAgain
            // 
            this.bConnectAgain.Location = new System.Drawing.Point(147, 19);
            this.bConnectAgain.Name = "bConnectAgain";
            this.bConnectAgain.Size = new System.Drawing.Size(75, 23);
            this.bConnectAgain.TabIndex = 5;
            this.bConnectAgain.Text = "ponow probe";
            this.bConnectAgain.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tConnect);
            this.groupBox1.Controls.Add(this.bConnect);
            this.groupBox1.Controls.Add(this.bConnectAgain);
            this.groupBox1.Location = new System.Drawing.Point(21, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "polaczenie z mata";
            // 
            // tConnect
            // 
            this.tConnect.Enabled = false;
            this.tConnect.Location = new System.Drawing.Point(21, 56);
            this.tConnect.Multiline = true;
            this.tConnect.Name = "tConnect";
            this.tConnect.Size = new System.Drawing.Size(233, 39);
            this.tConnect.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(21, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 211);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "dane pacjenta";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(22, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(182, 30);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dodaj pacjenta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PESEL";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tConsoleDuo
            // 
            this.tConsoleDuo.Location = new System.Drawing.Point(12, 381);
            this.tConsoleDuo.Multiline = true;
            this.tConsoleDuo.Name = "tConsoleDuo";
            this.tConsoleDuo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tConsoleDuo.Size = new System.Drawing.Size(261, 75);
            this.tConsoleDuo.TabIndex = 9;
            this.tConsoleDuo.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pacjenciToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakonczToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakonczToolStripMenuItem
            // 
            this.zakonczToolStripMenuItem.Name = "zakonczToolStripMenuItem";
            this.zakonczToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakonczToolStripMenuItem.Text = "Zakoncz";
            this.zakonczToolStripMenuItem.Click += new System.EventHandler(this.zakonczToolStripMenuItem_Click);
            // 
            // pacjenciToolStripMenuItem
            // 
            this.pacjenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menedzerPacjentowToolStripMenuItem});
            this.pacjenciToolStripMenuItem.Name = "pacjenciToolStripMenuItem";
            this.pacjenciToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pacjenciToolStripMenuItem.Text = "Pacjenci";
            // 
            // menedzerPacjentowToolStripMenuItem
            // 
            this.menedzerPacjentowToolStripMenuItem.Name = "menedzerPacjentowToolStripMenuItem";
            this.menedzerPacjentowToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.menedzerPacjentowToolStripMenuItem.Text = "Menedzer pacjentow";
            this.menedzerPacjentowToolStripMenuItem.Click += new System.EventHandler(this.menedzerPacjentowToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            this.konfiguracjaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.konfiguracjaToolStripMenuItem.Text = "Konfiguracja";
            this.konfiguracjaToolStripMenuItem.Click += new System.EventHandler(this.konfiguracjaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tConsoleDuo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tConsole);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "mata v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.TextBox tConsole;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bConnectAgain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tConsoleDuo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakonczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacjenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menedzerPacjentowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

