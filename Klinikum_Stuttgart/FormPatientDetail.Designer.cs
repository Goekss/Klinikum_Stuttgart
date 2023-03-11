namespace Klinikum_Stuttgart
{
    partial class FrmPatDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNamen = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTerminId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkEinstellung = new System.Windows.Forms.LinkLabel();
            this.BtnTermin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RchBeschwerungen = new System.Windows.Forms.RichTextBox();
            this.CmbDr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbFach = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNamen);
            this.groupBox1.Controls.Add(this.LblID);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informationen von Ihnen";
            // 
            // LblNamen
            // 
            this.LblNamen.AutoSize = true;
            this.LblNamen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamen.Location = new System.Drawing.Point(175, 35);
            this.LblNamen.Name = "LblNamen";
            this.LblNamen.Size = new System.Drawing.Size(30, 17);
            this.LblNamen.TabIndex = 3;
            this.LblNamen.Text = "null";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(173, 62);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(97, 17);
            this.LblID.TabIndex = 2;
            this.LblID.Text = "00 000 000 000";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(33, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 17);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Ihr Vor - Nachname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ihr ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTerminId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lnkEinstellung);
            this.groupBox2.Controls.Add(this.BtnTermin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RchBeschwerungen);
            this.groupBox2.Controls.Add(this.CmbDr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CmbFach);
            this.groupBox2.Location = new System.Drawing.Point(5, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termin Panel";
            // 
            // TxtTerminId
            // 
            this.TxtTerminId.Enabled = false;
            this.TxtTerminId.Location = new System.Drawing.Point(124, 42);
            this.TxtTerminId.Name = "TxtTerminId";
            this.TxtTerminId.Size = new System.Drawing.Size(193, 23);
            this.TxtTerminId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Termin ID :";
            // 
            // lnkEinstellung
            // 
            this.lnkEinstellung.AutoSize = true;
            this.lnkEinstellung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEinstellung.Image = ((System.Drawing.Image)(resources.GetObject("lnkEinstellung.Image")));
            this.lnkEinstellung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEinstellung.LinkColor = System.Drawing.Color.Black;
            this.lnkEinstellung.Location = new System.Drawing.Point(4, 355);
            this.lnkEinstellung.Name = "lnkEinstellung";
            this.lnkEinstellung.Size = new System.Drawing.Size(103, 17);
            this.lnkEinstellung.TabIndex = 7;
            this.lnkEinstellung.TabStop = true;
            this.lnkEinstellung.Text = "      Einstellungen";
            this.lnkEinstellung.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEinstellung_LinkClicked);
            // 
            // BtnTermin
            // 
            this.BtnTermin.Location = new System.Drawing.Point(174, 318);
            this.BtnTermin.Name = "BtnTermin";
            this.BtnTermin.Size = new System.Drawing.Size(142, 23);
            this.BtnTermin.TabIndex = 4;
            this.BtnTermin.Text = "einen Termin buchen";
            this.BtnTermin.UseVisualStyleBackColor = true;
            this.BtnTermin.Click += new System.EventHandler(this.BtnTermin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Beschwerden :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ärzten :";
            // 
            // RchBeschwerungen
            // 
            this.RchBeschwerungen.Location = new System.Drawing.Point(126, 161);
            this.RchBeschwerungen.Name = "RchBeschwerungen";
            this.RchBeschwerungen.Size = new System.Drawing.Size(193, 151);
            this.RchBeschwerungen.TabIndex = 2;
            this.RchBeschwerungen.Text = "";
            // 
            // CmbDr
            // 
            this.CmbDr.FormattingEnabled = true;
            this.CmbDr.Location = new System.Drawing.Point(124, 108);
            this.CmbDr.Name = "CmbDr";
            this.CmbDr.Size = new System.Drawing.Size(193, 23);
            this.CmbDr.TabIndex = 5;
            this.CmbDr.SelectedIndexChanged += new System.EventHandler(this.CmbDr_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fach :";
            // 
            // CmbFach
            // 
            this.CmbFach.FormattingEnabled = true;
            this.CmbFach.Location = new System.Drawing.Point(124, 75);
            this.CmbFach.Name = "CmbFach";
            this.CmbFach.Size = new System.Drawing.Size(193, 23);
            this.CmbFach.TabIndex = 3;
            this.CmbFach.SelectedIndexChanged += new System.EventHandler(this.CmbFach_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(334, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 253);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vergangene Termine";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(334, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 236);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktuelle Termine";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(739, 214);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FrmPatDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1087, 506);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmPatDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ihre Angaben";
            this.Load += new System.EventHandler(this.FrmPatDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNamen;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RchBeschwerungen;
        private System.Windows.Forms.ComboBox CmbFach;
        private System.Windows.Forms.Button BtnTermin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbDr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkEinstellung;
        private System.Windows.Forms.TextBox TxtTerminId;
        private System.Windows.Forms.Label label3;
    }
}