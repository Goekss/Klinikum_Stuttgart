namespace Klinikum_Stuttgart
{
    partial class FrmSekDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekDetail));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblSkid = new System.Windows.Forms.Label();
            this.LblSknamen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rchankndg = new System.Windows.Forms.RichTextBox();
            this.btnankng = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAktuel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Chkzustand = new System.Windows.Forms.CheckBox();
            this.MskId = new System.Windows.Forms.MaskedTextBox();
            this.CmbDr = new System.Windows.Forms.ComboBox();
            this.CmbFach = new System.Windows.Forms.ComboBox();
            this.MsktxtbxZeituhr = new System.Windows.Forms.MaskedTextBox();
            this.Msktxtdatum = new System.Windows.Forms.MaskedTextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnMitteilung = new System.Windows.Forms.Button();
            this.BtnTerminList = new System.Windows.Forms.Button();
            this.BtnFachPanel = new System.Windows.Forms.Button();
            this.BtnDrPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Termin -ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sekretärin - ID :";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(6, 34);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(129, 17);
            this.LblID.TabIndex = 9;
            this.LblID.Text = "Name - Nachname :";
            // 
            // LblSkid
            // 
            this.LblSkid.AutoSize = true;
            this.LblSkid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSkid.Location = new System.Drawing.Point(141, 54);
            this.LblSkid.Name = "LblSkid";
            this.LblSkid.Size = new System.Drawing.Size(97, 17);
            this.LblSkid.TabIndex = 10;
            this.LblSkid.Text = "00 000 000 000";
            // 
            // LblSknamen
            // 
            this.LblSknamen.AutoSize = true;
            this.LblSknamen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSknamen.Location = new System.Drawing.Point(141, 34);
            this.LblSknamen.Name = "LblSknamen";
            this.LblSknamen.Size = new System.Drawing.Size(30, 17);
            this.LblSknamen.TabIndex = 11;
            this.LblSknamen.Text = "null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSknamen);
            this.groupBox1.Controls.Add(this.LblSkid);
            this.groupBox1.Controls.Add(this.LblID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informationen von Ihnen";
            // 
            // Rchankndg
            // 
            this.Rchankndg.Location = new System.Drawing.Point(9, 26);
            this.Rchankndg.Name = "Rchankndg";
            this.Rchankndg.Size = new System.Drawing.Size(236, 166);
            this.Rchankndg.TabIndex = 0;
            this.Rchankndg.Text = "";
            // 
            // btnankng
            // 
            this.btnankng.Location = new System.Drawing.Point(6, 198);
            this.btnankng.Name = "btnankng";
            this.btnankng.Size = new System.Drawing.Size(77, 31);
            this.btnankng.TabIndex = 1;
            this.btnankng.Text = "Erstellen";
            this.btnankng.UseVisualStyleBackColor = true;
            this.btnankng.Click += new System.EventHandler(this.btnankng_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnankng);
            this.groupBox2.Controls.Add(this.Rchankndg);
            this.groupBox2.Location = new System.Drawing.Point(5, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mitteilungen";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAktuel);
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.Chkzustand);
            this.groupBox3.Controls.Add(this.MskId);
            this.groupBox3.Controls.Add(this.CmbDr);
            this.groupBox3.Controls.Add(this.CmbFach);
            this.groupBox3.Controls.Add(this.MsktxtbxZeituhr);
            this.groupBox3.Controls.Add(this.Msktxtdatum);
            this.groupBox3.Controls.Add(this.TxtId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(259, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 335);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Termin - Panel";
            // 
            // BtnAktuel
            // 
            this.BtnAktuel.Image = ((System.Drawing.Image)(resources.GetObject("BtnAktuel.Image")));
            this.BtnAktuel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAktuel.Location = new System.Drawing.Point(89, 276);
            this.BtnAktuel.Name = "BtnAktuel";
            this.BtnAktuel.Size = new System.Drawing.Size(88, 43);
            this.BtnAktuel.TabIndex = 17;
            this.BtnAktuel.Text = "    Aktualisieren";
            this.BtnAktuel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSave.Location = new System.Drawing.Point(183, 276);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 43);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Anlegen";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Chkzustand
            // 
            this.Chkzustand.AutoSize = true;
            this.Chkzustand.Location = new System.Drawing.Point(103, 217);
            this.Chkzustand.Name = "Chkzustand";
            this.Chkzustand.Size = new System.Drawing.Size(63, 19);
            this.Chkzustand.TabIndex = 16;
            this.Chkzustand.Text = "besetzt";
            this.Chkzustand.UseVisualStyleBackColor = true;
            // 
            // MskId
            // 
            this.MskId.Location = new System.Drawing.Point(103, 188);
            this.MskId.Mask = "00000000000";
            this.MskId.Name = "MskId";
            this.MskId.Size = new System.Drawing.Size(146, 23);
            this.MskId.TabIndex = 15;
            // 
            // CmbDr
            // 
            this.CmbDr.FormattingEnabled = true;
            this.CmbDr.Location = new System.Drawing.Point(103, 158);
            this.CmbDr.Name = "CmbDr";
            this.CmbDr.Size = new System.Drawing.Size(146, 23);
            this.CmbDr.TabIndex = 14;
            // 
            // CmbFach
            // 
            this.CmbFach.FormattingEnabled = true;
            this.CmbFach.Location = new System.Drawing.Point(103, 130);
            this.CmbFach.Name = "CmbFach";
            this.CmbFach.Size = new System.Drawing.Size(146, 23);
            this.CmbFach.TabIndex = 13;
            this.CmbFach.SelectedIndexChanged += new System.EventHandler(this.CmbFach_SelectedIndexChanged);
            // 
            // MsktxtbxZeituhr
            // 
            this.MsktxtbxZeituhr.Location = new System.Drawing.Point(103, 103);
            this.MsktxtbxZeituhr.Mask = "90:00";
            this.MsktxtbxZeituhr.Name = "MsktxtbxZeituhr";
            this.MsktxtbxZeituhr.Size = new System.Drawing.Size(146, 23);
            this.MsktxtbxZeituhr.TabIndex = 12;
            this.MsktxtbxZeituhr.ValidatingType = typeof(System.DateTime);
            // 
            // Msktxtdatum
            // 
            this.Msktxtdatum.Location = new System.Drawing.Point(103, 75);
            this.Msktxtdatum.Mask = "00/00/0000";
            this.Msktxtdatum.Name = "Msktxtdatum";
            this.Msktxtdatum.Size = new System.Drawing.Size(146, 23);
            this.Msktxtdatum.TabIndex = 11;
            this.Msktxtdatum.ValidatingType = typeof(System.DateTime);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(103, 45);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(146, 23);
            this.TxtId.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Zustand :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Patient/in ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Arzt/Ärztin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fach :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zeituhr :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(545, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 191);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fächer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(545, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(568, 220);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ärzten / Ärztinnen";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(562, 198);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnMitteilung);
            this.groupBox6.Controls.Add(this.BtnTerminList);
            this.groupBox6.Controls.Add(this.BtnFachPanel);
            this.groupBox6.Controls.Add(this.BtnDrPanel);
            this.groupBox6.Location = new System.Drawing.Point(2, 344);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(534, 78);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Zugriff";
            // 
            // BtnMitteilung
            // 
            this.BtnMitteilung.Location = new System.Drawing.Point(346, 47);
            this.BtnMitteilung.Name = "BtnMitteilung";
            this.BtnMitteilung.Size = new System.Drawing.Size(86, 31);
            this.BtnMitteilung.TabIndex = 5;
            this.BtnMitteilung.Text = "Mitteilungen";
            this.BtnMitteilung.UseVisualStyleBackColor = true;
            this.BtnMitteilung.Click += new System.EventHandler(this.BtnMitteilung_Click);
            // 
            // BtnTerminList
            // 
            this.BtnTerminList.Location = new System.Drawing.Point(252, 47);
            this.BtnTerminList.Name = "BtnTerminList";
            this.BtnTerminList.Size = new System.Drawing.Size(86, 31);
            this.BtnTerminList.TabIndex = 4;
            this.BtnTerminList.Text = "Termin-List";
            this.BtnTerminList.UseVisualStyleBackColor = true;
            this.BtnTerminList.Click += new System.EventHandler(this.BtnTerminList_Click);
            // 
            // BtnFachPanel
            // 
            this.BtnFachPanel.Location = new System.Drawing.Point(160, 47);
            this.BtnFachPanel.Name = "BtnFachPanel";
            this.BtnFachPanel.Size = new System.Drawing.Size(86, 31);
            this.BtnFachPanel.TabIndex = 3;
            this.BtnFachPanel.Text = "Fächer";
            this.BtnFachPanel.UseVisualStyleBackColor = true;
            this.BtnFachPanel.Click += new System.EventHandler(this.BtnFachPanel_Click);
            // 
            // BtnDrPanel
            // 
            this.BtnDrPanel.Location = new System.Drawing.Point(68, 47);
            this.BtnDrPanel.Name = "BtnDrPanel";
            this.BtnDrPanel.Size = new System.Drawing.Size(86, 31);
            this.BtnDrPanel.TabIndex = 2;
            this.BtnDrPanel.Text = "Arzt / Ärztin";
            this.BtnDrPanel.UseVisualStyleBackColor = true;
            this.BtnDrPanel.Click += new System.EventHandler(this.BtnDrPanel_Click);
            // 
            // FrmSekDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 441);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "FrmSekDetail";
            this.Text = "Ihre Informationen";
            this.Load += new System.EventHandler(this.FrmSekDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblSkid;
        private System.Windows.Forms.Label LblSknamen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox Rchankndg;
        private System.Windows.Forms.Button btnankng;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MsktxtbxZeituhr;
        private System.Windows.Forms.MaskedTextBox Msktxtdatum;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.CheckBox Chkzustand;
        private System.Windows.Forms.MaskedTextBox MskId;
        private System.Windows.Forms.ComboBox CmbDr;
        private System.Windows.Forms.ComboBox CmbFach;
        private System.Windows.Forms.Button BtnAktuel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnTerminList;
        private System.Windows.Forms.Button BtnFachPanel;
        private System.Windows.Forms.Button BtnDrPanel;
        private System.Windows.Forms.Button BtnMitteilung;
    }
}