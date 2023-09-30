using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GetBalance.UI.FormHomePage;

namespace GetBalance.UI
{
    public partial class FormGunluk : Form
    {
        GenericRepository<Meal> _meal;


        bool kahvaltiAcikMi, ogleAcikMi, aksamAcikMi, aperatifAcikMi = false;
        Point pbAddButtonLoc = new Point(5, 5);
        Point tlpVerilerLoc = new Point(473, 3);

        DateTime date;

        public FormGunluk()
        {
            InitializeComponent();
            _meal = new GenericRepository<Meal>();

            pnlKahveLsv.Visible = pnlOgleLsv.Visible = pnlAksamLsv.Visible = pnlAperatifLsv.Visible = false;

        }

        //public void LocGuncellendi(int pixel)
        //{
        //    MessageBox.Show("Metot tetiklendi.");
        //    //tlpKahvaltiVeriler.Location.X = pixel;
        //    //tlpOgleVeriler.Location = tlpVerilerLoc;
        //    //tlpAksamVeriler.Location = tlpVerilerLoc;
        //    //tlpAperatifVeriler.Location = tlpVerilerLoc;
        //}

        private void FormGunluk_Load(object sender, EventArgs e)
        {
            pbAddKahvalti.Parent = btnKahvalti;
            pbAddOgle.Parent = btnOgleYemegi;
            pbAddAksam.Parent = btnAksamYmegi;
            pbAddAperatif.Parent = btnAperatif;

            tlpKahvaltiVeriler.Parent = btnKahvalti;
            tlpOgleVeriler.Parent = btnOgleYemegi;
            tlpAksamVeriler.Parent = btnAksamYmegi;
            tlpAperatifVeriler.Parent = btnAperatif;

            pbAddKahvalti.Location = pbAddButtonLoc;
            pbAddOgle.Location = pbAddButtonLoc;
            pbAddAksam.Location = pbAddButtonLoc;
            pbAddAperatif.Location = pbAddButtonLoc;

            tlpKahvaltiVeriler.Location = tlpVerilerLoc;
            tlpOgleVeriler.Location = tlpVerilerLoc;
            tlpAksamVeriler.Location = tlpVerilerLoc;
            tlpAperatifVeriler.Location = tlpVerilerLoc;

            date = DateTime.Today;
            lblTarih.Text = date.ToShortDateString();

            ListViewEdit(lsvKahvalti);
            ListViewEdit(lsvOgle);
            ListViewEdit(lsvAksam);
            ListViewEdit(lsvAperatif);

        }

        #region Öğünlerin Açılıp Kapanması
        private void btnKahvalti_Click(object sender, EventArgs e)
        {
            pnlKahveLsv.Visible = !kahvaltiAcikMi;
            kahvaltiAcikMi = !kahvaltiAcikMi;
        }

        private void btnOgleYemegi_Click(object sender, EventArgs e)
        {
            pnlOgleLsv.Visible = !ogleAcikMi;
            ogleAcikMi = !ogleAcikMi;
        }

        private void btnAksamYmegi_Click(object sender, EventArgs e)
        {
            pnlAksamLsv.Visible = !aksamAcikMi;
            aksamAcikMi = !aksamAcikMi;
        }

        private void btnAperatif_Click(object sender, EventArgs e)
        {
            pnlAperatifLsv.Visible = !aperatifAcikMi;
            aperatifAcikMi = !aperatifAcikMi;
        }
        #endregion

        private void ListViewEdit(ListView lsv)
        {
            lsv.View = View.Details;
            lsv.GridLines = true;
            lsv.FullRowSelect = true;

            ColumnHeader[] headers =
            {
                new ColumnHeader() { Name = "Food", Text = "Yemek", Width = lsv.Width-500, TextAlign = HorizontalAlignment.Left},
                new ColumnHeader() { Name = "Portion", Text = "Posiyon Miktarı", Width = 100, TextAlign = HorizontalAlignment.Center},
                new ColumnHeader() { Name = "Calorie", Text = "Kalori", Width = 100, TextAlign = HorizontalAlignment.Center},
                new ColumnHeader() { Name = "Carb", Text = "Karbonhidrat", Width = 100, TextAlign = HorizontalAlignment.Center},
                new ColumnHeader() { Name = "Protein", Text = "Protein", Width = 100, TextAlign = HorizontalAlignment.Center},
                new ColumnHeader() { Name = "Fat", Text = "Yağ", Width = 100, TextAlign = HorizontalAlignment.Center}
            };

            lsv.Columns.AddRange(headers);

        }

