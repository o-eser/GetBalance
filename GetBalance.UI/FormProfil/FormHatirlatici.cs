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
    public partial class FormHatirlatici : Form
    {
        public FormHatirlatici()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Alarm!!!");
        }

        private void btnAlarmKur_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32((nupSure.Value) - DateTime.Now.Second) * 3600000;

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void FormHatirlatici_Load(object sender, EventArgs e)
        {

        }
    }
}
