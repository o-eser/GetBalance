using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA.Entities;
using GetBalance.DATA.Enums;
using GetBalance.UI.Events;
using GetBalance.UI.Properties;
using GetBalance.UI.Queries;
using GetBalance.UI.Repositories;
using GetBalance.UI.Singeltons;
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
using static GetBalance.UI.Queries.DBQueries;

namespace GetBalance.UI
{
	//Todo : meal'i öğün ekleme sayfasında oluşturup ekleyeceğiz.daha sonra seçilen yemek öğünle foodmeal tablosuna eklenecek.
	public partial class FormGunluk : Form
	{
		UserManager userManager;

		FoodMealRepository _foodMeal;

		MonthCalendar monthCalendar;

		DBQueries dBQueries;


		bool kahvaltiAcikMi, ogleAcikMi, aksamAcikMi, aperatifAcikMi = false;
		Point pbAddButtonLoc = new Point(5, 5);
		Point tlpVerilerLoc = new Point(473, 3);

		DateTime date;

		public FormGunluk()
		{
			InitializeComponent();
			userManager = UserManager.Instance;

			monthCalendar = new MonthCalendar();

			_foodMeal = new FoodMealRepository();

			dBQueries = new DBQueries();


			pnlKahveLsv.Visible = pnlOgleLsv.Visible = pnlAksamLsv.Visible = pnlAperatifLsv.Visible = false;

			FormEventService.Instance.NewItemAdded += RefreshListView;
		}

		private void FormGunluk_Load(object sender, EventArgs e)
		{
			#region MonthCalendar
			monthCalendar.Visible = false;
			monthCalendar.Location = new Point(btnLeft.Width + lblTarih.Width / 2 - monthCalendar.Width / 2 - 20, 5);
			monthCalendar.MaxSelectionCount = 1;
			pnlMain.Controls.Add(monthCalendar);
			monthCalendar.DateSelected += MonthCalendar_DateSelected;
			#endregion

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

			RefreshListView();
		}

		private void MealTotal(ListView listView, out double tCalorie, out double tCarb, out double tProtein, out double tFat)
		{
			Meal meal = new Meal();



			foreach (ListViewItem item in listView.Items)
			{
				FoodMeal fm = (FoodMeal)item.Tag;
				meal.MealFoods.Add(fm);
			}
			tCalorie = Math.Round(meal.TotalCalories, 2);
			tCarb = Math.Round(meal.TotalCarbohydrate);
			tProtein = Math.Round(meal.TotalProtein);
			tFat = Math.Round(meal.TotalFat);
		}

