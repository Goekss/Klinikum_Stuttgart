namespace Klinikum_Stuttgart
{
    partial class FrmDrDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDrDetail));
            this.LblDrnamen = new System.Windows.Forms.Label();
            this.LblDrid = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchBeschwerdung = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEinstellung = new System.Windows.Forms.Button();
            this.BtnAnkündigung = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDrnamen
            // 
            this.LblDrnamen.AutoSize = true;
            this.LblDrnamen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrnamen.Location = new System.Drawing.Point(160, 72);
            this.LblDrnamen.Name = "LblDrnamen";
            this.LblDrnamen.Size = new System.Drawing.Size(30, 17);
            this.LblDrnamen.TabIndex = 7;
            this.LblDrnamen.Text = "null";
            // 
            // LblDrid
            // 
            this.LblDrid.AutoSize = true;
            this.LblDrid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrid.Location = new System.Drawing.Point(79, 44);
            this.LblDrid.Name = "LblDrid";
            this.LblDrid.Size = new System.Drawing.Size(97, 17);
            this.LblDrid.TabIndex = 6;
            this.LblDrid.Text = "00 000 000 000";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(25, 72);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(129, 17);
            this.LblID.TabIndex = 5;
            this.LblID.Text = "Name - Nachname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ihr ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchBeschwerdung);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminübersicht :";
            // 
            // RchBeschwerdung
            // 
            this.RchBeschwerdung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RchBeschwerdung.Location = new System.Drawing.Point(3, 19);
            this.RchBeschwerdung.Name = "RchBeschwerdung";
            this.RchBeschwerdung.Size = new System.Drawing.Size(333, 197);
            this.RchBeschwerdung.TabIndex = 1;
            this.RchBeschwerdung.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(357, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 438);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terminlist";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnEinstellung
            // 
            this.BtnEinstellung.BackColor = System.Drawing.Color.Orange;
            this.BtnEinstellung.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEinstellung.Image = ((System.Drawing.Image)(resources.GetObject("BtnEinstellung.Image")));
            this.BtnEinstellung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEinstellung.Location = new System.Drawing.Point(15, 362);
            this.BtnEinstellung.Name = "BtnEinstellung";
            this.BtnEinstellung.Size = new System.Drawing.Size(165, 42);
            this.BtnEinstellung.TabIndex = 3;
            this.BtnEinstellung.Text = "             Bearbeitung";
            this.BtnEinstellung.UseVisualStyleBackColor = false;
            this.BtnEinstellung.Click += new System.EventHandler(this.BtnEinstellung_Click);
            // 
            // BtnAnkündigung
            // 
            this.BtnAnkündigung.BackColor = System.Drawing.Color.Orange;
            this.BtnAnkündigung.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnkündigung.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnkündigung.Image")));
            this.BtnAnkündigung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnkündigung.Location = new System.Drawing.Point(186, 362);
            this.BtnAnkündigung.Name = "BtnAnkündigung";
            this.BtnAnkündigung.Size = new System.Drawing.Size(165, 42);
            this.BtnAnkündigung.TabIndex = 2;
            this.BtnAnkündigung.Text = "                Ankündigung";
            this.BtnAnkündigung.UseVisualStyleBackColor = false;
            this.BtnAnkündigung.Click += new System.EventHandler(this.BtnAnkündigung_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Orange;
            this.BtnExit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(15, 407);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(336, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "            Ausloggen";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmDrDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1105, 461);
            this.Controls.Add(this.LblDrnamen);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblDrid);
            this.Controls.Add(this.BtnAnkündigung);
            this.Controls.Add(this.BtnEinstellung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "FrmDrDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ihre Angaben";
            this.Load += new System.EventHandler(this.FrmDrDetail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblDrnamen;
        private System.Windows.Forms.Label LblDrid;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox RchBeschwerdung;
        private System.Windows.Forms.Button BtnEinstellung;
        private System.Windows.Forms.Button BtnAnkündigung;
        private System.Windows.Forms.Button BtnExit;
    }
}