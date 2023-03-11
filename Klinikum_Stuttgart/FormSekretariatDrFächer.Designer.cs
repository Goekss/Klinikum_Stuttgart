namespace Klinikum_Stuttgart
{
    partial class FrmSekDrFach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekDrFach));
            this.BtnAktuel = new System.Windows.Forms.Button();
            this.BtnLösch = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtFachname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFachId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAktuel
            // 
            this.BtnAktuel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAktuel.Location = new System.Drawing.Point(141, 188);
            this.BtnAktuel.Name = "BtnAktuel";
            this.BtnAktuel.Size = new System.Drawing.Size(105, 32);
            this.BtnAktuel.TabIndex = 42;
            this.BtnAktuel.Text = "Aktualisieren";
            this.BtnAktuel.UseVisualStyleBackColor = true;
            this.BtnAktuel.Click += new System.EventHandler(this.BtnAktuel_Click);
            // 
            // BtnLösch
            // 
            this.BtnLösch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLösch.Location = new System.Drawing.Point(141, 150);
            this.BtnLösch.Name = "BtnLösch";
            this.BtnLösch.Size = new System.Drawing.Size(105, 32);
            this.BtnLösch.TabIndex = 41;
            this.BtnLösch.Text = "Löschen";
            this.BtnLösch.UseVisualStyleBackColor = true;
            this.BtnLösch.Click += new System.EventHandler(this.BtnLösch_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(141, 112);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(105, 32);
            this.BtnSave.TabIndex = 40;
            this.BtnSave.Text = "Einfügen";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 189);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TxtFachname
            // 
            this.TxtFachname.Location = new System.Drawing.Point(100, 73);
            this.TxtFachname.Name = "TxtFachname";
            this.TxtFachname.Size = new System.Drawing.Size(146, 23);
            this.TxtFachname.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fach Name :";
            // 
            // TxtFachId
            // 
            this.TxtFachId.Location = new System.Drawing.Point(100, 31);
            this.TxtFachId.Name = "TxtFachId";
            this.TxtFachId.Size = new System.Drawing.Size(146, 23);
            this.TxtFachId.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fach ID :";
            // 
            // FrmSekDrFach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(543, 242);
            this.Controls.Add(this.BtnAktuel);
            this.Controls.Add(this.BtnLösch);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtFachname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtFachId);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmSekDrFach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fächer von Ärzten";
            this.Load += new System.EventHandler(this.FrmSekDrFach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAktuel;
        private System.Windows.Forms.Button BtnLösch;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtFachname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFachId;
        private System.Windows.Forms.Label label2;
    }
}