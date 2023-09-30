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
    public partial class FormHomePage2 : Form
    {

        Form formDuzenle;
        public Point downPoint = Point.Empty;

        public FormHomePage2()
        {
            InitializeComponent();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            formDuzenle = new FormDuzenle() { TopLevel = false, TopMost = true };
            pnlYanPanel.Controls.Add(formDuzenle);
            formDuzenle.Show();

        }
    }
}