		private void RefreshListView()
		{
			IList<LsvItem> filteredBreakteasts = dBQueries.ViewToGetMeals(MealType.Breakfast, userManager.CurrentUser.UserId, Convert.ToDateTime(lblTarih.Text));
			IList<LsvItem> filteredLunches = dBQueries.ViewToGetMeals(MealType.Lunch, userManager.CurrentUser.UserId, Convert.ToDateTime(lblTarih.Text));
			IList<LsvItem> filteredDinners = dBQueries.ViewToGetMeals(MealType.Dinner, userManager.CurrentUser.UserId, Convert.ToDateTime(lblTarih.Text));
			IList<LsvItem> filteredSnacks = dBQueries.ViewToGetMeals(MealType.Snack, userManager.CurrentUser.UserId, Convert.ToDateTime(lblTarih.Text));



			FillListViewWithFoods(lsvKahvalti, filteredBreakteasts);
			FillListViewWithFoods(lsvOgle, filteredLunches);
			FillListViewWithFoods(lsvAksam, filteredDinners);
			FillListViewWithFoods(lsvAperatif, filteredSnacks);

			MealTotal(lsvKahvalti, out double tCalorie, out double tCarb, out double tProtein, out double tFat);
			lblKahvaltiTopKalori.Text = tCalorie.ToString() + " Kcal";
			lblKahvaltiTopKarb.Text = tCarb.ToString() + " gr";
			lblKahvaltiTopProtein.Text = tProtein.ToString() + " gr";
			lblKahvaltiTopYag.Text = tFat.ToString() + " gr";

			MealTotal(lsvOgle, out tCalorie, out tCarb, out tProtein, out tFat);
			lblOgleTopKalori.Text = tCalorie.ToString() + " Kcal";
			lblOgleTopKarb.Text = tCarb.ToString() + " gr";
			lblOgleTopProtein.Text = tProtein.ToString() + " gr";
			lblOgleTopYag.Text = tFat.ToString() + " gr";

			MealTotal(lsvAksam, out tCalorie, out tCarb, out tProtein, out tFat);
			lblAksamTopKalori.Text = tCalorie.ToString() + " Kcal";
			lblAksamTopKarb.Text = tCarb.ToString() + " gr";
			lblAksamTopProtein.Text = tProtein.ToString() + " gr";
			lblAksamTopYag.Text = tFat.ToString() + " gr";

			MealTotal(lsvAperatif, out tCalorie, out tCarb, out tProtein, out tFat);
			lblAperatifTopKalori.Text = tCalorie.ToString() + " Kcal";
			lblAperatifTopKarb.Text = tCarb.ToString() + " gr";
			lblAperatifTopProtein.Text = tProtein.ToString() + " gr";
			lblAperatifTopYag.Text = tFat.ToString() + " gr";

			lblSuankiKalori.Text = (Convert.ToDouble(FormatText(lblKahvaltiTopKalori.Text)) + Convert.ToDouble(FormatText(lblOgleTopKalori.Text)) + Convert.ToDouble(FormatText(lblAksamTopKalori.Text)) + Convert.ToDouble(FormatText(lblAperatifTopKalori.Text))).ToString() + " Kcal";
			lblSuankiKarb.Text = (Convert.ToDouble(FormatText(lblKahvaltiTopKarb.Text)) + Convert.ToDouble(FormatText(lblOgleTopKarb.Text)) + Convert.ToDouble(FormatText(lblAksamTopKarb.Text)) + Convert.ToDouble(FormatText(lblAperatifTopKarb.Text))).ToString() + " gr";
			lblSuankiProtein.Text = (Convert.ToDouble(FormatText(lblKahvaltiTopProtein.Text)) + Convert.ToDouble(FormatText(lblOgleTopProtein.Text)) + Convert.ToDouble(FormatText(lblAksamTopProtein.Text)) + Convert.ToDouble(FormatText(lblAperatifTopProtein.Text))).ToString() + " gr";
			lblSuankiYag.Text = (Convert.ToDouble(FormatText(lblKahvaltiTopYag.Text)) + Convert.ToDouble(FormatText(lblOgleTopYag.Text)) + Convert.ToDouble(FormatText(lblAksamTopYag.Text)) + Convert.ToDouble(FormatText(lblAperatifTopYag.Text))).ToString() + " gr";



			if (userManager.CurrentUser.UserDetail.UserTarget != null)
			{
				double targetCalori = userManager.CurrentUser.UserDetail.UserTarget.TargetCalorie;
				lblHedefKalori.Text = Math.Round(targetCalori, 2).ToString() + " Kcal";

				double targetCarb = userManager.CurrentUser.UserDetail.UserTarget.TargetCarbPercentage;
				lblHedefKarb.Text = Math.Round(targetCarb * targetCalori / 400.00, 2).ToString() + " gr";

				double targetProtein = userManager.CurrentUser.UserDetail.UserTarget.TargetProteinPercentage;
				lblHedefProtein.Text = Math.Round(targetProtein * targetCalori / 400.00, 2).ToString() + " gr";

				double targetFat = userManager.CurrentUser.UserDetail.UserTarget.TargetFatPercentage;
				lblHedefYag.Text = Math.Round(targetFat * targetCalori / 900.00, 2).ToString() + " gr";

				parrotCircleProgressBar1.percentage = Convert.ToInt32((Convert.ToDouble(FormatText(lblSuankiKalori.Text)) / targetCalori) * 100);


				if (parrotCircleProgressBar1.percentage > 100)
				{
					parrotCircleProgressBar1.FilledColor = Color.FromArgb(192, 0, 0);
				}
				else if (parrotCircleProgressBar1.percentage > 75)
				{
					parrotCircleProgressBar1.FilledColor = Color.FromArgb(255, 192, 0);
				}
				else if (parrotCircleProgressBar1.percentage > 50)
				{
					parrotCircleProgressBar1.FilledColor = Color.FromArgb(255, 255, 0);
				}
				else if (parrotCircleProgressBar1.percentage > 25)
				{
					parrotCircleProgressBar1.FilledColor = Color.FromArgb(0, 192, 0);
				}
			}
			else
			{
				parrotCircleProgressBar1.FilledColor = Color.FromArgb(0, 163, 160);
				lblHedefKalori.Text = "0";
				lblHedefKarb.Text = "0";
				lblHedefProtein.Text = "0";
				lblHedefYag.Text = "0";
				parrotCircleProgressBar1.percentage = 0;

			}

		}

