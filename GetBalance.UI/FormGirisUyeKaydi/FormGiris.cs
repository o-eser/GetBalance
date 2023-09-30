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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHesapGiris_Click(object sender, EventArgs e)
        {
            FormUyeGirisi formUyeGirisi = new FormUyeGirisi();

            formUyeGirisi.Show();
            this.Hide();

        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            FormYeniKayit formYeniKayit = new FormYeniKayit();

            formYeniKayit.Show();
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