        private void TsmClick(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmItem = (ToolStripMenuItem)sender;
            string tsmName = tsmItem.Name;

            if (tsmName == "tsmUpdate")
            {
                if (lsvKahvalti.ClientRectangle.Contains(Cursor.Position))
                    TsmUpdateClicked(lsvKahvalti);
                else if (lsvOgle.ClientRectangle.Contains(Cursor.Position))
                    TsmUpdateClicked(lsvOgle);
                else if (lsvAksam.ClientRectangle.Contains(Cursor.Position))
                    TsmUpdateClicked(lsvAksam);
                else if (lsvAperatif.ClientRectangle.Contains(Cursor.Position))
                    TsmUpdateClicked(lsvAperatif);
            }
            else if (tsmName == "tsmDelete")
            {
                if (lsvKahvalti.ClientRectangle.Contains(Cursor.Position))
                    TsmDeleteClicked(lsvKahvalti);
                else if (lsvOgle.ClientRectangle.Contains(Cursor.Position))
                    TsmDeleteClicked(lsvOgle);
                else if (lsvAksam.ClientRectangle.Contains(Cursor.Position))
                    TsmDeleteClicked(lsvAksam);
                else if (lsvAperatif.ClientRectangle.Contains(Cursor.Position))
                    TsmDeleteClicked(lsvAperatif);
            }
        }

        private void TsmDeleteClicked(ListView lsv)
        {

            if (lsv.SelectedItems.Count <= 0) return;

            DialogResult dialogResult = MessageBox.Show("Yemeği öğünden kaldırmak istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;

            //TODO : Yemeği öğünden sil

        }

        private void TsmUpdateClicked(ListView lsv)
        {
            int count = lsv.SelectedItems.Count;

            if (count <= 0) return;

            //TODO : Yemeği güncelle
        }

        private void lsv_MouseClick(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;

            switch (listView.Name)
            {
                case "lsvKahvalti": LsvTiklandi(lsvKahvalti, e); break;
                case "lsvOgle": LsvTiklandi(lsvOgle, e); break;
                case "lsvAksam": LsvTiklandi(lsvAksam, e); break;
                case "lsvAperatif": LsvTiklandi(lsvAperatif, e); break;
            }
        }

        private void LsvTiklandi(ListView lsv, MouseEventArgs e)
        {
            MouseButtons button = e.Button;
            if (button != MouseButtons.Right) return;

            ListViewItem lvi = lsv.FocusedItem;
            bool isBound = lvi.Bounds.Contains(e.Location);

            if (lvi == null || !isBound) return;

            cmsSagTik.Show(Cursor.Position);
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Button btnAdd = sender as Button;
            switch (btnAdd.Name)
            {
                //case "btnAddKahvalti": OpenFormYemekEkleme(); break; //TODO: metod içine ilgili öğünü ekle
                //case "btnAddOgle": OpenFormYemekEkleme(); break; //TODO: metod içine ilgili öğünü ekle
                //case "btnAddAksam": OpenFormYemekEkleme(); break; //TODO: metod içine ilgili öğünü ekle
                //case "btnAddAperatif": OpenFormYemekEkleme(); break; //TODO: metod içine ilgili öğünü ekle

            }
        }

        private void OpenFormYemekEkleme(Meal meal)
        {
            //TODO: meal'a yemek 
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            date = date.AddDays(1);
            lblTarih.Text = date.ToShortDateString();

            //TODO: Sorgular
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            date = date.AddDays(-1);
            lblTarih.Text = date.ToShortDateString();

            //TODO: Sorgular
        }
    }
}
