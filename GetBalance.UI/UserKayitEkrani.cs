using GetBalance.DAL.Repositories;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetBalance.UI
{
    public partial class UserKayitEkrani : Form
    {
        GenericRepository<User> userRepo;
        GenericRepository<UserDetail> userDetailRepo;
        public UserKayitEkrani()
        {
            InitializeComponent();
        }

        private void UserKayitEkrani_Load(object sender, EventArgs e)
        {
            userRepo = new GenericRepository<User>();
            userDetailRepo = new GenericRepository<UserDetail>();

            #region Adding Activities Enum to ComboBox

            cmbActivityLevel.DataSource = Enum.GetValues(typeof(ActivityLevel))
                .Cast<ActivityLevel>()
                .Select(value => new
                {
                    Value = value,
                    DisplayName = value.DisplayName()

                })
                .ToList();
            cmbActivityLevel.DisplayMember = "DisplayName";
            cmbActivityLevel.ValueMember = "Value";
            #endregion

            cmbActivityLevel.SelectedIndex = -1;


        }



        private void btnAdd_Click(object sender, EventArgs e)
        {


            AddUser();

        }

        private void AddUser()
        {
            List<User> usersList = userRepo.GetAll();

            string firstname = txtName.Text;
            string lastname = txtLastname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Gender gender = radioBtnMan.Checked ? Gender.Male : Gender.Female;
            double height = Convert.ToDouble(txtHeight.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            DateTime bday = dtpBirthdate.Value.Date;
            ActivityLevel activityLevel = (ActivityLevel)cmbActivityLevel.SelectedValue;

            User user = new User()
            {
                Email = email,
                Password = password,
                UserDetail = new UserDetail() { FirstName = firstname, LastName = lastname, Height = height, CurrentWeight = weight, BirthDate = bday, ActivityLevel = activityLevel, Gender = gender }

            };

            userRepo.Add(user);
            MessageBox.Show("Kullanıcı Başarıyla Eklenmiştir.");
            ClearFields();

        }

        private void ClearFields()
        {
            txtName.Text = txtLastname.Text = txtEmail.Text = txtPassword.Text = txtHeight.Text = txtWeight.Text = string.Empty;
            radioBtnMan.Enabled = radioBtnWoman.Enabled = false;
            dtpBirthdate.Value = DateTime.Now;
            cmbActivityLevel.SelectedIndex = -1;
        }
    }
}
