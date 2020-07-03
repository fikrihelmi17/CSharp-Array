namespace array
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbMatkul = new System.Windows.Forms.ComboBox();
            this.txtJumlahData = new System.Windows.Forms.TextBox();
            this.txtNPM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtTugas = new System.Windows.Forms.TextBox();
            this.txtQuiz = new System.Windows.Forms.TextBox();
            this.txtUTS = new System.Windows.Forms.TextBox();
            this.txtUAS = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jumlah Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nilai Quiz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nilai Tugas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mata Kuliah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nama Mahasiswa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "NPM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nilai UAS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nilai UTS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(10, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(708, 136);
            this.dataGridView1.TabIndex = 12;
            // 
            // cmbMatkul
            // 
            this.cmbMatkul.FormattingEnabled = true;
            this.cmbMatkul.Items.AddRange(new object[] {
            "Algoritma Pemrograman I",
            "Pemrograman III",
            "Matematika Diskrit",
            "Sistem Basis Data",
            "Manajemen Proyek"});
            this.cmbMatkul.Location = new System.Drawing.Point(135, 118);
            this.cmbMatkul.Name = "cmbMatkul";
            this.cmbMatkul.Size = new System.Drawing.Size(200, 21);
            this.cmbMatkul.TabIndex = 13;
            // 
            // txtJumlahData
            // 
            this.txtJumlahData.Location = new System.Drawing.Point(135, 16);
            this.txtJumlahData.Name = "txtJumlahData";
            this.txtJumlahData.Size = new System.Drawing.Size(100, 20);
            this.txtJumlahData.TabIndex = 14;
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(135, 50);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(100, 20);
            this.txtNPM.TabIndex = 15;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(135, 81);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 16;
            // 
            // txtTugas
            // 
            this.txtTugas.Location = new System.Drawing.Point(135, 150);
            this.txtTugas.Name = "txtTugas";
            this.txtTugas.Size = new System.Drawing.Size(100, 20);
            this.txtTugas.TabIndex = 17;
            // 
            // txtQuiz
            // 
            this.txtQuiz.Location = new System.Drawing.Point(135, 180);
            this.txtQuiz.Name = "txtQuiz";
            this.txtQuiz.Size = new System.Drawing.Size(100, 20);
            this.txtQuiz.TabIndex = 18;
            // 
            // txtUTS
            // 
            this.txtUTS.Location = new System.Drawing.Point(135, 215);
            this.txtUTS.Name = "txtUTS";
            this.txtUTS.Size = new System.Drawing.Size(100, 20);
            this.txtUTS.TabIndex = 19;
            // 
            // txtUAS
            // 
            this.txtUAS.Location = new System.Drawing.Point(135, 249);
            this.txtUAS.Name = "txtUAS";
            this.txtUAS.Size = new System.Drawing.Size(100, 20);
            this.txtUAS.TabIndex = 20;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(260, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(135, 288);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 22;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(226, 288);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 23;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(320, 288);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 24;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NPM";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Mahasiswa";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mata Kuliah";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tugas";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quiz";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "UTS";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "UAS";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "NA";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "NM";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 465);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtUAS);
            this.Controls.Add(this.txtUTS);
            this.Controls.Add(this.txtQuiz);
            this.Controls.Add(this.txtTugas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.txtJumlahData);
            this.Controls.Add(this.cmbMatkul);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.ComboBox cmbMatkul;
        private System.Windows.Forms.TextBox txtJumlahData;
        private System.Windows.Forms.TextBox txtNPM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtTugas;
        private System.Windows.Forms.TextBox txtQuiz;
        private System.Windows.Forms.TextBox txtUTS;
        private System.Windows.Forms.TextBox txtUAS;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

