namespace Klinikum_Stuttgart
{
    partial class Frmeingang
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmeingang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDrLogin = new System.Windows.Forms.Button();
            this.BtnSekLogin = new System.Windows.Forms.Button();
            this.BtnPatientLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ärztinnen / Ärzte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sekretariat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patienten";
            // 
            // BtnDrLogin
            // 
            this.BtnDrLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnDrLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnDrLogin.Image")));
            this.BtnDrLogin.Location = new System.Drawing.Point(468, 60);
            this.BtnDrLogin.Name = "BtnDrLogin";
            this.BtnDrLogin.Size = new System.Drawing.Size(107, 75);
            this.BtnDrLogin.TabIndex = 8;
            this.BtnDrLogin.UseVisualStyleBackColor = false;
            this.BtnDrLogin.Click += new System.EventHandler(this.BtnDrLogin_Click);
            // 
            // BtnSekLogin
            // 
            this.BtnSekLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnSekLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSekLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnSekLogin.Image")));
            this.BtnSekLogin.Location = new System.Drawing.Point(244, 60);
            this.BtnSekLogin.Name = "BtnSekLogin";
            this.BtnSekLogin.Size = new System.Drawing.Size(114, 75);
            this.BtnSekLogin.TabIndex = 7;
            this.BtnSekLogin.UseVisualStyleBackColor = false;
            this.BtnSekLogin.Click += new System.EventHandler(this.BtnSekLogin_Click);
            // 
            // BtnPatientLogin
            // 
            this.BtnPatientLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnPatientLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnPatientLogin.Image")));
            this.BtnPatientLogin.Location = new System.Drawing.Point(31, 60);
            this.BtnPatientLogin.Name = "BtnPatientLogin";
            this.BtnPatientLogin.Size = new System.Drawing.Size(117, 75);
            this.BtnPatientLogin.TabIndex = 6;
            this.BtnPatientLogin.UseVisualStyleBackColor = false;
            this.BtnPatientLogin.Click += new System.EventHandler(this.BtnPatientLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Klinikum Stuttgart 2023";
            // 
            // Frmeingang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(601, 315);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDrLogin);
            this.Controls.Add(this.BtnSekLogin);
            this.Controls.Add(this.BtnPatientLogin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmeingang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klinikum Stuttgart ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDrLogin;
        private System.Windows.Forms.Button BtnSekLogin;
        private System.Windows.Forms.Button BtnPatientLogin;
        private System.Windows.Forms.Label label4;
    }
}

