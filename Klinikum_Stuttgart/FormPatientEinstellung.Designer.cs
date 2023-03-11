namespace Klinikum_Stuttgart
{
    partial class FrmPattEinstellung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPattEinstellung));
            this.TxtPasswort = new System.Windows.Forms.TextBox();
            this.BtnAktuel = new System.Windows.Forms.Button();
            this.CmbSex = new System.Windows.Forms.ComboBox();
            this.MaskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.Txtnachname = new System.Windows.Forms.TextBox();
            this.Txtvorname = new System.Windows.Forms.TextBox();
            this.MaskedID = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPasswort
            // 
            this.TxtPasswort.Location = new System.Drawing.Point(109, 135);
            this.TxtPasswort.Name = "TxtPasswort";
            this.TxtPasswort.Size = new System.Drawing.Size(130, 20);
            this.TxtPasswort.TabIndex = 5;
            // 
            // BtnAktuel
            // 
            this.BtnAktuel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAktuel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAktuel.Location = new System.Drawing.Point(147, 191);
            this.BtnAktuel.Name = "BtnAktuel";
            this.BtnAktuel.Size = new System.Drawing.Size(92, 29);
            this.BtnAktuel.TabIndex = 43;
            this.BtnAktuel.Text = "Aktualisieren";
            this.BtnAktuel.UseVisualStyleBackColor = false;
            this.BtnAktuel.Click += new System.EventHandler(this.BtnAktuel_Click);
            // 
            // CmbSex
            // 
            this.CmbSex.FormattingEnabled = true;
            this.CmbSex.Items.AddRange(new object[] {
            "Herr ",
            "Frau  ",
            "Andere",
            "Keine Angabe"});
            this.CmbSex.Location = new System.Drawing.Point(109, 164);
            this.CmbSex.Name = "CmbSex";
            this.CmbSex.Size = new System.Drawing.Size(130, 21);
            this.CmbSex.TabIndex = 6;
            // 
            // MaskedTelefon
            // 
            this.MaskedTelefon.Location = new System.Drawing.Point(109, 105);
            this.MaskedTelefon.Mask = "(000)00000000";
            this.MaskedTelefon.Name = "MaskedTelefon";
            this.MaskedTelefon.Size = new System.Drawing.Size(130, 20);
            this.MaskedTelefon.TabIndex = 4;
            // 
            // Txtnachname
            // 
            this.Txtnachname.Location = new System.Drawing.Point(109, 47);
            this.Txtnachname.Name = "Txtnachname";
            this.Txtnachname.Size = new System.Drawing.Size(130, 20);
            this.Txtnachname.TabIndex = 2;
            // 
            // Txtvorname
            // 
            this.Txtvorname.Location = new System.Drawing.Point(109, 18);
            this.Txtvorname.Name = "Txtvorname";
            this.Txtvorname.Size = new System.Drawing.Size(130, 20);
            this.Txtvorname.TabIndex = 1;
            // 
            // MaskedID
            // 
            this.MaskedID.Location = new System.Drawing.Point(109, 76);
            this.MaskedID.Mask = "00000000000";
            this.MaskedID.Name = "MaskedID";
            this.MaskedID.Size = new System.Drawing.Size(130, 20);
            this.MaskedID.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(47, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Passwort :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(36, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Geschlecht :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(5, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Bürger ID nummer :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(54, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(48, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Vorname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nachname :";
            // 
            // FrmPattEinstellung
            // 
            this.AcceptButton = this.BtnAktuel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(259, 244);
            this.Controls.Add(this.TxtPasswort);
            this.Controls.Add(this.BtnAktuel);
            this.Controls.Add(this.CmbSex);
            this.Controls.Add(this.MaskedTelefon);
            this.Controls.Add(this.Txtnachname);
            this.Controls.Add(this.Txtvorname);
            this.Controls.Add(this.MaskedID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPattEinstellung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktualisierungen";
            this.Load += new System.EventHandler(this.FrmPattEinstellung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPasswort;
        private System.Windows.Forms.Button BtnAktuel;
        private System.Windows.Forms.ComboBox CmbSex;
        private System.Windows.Forms.MaskedTextBox MaskedTelefon;
        private System.Windows.Forms.TextBox Txtnachname;
        private System.Windows.Forms.TextBox Txtvorname;
        private System.Windows.Forms.MaskedTextBox MaskedID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}