using GetBalance.DAL;
using GetBalance.DAL.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GetBalance.UI
{
    public partial class Form1 : Form
    {
        GenericRepository<User> userRepo;
        AppDbContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            //List<User> usersList = userRepo.GetAll();

            
            var userConfirmation = context.Users.FirstOrDefault(u => u.Email == username && u.Password == password);
            //usersList.FirstOrDefault(u => u.Email == username && u.Password == password); //TODO: tekrar bakýlacak.

            if (userConfirmation != null)
            {
                UserKayitEkrani userKayitAlmaFormu = new UserKayitEkrani();
                userKayitAlmaFormu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Parola Yanlýþ");
                txtUserName.Text = txtPassword.Text = "";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            context = new AppDbContext();
            userRepo = new GenericRepository<User>();
        }
    }
}