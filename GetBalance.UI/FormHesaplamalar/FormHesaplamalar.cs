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
    public partial class FormHesaplamalar : Form
    {


        public FormHesaplamalar()
        {
            InitializeComponent();
        }


        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Tag.ToString();



            switch (btnName)
            {
                case "VKI": VKIOpen(); break;

                case "BMR": BMROpen(); break;

                case "VücutYağOranı": VücutYağOranıOpen(); break;

                case "GünlükKaloriİhtiyacı": GünlükKaloriİhtiyacıOpen(); break;

                case "GünlükSuİhtiyacı": GünlükSuİhtiyacıOpen(); break;

                case "MaksimumKalpHızı": MaksimumKalpHızıOpen(); break;

                case "İdealKilo": İdealKiloOpen(); break;

            }
        }


        #region FormOpen

        FormKalpAtısHizi formKalpAtısHizi;
        FormGunlukKaloriIhtiyaci formGunlukKalori;
        FormVucutKitleEndex frmVKI;
        FormSuIhtiyaci formSuIhtiyaci;
        FormIdealKilo formIdealKilo;
        BazalMetabolizHiziForm bazalMetabolizHiziForm;
        FormVucutYagOrani formVucutYagOrani;


        private void MaksimumKalpHızıOpen()
        {
            HideAllForms();
            formKalpAtısHizi.Show();


        }

        private void GünlükSuİhtiyacıOpen()
        {
            HideAllForms();
            formSuIhtiyaci.Show();

        }

        private void İdealKiloOpen()
        {
            HideAllForms();

            formIdealKilo.Show();
        }

        private void GünlükKaloriİhtiyacıOpen()
        {
            HideAllForms();
            formGunlukKalori.Show();

        }
        private void VücutYağOranıOpen()
        {
            HideAllForms();
            formVucutYagOrani.Show();

        }

        private void BMROpen()
        {
            HideAllForms();
            bazalMetabolizHiziForm.Show();
        }

        private void VKIOpen()
        {
            HideAllForms();
            frmVKI.Show();
        }

        #endregion


        private void FormHesaplamalar_Load(object sender, EventArgs e)
        {
            formKalpAtısHizi = new FormKalpAtısHizi() { TopLevel = false, TopMost = true };
            frmVKI = new FormVucutKitleEndex() { TopLevel = false, TopMost = true };
            bazalMetabolizHiziForm = new BazalMetabolizHiziForm() { TopLevel = false, TopMost = true };
            formVucutYagOrani = new FormVucutYagOrani() { TopLevel = false, TopMost = true };
            formGunlukKalori = new FormGunlukKaloriIhtiyaci() { TopLevel = false, TopMost = true };
            formSuIhtiyaci = new FormSuIhtiyaci() { TopLevel = false, TopMost = true };
            formIdealKilo = new FormIdealKilo() { TopLevel = false, TopMost = true };

            pnlHesaplamalar.Controls.Add(formKalpAtısHizi);
            pnlHesaplamalar.Controls.Add(frmVKI);
            pnlHesaplamalar.Controls.Add(bazalMetabolizHiziForm);
            pnlHesaplamalar.Controls.Add(formVucutYagOrani);
            pnlHesaplamalar.Controls.Add(formGunlukKalori);
            pnlHesaplamalar.Controls.Add(formSuIhtiyaci);
            pnlHesaplamalar.Controls.Add(formIdealKilo);
        }

        private void HideAllForms()
        {
            foreach (Form item in pnlHesaplamalar.Controls)
            {
                item.Hide();
            }

        }

        private void btnIdealKilo_Click(object sender, EventArgs e)
        {

        }

        private void btnGSI_Click(object sender, EventArgs e)
        {

        }

        private void btnMKAH_Click(object sender, EventArgs e)
        {

        }


       

    }


}
