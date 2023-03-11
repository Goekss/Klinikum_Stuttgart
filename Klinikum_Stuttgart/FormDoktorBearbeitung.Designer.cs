namespace Klinikum_Stuttgart
{
    partial class FrmDrBearbeitung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDrBearbeitung));
            this.Txtnachname = new System.Windows.Forms.TextBox();
            this.Txtvorname = new System.Windows.Forms.TextBox();
            this.MaskedID = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPasswort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbFach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtnachname
            // 
            this.Txtnachname.Location = new System.Drawing.Point(144, 68);
            this.Txtnachname.Name = "Txtnachname";
            this.Txtnachname.Size = new System.Drawing.Size(130, 23);
            this.Txtnachname.TabIndex = 46;
            // 
            // Txtvorname
            // 
            this.Txtvorname.Location = new System.Drawing.Point(144, 37);
            this.Txtvorname.Name = "Txtvorname";
            this.Txtvorname.Size = new System.Drawing.Size(130, 23);
            this.Txtvorname.TabIndex = 45;
            // 
            // MaskedID
            // 
            this.MaskedID.Location = new System.Drawing.Point(144, 99);
            this.MaskedID.Mask = "00000000000";
            this.MaskedID.Name = "MaskedID";
            this.MaskedID.Size = new System.Drawing.Size(130, 23);
            this.MaskedID.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(27, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Bürger ID nummer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(78, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Vorname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(67, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nachname :";
            // 
            // TxtPasswort
            // 
            this.TxtPasswort.Location = new System.Drawing.Point(144, 161);
            this.TxtPasswort.Name = "TxtPasswort";
            this.TxtPasswort.Size = new System.Drawing.Size(130, 23);
            this.TxtPasswort.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(78, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Passwort :";
            // 
            // CmbFach
            // 
            this.CmbFach.FormattingEnabled = true;
            this.CmbFach.Location = new System.Drawing.Point(144, 130);
            this.CmbFach.Name = "CmbFach";
            this.CmbFach.Size = new System.Drawing.Size(130, 23);
            this.CmbFach.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(100, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Fach :";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(182, 202);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(92, 29);
            this.BtnSave.TabIndex = 51;
            this.BtnSave.Text = "Aktualisieren";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmDrBearbeitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 259);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbFach);
            this.Controls.Add(this.TxtPasswort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txtnachname);
            this.Controls.Add(this.Txtvorname);
            this.Controls.Add(this.MaskedID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDrBearbeitung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arzt -Daten bearbeiten";
            this.Load += new System.EventHandler(this.FrmDrBearbeitung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtnachname;
        private System.Windows.Forms.TextBox Txtvorname;
        private System.Windows.Forms.MaskedTextBox MaskedID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPasswort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbFach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
    }
}