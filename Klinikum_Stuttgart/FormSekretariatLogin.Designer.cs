namespace Klinikum_Stuttgart
{
    partial class FrmSekLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btneinloggin = new System.Windows.Forms.Button();
            this.Txtpasswort = new System.Windows.Forms.TextBox();
            this.MaskedID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btneinloggin
            // 
            this.Btneinloggin.BackColor = System.Drawing.Color.White;
            this.Btneinloggin.Location = new System.Drawing.Point(303, 156);
            this.Btneinloggin.Name = "Btneinloggin";
            this.Btneinloggin.Size = new System.Drawing.Size(89, 30);
            this.Btneinloggin.TabIndex = 20;
            this.Btneinloggin.Text = "Einloggen";
            this.Btneinloggin.UseVisualStyleBackColor = false;
            this.Btneinloggin.Click += new System.EventHandler(this.Btneinloggin_Click);
            // 
            // Txtpasswort
            // 
            this.Txtpasswort.Location = new System.Drawing.Point(252, 109);
            this.Txtpasswort.Name = "Txtpasswort";
            this.Txtpasswort.Size = new System.Drawing.Size(140, 23);
            this.Txtpasswort.TabIndex = 19;
            // 
            // MaskedID
            // 
            this.MaskedID.Location = new System.Drawing.Point(252, 80);
            this.MaskedID.Mask = "00000000000";
            this.MaskedID.Name = "MaskedID";
            this.MaskedID.Size = new System.Drawing.Size(140, 23);
            this.MaskedID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(165, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sekretärin-ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(186, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Passwort :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(222, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "  Sekretariat Login Panel  ";
            // 
            // FrmSekLogin
            // 
            this.AcceptButton = this.Btneinloggin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(615, 203);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btneinloggin);
            this.Controls.Add(this.Txtpasswort);
            this.Controls.Add(this.MaskedID);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSekLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekretärin Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btneinloggin;
        private System.Windows.Forms.TextBox Txtpasswort;
        private System.Windows.Forms.MaskedTextBox MaskedID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}