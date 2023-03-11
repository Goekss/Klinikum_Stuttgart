namespace Klinikum_Stuttgart
{
    partial class FrmPatRegistrieren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatRegistrieren));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txtvorname = new System.Windows.Forms.TextBox();
            this.Txtnachname = new System.Windows.Forms.TextBox();
            this.MaskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPasswort = new System.Windows.Forms.TextBox();
            this.CmbSex = new System.Windows.Forms.ComboBox();
            this.MskID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nachname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Vorname :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bürger ID nummer :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Telefon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Passwort :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Geschlecht :";
            // 
            // Txtvorname
            // 
            this.Txtvorname.Location = new System.Drawing.Point(116, 42);
            this.Txtvorname.Name = "Txtvorname";
            this.Txtvorname.Size = new System.Drawing.Size(130, 23);
            this.Txtvorname.TabIndex = 1;
            // 
            // Txtnachname
            // 
            this.Txtnachname.Location = new System.Drawing.Point(116, 71);
            this.Txtnachname.Name = "Txtnachname";
            this.Txtnachname.Size = new System.Drawing.Size(130, 23);
            this.Txtnachname.TabIndex = 2;
            // 
            // MaskedTelefon
            // 
            this.MaskedTelefon.Location = new System.Drawing.Point(116, 129);
            this.MaskedTelefon.Mask = "(000)00000000";
            this.MaskedTelefon.Name = "MaskedTelefon";
            this.MaskedTelefon.Size = new System.Drawing.Size(130, 23);
            this.MaskedTelefon.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(144, 230);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 32);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "    Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtPasswort
            // 
            this.TxtPasswort.Location = new System.Drawing.Point(116, 159);
            this.TxtPasswort.Name = "TxtPasswort";
            this.TxtPasswort.Size = new System.Drawing.Size(130, 23);
            this.TxtPasswort.TabIndex = 5;
            // 
            // CmbSex
            // 
            this.CmbSex.FormattingEnabled = true;
            this.CmbSex.Items.AddRange(new object[] {
            "Männlich\t",
            "Weiblich",
            "Andere"});
            this.CmbSex.Location = new System.Drawing.Point(116, 188);
            this.CmbSex.Name = "CmbSex";
            this.CmbSex.Size = new System.Drawing.Size(130, 23);
            this.CmbSex.TabIndex = 6;
            // 
            // MskID
            // 
            this.MskID.Location = new System.Drawing.Point(116, 100);
            this.MskID.Mask = "00000000000";
            this.MskID.Name = "MskID";
            this.MskID.Size = new System.Drawing.Size(130, 23);
            this.MskID.TabIndex = 3;
            // 
            // FrmPatRegistrieren
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(267, 291);
            this.Controls.Add(this.MskID);
            this.Controls.Add(this.TxtPasswort);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CmbSex);
            this.Controls.Add(this.MaskedTelefon);
            this.Controls.Add(this.Txtnachname);
            this.Controls.Add(this.Txtvorname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmPatRegistrieren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrierung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txtvorname;
        private System.Windows.Forms.TextBox Txtnachname;
        private System.Windows.Forms.MaskedTextBox MaskedTelefon;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtPasswort;
        private System.Windows.Forms.ComboBox CmbSex;
        private System.Windows.Forms.MaskedTextBox MskID;
    }
}