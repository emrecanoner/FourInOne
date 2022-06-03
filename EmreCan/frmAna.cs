using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmreCan
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Gitmek İstediğiniz Uygulamayı Seçiniz";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            frmUniSinavHesap frm = new frmUniSinavHesap();
            frm.Show();
            this.Hide();
            MessageBox.Show("Uygulamaya Hoşgeldiniz", "Emre Can", MessageBoxButtons.OK);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmNotOrtalama frm = new frmNotOrtalama();
            frm.Show();
            this.Hide();
            MessageBox.Show("Uygulamaya Hoşgeldiniz", "Emre Can", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmHavuzHacim frm = new frmHavuzHacim();
            frm.Show();
            this.Hide();
            MessageBox.Show("Uygulamaya Hoşgeldiniz", "Emre Can", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDoviz frm = new frmDoviz();
            frm.Show();
            this.Hide();
            MessageBox.Show("Uygulamaya Hoşgeldiniz", "Emre Can", MessageBoxButtons.OK);
        }

        private void frmAna_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
