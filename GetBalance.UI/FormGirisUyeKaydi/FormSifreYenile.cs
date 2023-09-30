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
    public partial class FormSifreYenile : Form
    {
        public FormSifreYenile()
        {
            InitializeComponent();
        }


        private bool surukleniyor = false;
        private Point surukleBaslangicNoktasi;
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyor = false;
        }
    }
}
