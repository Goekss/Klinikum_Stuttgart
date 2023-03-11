namespace Klinikum_Stuttgart
{
    partial class FrmDrEinstellung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDrEinstellung));
            this.TxtPasswort = new System.Windows.Forms.TextBox();
            this.BtnAktuel = new System.Windows.Forms.Button();
            this.CmbFach = new System.Windows.Forms.ComboBox();
            this.Txtnachname = new System.Windows.Forms.TextBox();
            this.Txtvorname = new System.Windows.Forms.TextBox();
            this.MaskedID = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPasswort
            // 
            this.TxtPasswort.Location = new System.Drawing.Point(127, 118);
            this.TxtPasswort.Name = "TxtPasswort";
            this.TxtPasswort.Size = new System.Drawing.Size(130, 23);
            this.TxtPasswort.TabIndex = 57;
            // 
            // BtnAktuel
            // 
            this.BtnAktuel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAktuel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAktuel.Location = new System.Drawing.Point(53, 200);
            this.BtnAktuel.Name = "BtnAktuel";
            this.BtnAktuel.Size = new System.Drawing.Size(175, 24);
            this.BtnAktuel.TabIndex = 56;
            this.BtnAktuel.Text = "Aktualisieren";
            this.BtnAktuel.UseVisualStyleBackColor = false;
            this.BtnAktuel.Click += new System.EventHandler(this.BtnAktuel_Click);
            // 
            // CmbFach
            // 
            this.CmbFach.FormattingEnabled = true;
            this.CmbFach.Location = new System.Drawing.Point(127, 147);
            this.CmbFach.Name = "CmbFach";
            this.CmbFach.Size = new System.Drawing.Size(130, 23);
            this.CmbFach.TabIndex = 55;
            // 
            // Txtnachname
            // 
            this.Txtnachname.Location = new System.Drawing.Point(127, 60);
            this.Txtnachname.Name = "Txtnachname";
            this.Txtnachname.Size = new System.Drawing.Size(130, 23);
            this.Txtnachname.TabIndex = 53;
            // 
            // Txtvorname
            // 
            this.Txtvorname.Location = new System.Drawing.Point(127, 31);
            this.Txtvorname.Name = "Txtvorname";
            this.Txtvorname.Size = new System.Drawing.Size(130, 23);
            this.Txtvorname.TabIndex = 52;
            // 
            // MaskedID
            // 
            this.MaskedID.Location = new System.Drawing.Point(127, 89);
            this.MaskedID.Mask = "00 000 000 000";
            this.MaskedID.Name = "MaskedID";
            this.MaskedID.Size = new System.Drawing.Size(130, 23);
            this.MaskedID.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(61, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Passwort :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(83, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Fach :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(10, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Bürger ID nummer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(61, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Vorname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(50, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nachname :";
            // 
            // FrmDrEinstellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(266, 236);
            this.Controls.Add(this.TxtPasswort);
            this.Controls.Add(this.BtnAktuel);
            this.Controls.Add(this.CmbFach);
            this.Controls.Add(this.Txtnachname);
            this.Controls.Add(this.Txtvorname);
            this.Controls.Add(this.MaskedID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDrEinstellung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktualisierungen";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPasswort;
        private System.Windows.Forms.Button BtnAktuel;
        private System.Windows.Forms.ComboBox CmbFach;
        private System.Windows.Forms.TextBox Txtnachname;
        private System.Windows.Forms.TextBox Txtvorname;
        private System.Windows.Forms.MaskedTextBox MaskedID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}