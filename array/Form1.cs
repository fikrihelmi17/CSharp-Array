using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        int jumlah;
        string[] npm;
        string[] namaMhs;
        string[] matkul;
        int[] tugas;
        int[] quiz;
        int[] uts;
        int[] uas;


        int i = 0;
        double na;
        double nm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            jumlah = Convert.ToInt32(txtJumlahData.Text);

            npm = new string[jumlah];
            namaMhs = new string[jumlah];
            matkul = new string[jumlah];
            tugas = new int[jumlah];
            quiz = new int[jumlah];
            uts = new int[jumlah];
            uas = new int[jumlah];



        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(i <= jumlah - 1)
            {
                npm[i] = txtNPM.Text;
                namaMhs[i] = txtNama.Text;
                matkul[i] = cmbMatkul.Text;
                tugas[i] = Convert.ToInt32(txtTugas.Text);
                quiz[i] = Convert.ToInt32(txtQuiz.Text);
                uts[i] = Convert.ToInt32(txtUTS.Text);
                uas[i] = Convert.ToInt32(txtUAS.Text);

                i++;
            } else
            {
                MessageBox.Show("Data tidak boleh lebih dari "+ jumlah);
            }

            txtNPM.Clear();
            txtNama.Clear();
            cmbMatkul.ResetText();
            txtQuiz.Clear();
            txtTugas.Clear();
            txtNPM.Focus();
            txtUTS.Text = "";
            txtUAS.Text = "";
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            for (int j=0; j < jumlah; j++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[j].Cells[0].Value = j + i;
                dataGridView1.Rows[j].Cells[1].Value = npm[j];
                dataGridView1.Rows[j].Cells[2].Value = namaMhs[j];
                dataGridView1.Rows[j].Cells[3].Value = matkul[j];
                dataGridView1.Rows[j].Cells[4].Value = tugas[j];
                dataGridView1.Rows[j].Cells[5].Value = quiz[j];
                dataGridView1.Rows[j].Cells[6].Value = uts[j];
                dataGridView1.Rows[j].Cells[7].Value = uas[j];

                na = (tugas[j] * 0.1) + (quiz[j] * 0.2) + (uts[j] * 0.3) + (uas[j] * 0.4);

                dataGridView1.Rows[j].Cells[8].Value = na;

                if (na >= 80)
                {
                    dataGridView1.Rows[j].Cells[9].Value = "A";
                }
                else if (na >= 70 && na <= 79)
                {
                    dataGridView1.Rows[j].Cells[9].Value = "B";
                }
                else if (na >= 60 && na <= 69)
                {
                    dataGridView1.Rows[j].Cells[9].Value = "C";
                }
                else if (na >= 50 && na <= 59)
                {
                    dataGridView1.Rows[j].Cells[9].Value = "D";
                }
                else if (na < 50)
                {
                    dataGridView1.Rows[j].Cells[9].Value = "E";
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtNPM.Clear();
            txtNama.Clear();
            cmbMatkul.ResetText();
            txtQuiz.Clear();
            txtTugas.Clear();
            txtNPM.Focus();
            txtUTS.Text = "";
            txtUAS.Text = "";
        }
    }
}
