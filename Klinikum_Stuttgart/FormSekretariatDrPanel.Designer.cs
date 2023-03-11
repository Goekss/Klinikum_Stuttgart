namespace Klinikum_Stuttgart
{
    partial class FrmSekDrPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekDrPanel));
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbFach = new System.Windows.Forms.ComboBox();
            this.MskBürgerId = new System.Windows.Forms.MaskedTextBox();
            this.TxtNachname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLösch = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAktuel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(102, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(146, 23);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dr Name :";
            // 
            // CmbFach
            // 
            this.CmbFach.FormattingEnabled = true;
            this.CmbFach.Location = new System.Drawing.Point(102, 70);
            this.CmbFach.Name = "CmbFach";
            this.CmbFach.Size = new System.Drawing.Size(146, 23);
            this.CmbFach.TabIndex = 3;
            // 
            // MskBürgerId
            // 
            this.MskBürgerId.Location = new System.Drawing.Point(102, 101);
            this.MskBürgerId.Mask = "00000000000";
            this.MskBürgerId.Name = "MskBürgerId";
            this.MskBürgerId.Size = new System.Drawing.Size(146, 23);
            this.MskBürgerId.TabIndex = 4;
            // 
            // TxtNachname
            // 
            this.TxtNachname.Location = new System.Drawing.Point(102, 41);
            this.TxtNachname.Name = "TxtNachname";
            this.TxtNachname.Size = new System.Drawing.Size(146, 23);
            this.TxtNachname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dr Nachname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dr Fach :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dr Bürger-ID :";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(102, 130);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(146, 23);
            this.TxtPass.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dr Passwort :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 205);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnLösch
            // 
            this.BtnLösch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLösch.Location = new System.Drawing.Point(169, 159);
            this.BtnLösch.Name = "BtnLösch";
            this.BtnLösch.Size = new System.Drawing.Size(79, 26);
            this.BtnLösch.TabIndex = 27;
            this.BtnLösch.Text = "Löschen";
            this.BtnLösch.UseVisualStyleBackColor = true;
            this.BtnLösch.Click += new System.EventHandler(this.BtnLösch_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(91, 159);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(72, 26);
            this.BtnSave.TabIndex = 26;
            this.BtnSave.Text = "Einfügen";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAktuel
            // 
            this.BtnAktuel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAktuel.Location = new System.Drawing.Point(125, 191);
            this.BtnAktuel.Name = "BtnAktuel";
            this.BtnAktuel.Size = new System.Drawing.Size(87, 26);
            this.BtnAktuel.TabIndex = 28;
            this.BtnAktuel.Text = "Aktualisieren";
            this.BtnAktuel.UseVisualStyleBackColor = true;
            this.BtnAktuel.Click += new System.EventHandler(this.BtnAktuel_Click);
            // 
            // FrmSekDrPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(903, 230);
            this.Controls.Add(this.BtnAktuel);
            this.Controls.Add(this.BtnLösch);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNachname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MskBürgerId);
            this.Controls.Add(this.CmbFach);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSekDrPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dr Panel-Bearbeitungen";
            this.Load += new System.EventHandler(this.FrmSekDrPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbFach;
        private System.Windows.Forms.MaskedTextBox MskBürgerId;
        private System.Windows.Forms.TextBox TxtNachname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnLösch;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnAktuel;
    }
}