		string FormatText(string text)
		{
			string[] parts = text.Split(' ');
			if (parts.Length > 0)
			{
				return parts[0];
			}
			return text;
		}




		#region Öğünlerin Açılıp Kapanması
		void OgunListViewDuzenle(Panel panel, ref bool panelDurumu)
		{
			if (acikPaneller.Contains(panel))
			{
				acikPaneller.Remove(panel);
				panel.Visible = false;
				panelDurumu = false;
			}
			else
			{
				if (acikPaneller.Count >= 2)
				{
					acikPaneller[0].Visible = false;
					acikPaneller.RemoveAt(0);
				}

				acikPaneller.Add(panel);
				panel.Visible = true;
				panelDurumu = true;
			}
			RefreshListView();
		}

		private List<Panel> acikPaneller = new List<Panel>();

		private void btnKahvalti_Click(object sender, EventArgs e)
		{
			OgunListViewDuzenle(pnlKahveLsv, ref kahvaltiAcikMi);
		}

		private void btnOgleYemegi_Click(object sender, EventArgs e)
		{
			OgunListViewDuzenle(pnlOgleLsv, ref ogleAcikMi);
		}

		private void btnAksamYmegi_Click(object sender, EventArgs e)
		{
			OgunListViewDuzenle(pnlAksamLsv, ref aksamAcikMi);
		}

		private void btnAperatif_Click(object sender, EventArgs e)
		{
			OgunListViewDuzenle(pnlAperatifLsv, ref aperatifAcikMi);
		}
		#endregion

		private void FillListViewWithFoods(ListView listView, IList<LsvItem> lsvItem)
		{
			listView.Items.Clear();

			ImageList imageList = new ImageList();
			imageList.ImageSize = new Size(40, 40);

			foreach (var item in lsvItem)
			{
				Bitmap bmp = new Bitmap(Resources.foodicon);
				if (item.Food.Picture != null)
				{
					bmp = new Bitmap(item.Food.Picture);
				}

				imageList.Images.Add(item.Food.FoodId.ToString(), bmp);

				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = item.Name;
				listViewItem.ImageKey = item.Food.FoodId.ToString();
				listViewItem.SubItems.Add(item.Amount.ToString());
				listViewItem.SubItems.Add(item.TotalCalorie.ToString());
				listViewItem.SubItems.Add(item.TotalCarb.ToString());
				listViewItem.SubItems.Add(item.TotalProtein.ToString());
				listViewItem.SubItems.Add(item.TotalFat.ToString());

				listViewItem.Tag = item.FoodMeal;

				listView.Items.Add(listViewItem);
			}
			listView.SmallImageList = imageList;
		}

