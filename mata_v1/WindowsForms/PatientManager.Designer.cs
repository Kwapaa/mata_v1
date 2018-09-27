namespace mata_v1
{
    public partial class PatientManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bPatientChoose = new System.Windows.Forms.Button();
            this.bPatientAddNew = new System.Windows.Forms.Button();
            this.bPatientSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tPatientPESEL = new System.Windows.Forms.TextBox();
            this.tPatientLastname = new System.Windows.Forms.TextBox();
            this.tPatientName = new System.Windows.Forms.TextBox();
            this.cPatientList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bPatientChoose);
            this.groupBox1.Controls.Add(this.bPatientAddNew);
            this.groupBox1.Controls.Add(this.bPatientSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tPatientPESEL);
            this.groupBox1.Controls.Add(this.tPatientLastname);
            this.groupBox1.Controls.Add(this.tPatientName);
            this.groupBox1.Controls.Add(this.cPatientList);
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pacjenta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bPatientChoose
            // 
            this.bPatientChoose.Location = new System.Drawing.Point(225, 87);
            this.bPatientChoose.Name = "bPatientChoose";
            this.bPatientChoose.Size = new System.Drawing.Size(105, 39);
            this.bPatientChoose.TabIndex = 9;
            this.bPatientChoose.Text = "Wybierz";
            this.bPatientChoose.UseVisualStyleBackColor = true;
            this.bPatientChoose.Click += new System.EventHandler(this.bPatientChoose_Click);
            // 
            // bPatientAddNew
            // 
            this.bPatientAddNew.Location = new System.Drawing.Point(225, 149);
            this.bPatientAddNew.Name = "bPatientAddNew";
            this.bPatientAddNew.Size = new System.Drawing.Size(105, 39);
            this.bPatientAddNew.TabIndex = 8;
            this.bPatientAddNew.Text = "Dodaj nowego";
            this.bPatientAddNew.UseVisualStyleBackColor = true;
            this.bPatientAddNew.Click += new System.EventHandler(this.bPatientAddNew_Click);
            // 
            // bPatientSave
            // 
            this.bPatientSave.Location = new System.Drawing.Point(60, 191);
            this.bPatientSave.Name = "bPatientSave";
            this.bPatientSave.Size = new System.Drawing.Size(75, 23);
            this.bPatientSave.TabIndex = 10;
            this.bPatientSave.Text = "Zapisz";
            this.bPatientSave.Click += new System.EventHandler(this.bPatientSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PESEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imie";
            // 
            // tPatientPESEL
            // 
            this.tPatientPESEL.Location = new System.Drawing.Point(16, 165);
            this.tPatientPESEL.Name = "tPatientPESEL";
            this.tPatientPESEL.Size = new System.Drawing.Size(171, 20);
            this.tPatientPESEL.TabIndex = 3;
            // 
            // tPatientLastname
            // 
            this.tPatientLastname.Location = new System.Drawing.Point(16, 126);
            this.tPatientLastname.Name = "tPatientLastname";
            this.tPatientLastname.Size = new System.Drawing.Size(171, 20);
            this.tPatientLastname.TabIndex = 2;
            // 
            // tPatientName
            // 
            this.tPatientName.Location = new System.Drawing.Point(16, 87);
            this.tPatientName.Name = "tPatientName";
            this.tPatientName.Size = new System.Drawing.Size(171, 20);
            this.tPatientName.TabIndex = 1;
            // 
            // cPatientList
            // 
            this.cPatientList.FormattingEnabled = true;
            this.cPatientList.Location = new System.Drawing.Point(16, 23);
            this.cPatientList.Name = "cPatientList";
            this.cPatientList.Size = new System.Drawing.Size(207, 21);
            this.cPatientList.TabIndex = 0;
            this.cPatientList.SelectedIndexChanged += new System.EventHandler(this.cPatientList_SelectedIndexChanged);
            // 
            // PatientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 317);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientManager";
            this.Text = "PatientManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPatientPESEL;
        private System.Windows.Forms.TextBox tPatientLastname;
        private System.Windows.Forms.TextBox tPatientName;
        private System.Windows.Forms.ComboBox cPatientList;
        private System.Windows.Forms.Button bPatientChoose;
        private System.Windows.Forms.Button bPatientAddNew;
        private System.Windows.Forms.Button bPatientSave;
    }
}