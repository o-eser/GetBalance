using GetBalance.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetBalance.UI
{
    public partial class FormVucutYagOrani : Form
    {
        public FormVucutYagOrani()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int boy = Convert.ToInt32(txtBoy.Text);
                int bel = Convert.ToInt32(txtBelCevresi.Text);
                int boyun = Convert.ToInt32(txtBoyunCevresi.Text);
                int kalca = Convert.ToInt32(txtKalcaCevresi.Text);
                string cinsiyet = rdbErkek.Checked ? "erkek" : "kadın";
                decimal sonuc = CalculatorExtensions.VücutYağOraniHesapla(bel, boyun, kalca, boy, cinsiyet);
                lblVYODeger.Text = "%" + sonuc.ToString();
                cpbYVK.Value = Convert.ToInt64(sonuc);
                if (cinsiyet == "erkek")
                {
                    switch (sonuc)
                    {
                        case > 2 and <= 5:
                            lblYorum.Text = "Temel Yağ Seviyesi";
                            break;
                        case > 6 and <= 13:
                            lblYorum.Text = "Düşük Yağ Seviyesi";
                            break;
                        case > 14 and <= 17:
                            lblYorum.Text = "Fitness Seviyesi";
                            break;
                        case > 18 and <= 24:
                            lblYorum.Text = "Ortalama Yağ Seviyesi";
                            break;
                        case > 25:
                            lblYorum.Text = "Obezite";
                            break;
                        default:
                            lblYorum.Text = "Hatalı";
                            break;
                    }
                }
                else
                {
                    switch (sonuc)
                    {
                        case > 10 and <= 13:
                            lblYorum.Text = "Temel Yağ Seviyesi";
                            break;
                        case > 14 and <= 20:
                            lblYorum.Text = "Düşük Yağ Seviyesi";
                            break;
                        case > 21 and <= 24:
                            lblYorum.Text = "Fitness Seviyesi";
                            break;
                        case > 25 and <= 31:
                            lblYorum.Text = "Ortalama Yağ Seviyesi";
                            break;
                        case > 32:
                            lblYorum.Text = "Obezite";
                            break;
                        default:
                            lblYorum.Text = "Hatalı";
                            break;
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir değer giriniz !");
                txtBoy.Text = string.Empty;
                txtBelCevresi.Text = string.Empty;
                txtBoyunCevresi.Text = string.Empty;
                txtKalcaCevresi.Text = string.Empty;
                rdbErkek.Checked = false;
                rdbKadin.Checked = false;

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormHesaplamalar frmHesaplamalar = new FormHesaplamalar();
            frmHesaplamalar.Show();
            this.Hide();
        }
    }
}