		private void ListViewEdit(ListView lsv)
		{
			lsv.View = View.Details;
			lsv.GridLines = true;
			lsv.FullRowSelect = true;

			ColumnHeader[] headers =
			{
				new ColumnHeader() { Name = "Food", Text = "Yemek", Width = lsv.Width-500, TextAlign = HorizontalAlignment.Left},
				new ColumnHeader() { Name = "Portion", Text = "Porsiyon Miktarı", Width = 100, TextAlign = HorizontalAlignment.Center},
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

			if (tsmName == "tsmDuzenle")
			{
				if (lsvKahvalti.SelectedItems.Count > 0)
					TsmUpdateClicked(lsvKahvalti);
				else if (lsvOgle.SelectedItems.Count > 0)
					TsmUpdateClicked(lsvOgle);
				else if (lsvAksam.SelectedItems.Count > 0)
					TsmUpdateClicked(lsvAksam);
				else if (lsvAperatif.SelectedItems.Count > 0)
					TsmUpdateClicked(lsvAperatif);
			}
			else if (tsmName == "tsmKaldir")
			{
				if (lsvKahvalti.SelectedItems.Count > 0)
					TsmDeleteClicked(lsvKahvalti);
				else if (lsvOgle.SelectedItems.Count > 0)
					TsmDeleteClicked(lsvOgle);
				else if (lsvAksam.SelectedItems.Count > 0)
					TsmDeleteClicked(lsvAksam);
				else if (lsvAperatif.SelectedItems.Count > 0)
					TsmDeleteClicked(lsvAperatif);
			}
		}

		private void TsmDeleteClicked(ListView lsv)
		{

			if (lsv.SelectedItems.Count <= 0) return;

			DialogResult dialogResult = MessageBox.Show("Yemeği öğünden kaldırmak istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult != DialogResult.Yes) return;

			FoodMeal foodMeal = (FoodMeal)lsv.SelectedItems[0].Tag;

			_foodMeal.Delete(foodMeal);

			RefreshListView();
		}

		private void TsmUpdateClicked(ListView lsv)
		{
			int count = lsv.SelectedItems.Count;

			if (count <= 0) return;


			FormAddFood formUpdateFood = new FormAddFood((FoodMeal)lsv.SelectedItems[0].Tag);
			formUpdateFood.Show();
		}

		#region ListViewAçılıpKapanması
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

		#endregion
		private void pbAdd_Clicked(object sender, EventArgs e)
		{

			PictureBox pbAdd = sender as PictureBox;
			switch (pbAdd.Name)
			{
				case "pbAddKahvalti": OpenFormYemekEkleme(MealType.Breakfast, Convert.ToDateTime(lblTarih.Text)); break;
				case "pbAddOgle": OpenFormYemekEkleme(MealType.Lunch, Convert.ToDateTime(lblTarih.Text)); break;
				case "pbAddAksam": OpenFormYemekEkleme(MealType.Dinner, Convert.ToDateTime(lblTarih.Text)); break;
				case "pbAddAperatif": OpenFormYemekEkleme(MealType.Snack, Convert.ToDateTime(lblTarih.Text)); break;

			}
		}

		private void OpenFormYemekEkleme(MealType mealtype, DateTime dateTime)
		{
			FormAddFood formAddFood = new FormAddFood(mealtype, dateTime);
			formAddFood.ShowDialog();
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			date = date.AddDays(1);
			lblTarih.Text = date.ToShortDateString();
			RefreshListView();
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			date = date.AddDays(-1);
			lblTarih.Text = date.ToShortDateString();
			RefreshListView();
		}

		private void lblTarih_DoubleClick(object sender, EventArgs e)
		{
			monthCalendar.Visible = true;
			monthCalendar.BringToFront();
		}

		private void MonthCalendar_DateSelected(object? sender, DateRangeEventArgs e)
		{
			date = monthCalendar.SelectionStart;
			lblTarih.Text = date.ToShortDateString();
			RefreshListView();
			monthCalendar.Visible = false;
		}
	}



}
