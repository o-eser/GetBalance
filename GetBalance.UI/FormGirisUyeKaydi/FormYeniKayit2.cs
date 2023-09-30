using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
using GetBalance.UI.Extensions;
using Microsoft.VisualBasic.ApplicationServices;
using User = GetBalance.DATA.User;

namespace GetBalance.UI
{
    public partial class FormYeniKayit2 : Form
    {
        GenericRepository<User> _userRepo;
        User _user;

        FormYeniKayit _yeniKayit;
        public FormYeniKayit2(FormYeniKayit formYeniKayit, User user)
        {
            InitializeComponent();

            _userRepo = new GenericRepository<User>();

            _yeniKayit = formYeniKayit;
            _user = user;
        }

        public FormYeniKayit2()
        {
            
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(txtBoy.Text.Trim());
            double weight = Convert.ToDouble(txtKilo.Text.Trim());
            double neckCircumference = Convert.ToDouble(txtBoyunCevresi.Text.Trim());
            double waistCircumference = Convert.ToDouble(txtBelCevresi.Text.Trim());
            double hipCircumference = Convert.ToDouble(txtKalcaCevresi.Text.Trim());
            ActivityLevel activityLevel = (ActivityLevel)cbxAktiviteSeviyesi.SelectedValue;

            if (height == 0 || weight == 0 || neckCircumference == 0 || waistCircumference == 0 || hipCircumference == 0 || cbxAktiviteSeviyesi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            _user.UserDetail.Height = height;

            _user.UserDetail.CurrentWeight = weight;
            _user.UserDetail.NeckCircumference = neckCircumference;
            _user.UserDetail.WaistCircumference = waistCircumference;	
            _user.UserDetail.HipCircumference = hipCircumference;


            _userRepo.Add(_user);

            FormHomePage formAnaSayfa = new FormHomePage(_user);
            formAnaSayfa.Show();
            this.Hide();

        }

        private void FormYeniKayit2_Load(object sender, EventArgs e)
        {
            cbxAktiviteSeviyesi.DataSource = Enum.GetValues(typeof(ActivityLevel))
                .Cast<ActivityLevel>()
                .Select(x => new
                {
                    Value = (int)x,
                    DisplayName = x.DisplayName()
                }).ToList();
            cbxAktiviteSeviyesi.DisplayMember = "DisplayName";
            cbxAktiviteSeviyesi.ValueMember = "Value";

            cbxAktiviteSeviyesi.SelectedIndex = -1;
        }



        private bool surukleniyor = false;
        private Point surukleBaslangicNoktasi;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyor = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyor)
            {
                Point yeniKonum = this.Location;
                yeniKonum.X += e.X - surukleBaslangicNoktasi.X;
                yeniKonum.Y += e.Y - surukleBaslangicNoktasi.Y;
                this.Location = yeniKonum;
            }
        }

    }
}
