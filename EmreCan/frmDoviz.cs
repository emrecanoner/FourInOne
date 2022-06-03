using System;
using System.Windows.Forms;
using System.Xml;

namespace EmreCan
{
    public partial class frmDoviz : Form
    {
        public frmDoviz()
        {
            InitializeComponent();
        }
        decimal mevcut = 0;
        decimal hesap = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            if (rbtnsatis.Checked == true)
            {
                if (cbKurTipi.EditValue == "USD")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spUSDsatis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
                else if (cbKurTipi.EditValue == "EUR")
                { 
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spEURsatis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
                else if (cbKurTipi.EditValue == "CAD")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spCADsatis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
                else if (cbKurTipi.EditValue == "JPY")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spJPYsatis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
                else if (cbKurTipi.EditValue == "CNY")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spCNYsatis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
            }
            else if (rbtnalis.Checked == true)

            {
                if (cbKurTipi.EditValue == "USD")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spUSDAlis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
                else if (cbKurTipi.EditValue == "EUR")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(SspEURalis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
                else if (cbKurTipi.EditValue == "CAD")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spCADalis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
                else if (cbKurTipi.EditValue == "JPY")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spJPYalis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
                else if (cbKurTipi.EditValue == "CNY")
                {
                    if (spPara.EditValue != null)
                        decimal.TryParse(spPara.EditValue.ToString(), out mevcut);

                    hesap = mevcut / Convert.ToDecimal(spCNYalis.EditValue);
                    hesap = Math.Round(hesap, 2);
                    MessageBox.Show(hesap + " ", "İyi Günlerde Kullanın", MessageBoxButtons.OK);
                    rbtnalis.Checked = false;
                    rbtnsatis.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Seçenek Belirleyiniz", "UYARI", MessageBoxButtons.OK);
            }
        }
        void TCMBDovizKuruAl()
        {
            string today = "http://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string USD_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string USD_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            string CAD_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='CAD']/BanknoteBuying").InnerXml;
            string CAD_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='CAD']/BanknoteSelling").InnerXml;
            string JPY_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/BanknoteBuying").InnerXml;
            string JPY_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/BanknoteSelling").InnerXml;
            string CNY_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='CNY']/BanknoteBuying").InnerXml;
            string CNY_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='CNY']/BanknoteSelling").InnerXml;
            string EURO_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string EURO_Satis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            spUSDAlis.EditValue = USD_Alis.Replace(".", ",");
            SspEURalis.EditValue = EURO_Alis.Replace(".", ",");
            spCADalis.EditValue = CAD_Alis.Replace(".", ",");
            spJPYalis.EditValue = JPY_Alis.Replace(".", ",");
            spCNYalis.EditValue = CNY_Alis.Replace(".", ",");
            spUSDsatis.EditValue = USD_Satis.Replace(".", ",");
            spEURsatis.EditValue = EURO_Satis.Replace(".", ",");
            spCADsatis.EditValue = CAD_Satis.Replace(".", ",");
            spJPYsatis.EditValue = JPY_Satis.Replace(".", ",");
            spCNYsatis.EditValue = CNY_Satis.Replace(".", ",");

        }

        private void spbtn_Click_1(object sender, EventArgs e)
        {
            TCMBDovizKuruAl();
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            frmAna frm = new frmAna();
            frm.Show();
            this.Hide();
        }
    }
}
