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
    public partial class frmHavuzHacim : Form
    {
        public frmHavuzHacim()
        {
            InitializeComponent();
        }
        decimal uzunluk = 0;
        decimal genişlik = 0;
        decimal derinlik = 0;
        decimal hacim = 0;
        decimal musluk1 = 0;
        decimal musluk2 = 0;
        decimal toplam = 0;
        decimal zaman = 0;
        
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            uzunluk = Convert.ToDecimal(spinEdit1.EditValue);
            genişlik = Convert.ToDecimal(spinEdit2.EditValue);
            derinlik = Convert.ToDecimal(spinEdit3.EditValue);
            hacim = uzunluk * genişlik * derinlik;
            hacim = Math.Round(hacim, 2);
            textBox1.Text = Convert.ToString(hacim + " " + "m³");
        }
        private void btnhesapla2_Click(object sender, EventArgs e)
        {
            musluk1 = Convert.ToDecimal(spinEdit4.EditValue);
            musluk2 = Convert.ToDecimal(spinEdit5.EditValue);
            toplam = musluk1 + musluk2;
            textBox3.Text = Convert.ToString(toplam +" "+"m³");
            zaman = hacim / toplam;
            zaman = Math.Round(zaman, 2);
            textBox2.Text = Convert.ToString(zaman +" "+"dakika");

        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            frmAna frm = new frmAna();
            frm.Show();
            this.Hide();

        }
    }
}
