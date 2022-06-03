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
    public partial class frmNotOrtalama : Form
    {
        public frmNotOrtalama()
        {
            InitializeComponent();
        }
        double türkçe1 = 0;
        double türkçe2 = 0;
        double türkçe3 = 0;
        double türkçe4 = 0;
        double türkçe5 = 0;
        double mat1 = 0;
        double mat2 = 0;
        double mat3 = 0;
        double mat4 = 0;
        double mat5 = 0;
        double ing1 = 0;
        double ing2 = 0;
        double ing3 = 0;
        double ing4 = 0;
        double ing5 = 0;
        double ort1 = 0;
        double ort2 = 0;
        double ort3 = 0;
        double ortgenel = 0;

        private void btnhesaplaT_Click(object sender, EventArgs e)
        {
            türkçe1 = Convert.ToDouble(textBox1.Text);
            türkçe2 = Convert.ToDouble(textBox2.Text);
            türkçe3 = Convert.ToDouble(textBox3.Text);
            türkçe4 = Convert.ToDouble(textBox4.Text);
            türkçe5 = Convert.ToDouble(textBox5.Text);
            Convert.ToDouble(türkçe1);
            Convert.ToDouble(türkçe2);
            Convert.ToDouble(türkçe3);
            Convert.ToDouble(türkçe4);
            Convert.ToDouble(türkçe5);
            ort1 = (türkçe1 + türkçe2 + türkçe3 + türkçe4 + türkçe5) / 5;
            lbl1.Text = Convert.ToString(ort1);
        }

        private void lblgenel_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnhesaplaM_Click(object sender, EventArgs e)
        {
            mat1 = Convert.ToDouble(textBox6.Text);
            mat2 = Convert.ToDouble(textBox7.Text);
            mat3 = Convert.ToDouble(textBox8.Text);
            mat4 = Convert.ToDouble(textBox9.Text);
            mat5 = Convert.ToDouble(textBox10.Text);
            Convert.ToDouble(mat1);
            Convert.ToDouble(mat2);
            Convert.ToDouble(mat3);
            Convert.ToDouble(mat4);
            Convert.ToDouble(mat5);
            ort2 = (mat1 + mat2 + mat3 + mat4 + mat5) / 5;
            lbl2.Text = Convert.ToString(ort2);
        }

        private void btnhesalaI_Click(object sender, EventArgs e)
        {
            ing1 = Convert.ToDouble(textBox11.Text);
            ing2 = Convert.ToDouble(textBox12.Text);
            ing3 = Convert.ToDouble(textBox13.Text);
            ing4 = Convert.ToDouble(textBox14.Text);
            ing5 = Convert.ToDouble(textBox15.Text);
            Convert.ToDouble(ing1);
            Convert.ToDouble(ing2);
            Convert.ToDouble(ing3);
            Convert.ToDouble(ing4);
            Convert.ToDouble(ing5);
            ort3 = (ing1 + ing2 + ing3 + ing4 + ing5) / 5;
            lbl3.Text = Convert.ToString(ort3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ortgenel = (ort1 + ort2 + ort3) / 3;
            lblgenel.Text = Convert.ToString(ortgenel);

            if (ortgenel <= 65)
            {
                MessageBox.Show(Convert.ToString(ortgenel), "sınıfta kaldınız", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(Convert.ToString(ortgenel), "sınıfı geçtiniz", MessageBoxButtons.OK);
            }
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            frmAna frm = new frmAna();
            frm.Show();
            this.Hide();
        }
    }
}
