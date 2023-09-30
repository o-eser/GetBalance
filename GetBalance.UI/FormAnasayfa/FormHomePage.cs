using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetBalance.DATA;

namespace GetBalance.UI
{
    public partial class FormHomePage : Form
    {


        Form formGunluk, formProfil, formAnasayfa, formHesaplamalar, formRapor;


        public Point downPoint = Point.Empty;



        User _user;
        public FormHomePage()
        {
            InitializeComponent();



        }

        public FormHomePage(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            formGunluk = new FormGunluk() { TopLevel = false, TopMost = true };

            formProfil = new FormProfil() { TopLevel = false, TopMost = true };
            formAnasayfa = new FormHomePage2() { TopLevel = false, TopMost = true };
            formHesaplamalar = new FormHesaplamalar() { TopLevel = false, TopMost = true };
            formRapor = new FormRapor() { TopLevel = false, TopMost = true };
            pnlAnaPanel.Controls.Add(formGunluk);
            pnlAnaPanel.Controls.Add(formAnasayfa);
            pnlAnaPanel.Controls.Add(formProfil);
            pnlAnaPanel.Controls.Add(formHesaplamalar);
            pnlAnaPanel.Controls.Add(formRapor);
            formAnasayfa.Show();


            pnlAnaPanel.Controls.Add(formGunluk);
            pnlAnaPanel.Controls.Add(formHesaplamalar);
        }

        #region SidePanelTransition

        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menuContainer.Width -= 10;
                formGunluk.Width += 10;
                //transitionOldu(10);

                if (menuContainer.Width <= 58)
                {
                    menuExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                menuContainer.Width += 10;
                formGunluk.Width -= 10;
                //transitionOldu(-10);

                if (menuContainer.Width >= 205)
                {

                    menuExpand = true;
                    menuTransition.Stop();

                }
            }
        }
        #endregion

        #region MenuButtons

        private void btnHome_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            //this.transitionOldu += formGunluk.

        }
        private void btnProfil_Click(object sender, EventArgs e)
        {
            HideAllForms();
            formProfil.Show();

        }
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            HideAllForms();
            formAnasayfa.Show();
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {

            HideAllForms();
            formGunluk.Show();
        }

        private void btnHesaplamalar_Click(object sender, EventArgs e)
        {

            HideAllForms();
            formHesaplamalar.Show();
        }


        private void btnRaporlar_Click(object sender, EventArgs e)
        {

            HideAllForms();
            formRapor.Show();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #endregion

        private void HideAllForms()
        {
            foreach (Form item in pnlAnaPanel.Controls)
            {
                item.Hide();
            }
        }



        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            surukleniyor = true;
            surukleBaslangicNoktasi = e.Location;


        }




        private bool surukleniyor = false;
        private Point surukleBaslangicNoktasi;

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyor)
            {
                Point yeniKonum = this.Location;
                yeniKonum.X += e.X - surukleBaslangicNoktasi.X;
                yeniKonum.Y += e.Y - surukleBaslangicNoktasi.Y;
                this.Location = yeniKonum;
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyor = false;
        }


    }
}

