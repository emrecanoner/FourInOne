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
    public partial class frmUniSinavHesap : Form
    {
        public frmUniSinavHesap()
        {
            InitializeComponent();
        }
        double t_dogru = 0;
        double t_yanlis = 0;
        double t_bos = 0;
        double m_dogru = 0;
        double m_yanlis = 0;
        double m_bos = 0;
        double f_dogru = 0;
        double f_yanlis = 0;
        double f_bos = 0;
        double s_dogru = 0;
        double s_yanlis = 0;
        double s_bos = 0;
        double t_ort = 0;
        double m_ort = 0;
        double s_ort = 0;
        double f_ort = 0;
        double g_net = 0;


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btntürk_Click(object sender, EventArgs e)
        {
            t_dogru = Convert.ToDouble(tboxt_t.Text);
            t_yanlis = Convert.ToDouble(tboxt_f.Text);
            t_bos = Convert.ToDouble(tboxt_e.Text);
            Convert.ToDouble(t_dogru);
            Convert.ToDouble(t_yanlis);
            Convert.ToDouble(t_bos);
            t_ort = (t_dogru - (t_yanlis / 4));
            lblnettürk.Text = Convert.ToString(t_ort);
            if((t_dogru+t_yanlis+t_bos)>40)
            {
                MessageBox.Show("Fazla Girdiniz", "Uyarı", MessageBoxButtons.OK);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnmat_Click(object sender, EventArgs e)
        {
            m_dogru = Convert.ToDouble(tboxm_t.Text);
            m_yanlis = Convert.ToDouble(tboxm_f.Text);
            m_bos = Convert.ToDouble(tboxm_e.Text);
            Convert.ToDouble(m_dogru);
            Convert.ToDouble(m_yanlis);
            Convert.ToDouble(m_bos);
            m_ort = (m_dogru - (m_yanlis / 4));
            lblnetmat.Text = Convert.ToString(m_ort);
            if ((f_dogru + f_yanlis + f_bos) > 40)
            {
                MessageBox.Show("Fazla Girdiniz", "Uyarı", MessageBoxButtons.OK);

            }
        }

        private void btnfen_Click(object sender, EventArgs e)
        {
            f_dogru = Convert.ToDouble(tboxf_t.Text);
            f_yanlis = Convert.ToDouble(tboxf_f.Text);
            f_bos = Convert.ToDouble(tboxf_e.Text);
            Convert.ToDouble(f_dogru);
            Convert.ToDouble(f_yanlis);
            Convert.ToDouble(f_bos);
            f_ort = (f_dogru - (f_yanlis / 4));
            lblnetfen.Text = Convert.ToString(f_ort);
            if ((f_dogru + f_yanlis + f_bos) > 40)
            {
                MessageBox.Show("Fazla Girdiniz", "Uyarı", MessageBoxButtons.OK);

            }
        }

        private void btnsos_Click(object sender, EventArgs e)
        {
            s_dogru = Convert.ToDouble(tboxs_t.Text);
            s_yanlis = Convert.ToDouble(tboxs_f.Text);
            s_bos = Convert.ToDouble(tboxs_e.Text);
            Convert.ToDouble(s_dogru);
            Convert.ToDouble(s_yanlis);
            Convert.ToDouble(s_bos);
            s_ort = (s_dogru - (s_yanlis / 4));
            lblnetsos.Text = Convert.ToString(s_ort);
            if ((s_dogru + s_yanlis + s_bos) > 40)
            {
                MessageBox.Show("Fazla Girdiniz", "Uyarı", MessageBoxButtons.OK);

            }
        }

        private void btngenel_Click(object sender, EventArgs e)
        {
            g_net = (t_ort + f_ort + m_ort + s_ort);
            lblgenel.Text = Convert.ToString(g_net);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Her branş için 40 soru üzerinden değerlendiriniz.", "UYARI", MessageBoxButtons.OK);
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            frmAna frm = new frmAna();
            frm.Show();
            this.Hide();
        }
    }
}
