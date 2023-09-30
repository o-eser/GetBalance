using GetBalance.DATA.Enums;
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
    public partial class FormKalpAtısHizi : Form
    {
        public FormKalpAtısHizi()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int yas = Convert.ToInt32(txtYas.Text);
                TrainingLevel trainingLevel = (TrainingLevel)cmbxAntremanSeviyesi.SelectedValue;
                int[] list = CalculatorExtensions.KalpAtisHiziHesapla(yas, trainingLevel);
                int maksimum = list[0];
                int hedef = list[1];
                lblMaxKalpAtisi.Text = maksimum.ToString();
                lblHedefKalpHizi.Text = hedef.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir değer giriniz !");
                txtYas.Text = string.Empty;
                cmbxAntremanSeviyesi.SelectedIndex = -1;
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormHesaplamalar frmHesaplamalar = new FormHesaplamalar();
            frmHesaplamalar.Show();
            this.Hide();
        }

        private void FormKalpAtısHizi_Load(object sender, EventArgs e)
        {
            cmbxAntremanSeviyesi.DataSource = Enum.GetValues(typeof(TrainingLevel))
                .Cast<TrainingLevel>()
                .Select(x => new
                {
                    Value = (int)x,
                    DisplayName = x.DisplayName()
                }).ToList();
            cmbxAntremanSeviyesi.DisplayMember = "DisplayName";
            cmbxAntremanSeviyesi.ValueMember = "Value";

            cmbxAntremanSeviyesi.SelectedIndex = -1;
        }
    }
}
