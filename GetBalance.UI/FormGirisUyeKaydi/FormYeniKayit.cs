using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetBalance.DATA;
using GetBalance.DATA.Enums;

namespace GetBalance.UI
{
    public partial class FormYeniKayit : Form
    {
        public FormYeniKayit()
        {
            InitializeComponent();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text.Trim();
            string soyisim = txtSoyisim.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string sifreTekrar = txtSifre2.Text.Trim();
            Gender gender = rdnErkek.Checked ? Gender.Male : Gender.Female;

            if (String.IsNullOrEmpty(isim) || String.IsNullOrEmpty(soyisim) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(sifre) || String.IsNullOrEmpty(sifreTekrar) || dtpDogumTarihi.Value == DateTime.Now)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            else if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            User user = new User()
            {
                Email = email,
                Password = sifre,
                UserDetail = new UserDetail()
                {
                    FirstName = isim,
                    LastName = soyisim,
                    BirthDate = dtpDogumTarihi.Value,
                    Gender = gender,
                }
            };

            FormYeniKayit2 formYeniKayit2 = new FormYeniKayit2(this, user);
            formYeniKayit2.Show();
            this.Hide();

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
