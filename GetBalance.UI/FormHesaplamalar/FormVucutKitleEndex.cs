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
    public partial class FormVucutKitleEndex : Form
    {
        public FormVucutKitleEndex()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {


            // TODO : boy kilo doğru girilip girilmediği kontrol edilecek.

            try
            {
                int boy = Convert.ToInt32(txtBoy.Text);
                int kilo = Convert.ToInt32(txtKilo.Text);
                decimal sonuc = CalculatorExtensions.VKİHesapla(kilo, boy);
                lblVKIDeger.Text = sonuc.ToString();
                cpbVKI.Value = Convert.ToInt64(sonuc);
                switch (sonuc)
                {
                    case < 18.5m:
                        lblYorum.Text = "Zayıf";
                        break;
                    case > 18.5m and < 24.9m:
                        lblYorum.Text = "Normal Kilo";
                        break;
                    case > 25.0m and < 29.9m:
                        lblYorum.Text = "Fazla Kilolu";
                        break;
                    case > 30.0m and < 34.9m:
                        lblYorum.Text = "1. Derece Obez";
                        break;
                    case > 35.0m and < 39.9m:
                        lblYorum.Text = "2. Derece Obez";
                        break;
                    case > 40.0m:
                        lblYorum.Text = "Morbid Obez";
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir değer giriniz !");
                txtBoy.Text = string.Empty;
                txtKilo.Text = string.Empty;

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            //TODO: Hesaplama Sayfasına Geri Dönmeli
            FormHesaplamalar frmHesaplamalar = new FormHesaplamalar();
            frmHesaplamalar.Show();
            this.Hide(); ////TODO: Hide dedim kapanıp yeni form açılma işine bakmak gerek;

        }

    }
}
