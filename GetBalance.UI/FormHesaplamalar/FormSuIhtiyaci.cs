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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GetBalance.UI
{
    public partial class FormSuIhtiyaci : Form
    {
        public FormSuIhtiyaci()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {


            try
            {
                int kilo = Convert.ToInt32(txtKilo.Text);
                lblSuIhtiyaciDeger.Text = CalculatorExtensions.GünlükSuIhtiyaciHesapla(kilo).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir değer giriniz !");
                txtKilo.Text = string.Empty;

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
