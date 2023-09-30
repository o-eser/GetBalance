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
    public partial class BazalMetabolizHiziForm : Form
    {
        public BazalMetabolizHiziForm()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int boy = Convert.ToInt32(txtBoy.Text);
                int kilo = Convert.ToInt32(txtKilo.Text);
                int yas = Convert.ToInt32(txtYas.Text);
                string cinsiyet = rdbErkek.Checked ? "erkek" : "kadın";
                lblBMHDeger.Text = CalculatorExtensions.BMRHesapla(boy, kilo, yas, cinsiyet).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir değer giriniz !");
                txtBoy.Text = string.Empty;
                txtKilo.Text = string.Empty;
                txtYas.Text = string.Empty;
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
