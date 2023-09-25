namespace GetBalance.UI
{
    partial class UserKayitEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserKayitEkrani));
            dtpBirthdate = new DateTimePicker();
            txtName = new TextBox();
            txtLastname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            radioBtnMan = new RadioButton();
            radioBtnWoman = new RadioButton();
            label5 = new Label();
            txtHeight = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtWeight = new TextBox();
            label8 = new Label();
            txtPassword = new TextBox();
            btnAdd = new Button();
            label9 = new Label();
            cmbActivityLevel = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(127, 339);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(200, 23);
            dtpBirthdate.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(127, 90);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(100, 23);
            txtLastname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 49);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 98);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 347);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 142);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            // 
            // radioBtnMan
            // 
            radioBtnMan.AutoSize = true;
            radioBtnMan.Location = new Point(127, 224);
            radioBtnMan.Name = "radioBtnMan";
            radioBtnMan.Size = new Size(53, 19);
            radioBtnMan.TabIndex = 5;
            radioBtnMan.TabStop = true;
            radioBtnMan.Text = "Erkek";
            radioBtnMan.UseVisualStyleBackColor = true;
            // 
            // radioBtnWoman
            // 
            radioBtnWoman.AutoSize = true;
            radioBtnWoman.Location = new Point(195, 224);
            radioBtnWoman.Name = "radioBtnWoman";
            radioBtnWoman.Size = new Size(55, 19);
            radioBtnWoman.TabIndex = 6;
            radioBtnWoman.TabStop = true;
            radioBtnWoman.Text = "Kadın";
            radioBtnWoman.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 228);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 3;
            label5.Text = "Cinsiyet:";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(127, 253);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 300);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 3;
            label6.Text = "Kilo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 261);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 3;
            label7.Text = "Boy:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(127, 297);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 186);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 3;
            label8.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(393, 271);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 44);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "KAYIT OL";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(384, 44);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 3;
            label9.Text = "Aktivite Derecesi:";
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(495, 36);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(121, 23);
            cmbActivityLevel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // UserKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(cmbActivityLevel);
            Controls.Add(btnAdd);
            Controls.Add(txtPassword);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(radioBtnWoman);
            Controls.Add(radioBtnMan);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(txtLastname);
            Controls.Add(txtName);
            Controls.Add(dtpBirthdate);
            Name = "UserKayitEkrani";
            Text = "UserKayitEkrani";
            Load += UserKayitEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBirthdate;
        private TextBox txtName;
        private TextBox txtLastname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private RadioButton radioBtnMan;
        private RadioButton radioBtnWoman;
        private Label label5;
        private TextBox txtHeight;
        private Label label6;
        private Label label7;
        private TextBox txtWeight;
        private Label label8;
        private TextBox txtPassword;
        private Button btnAdd;
        private Label label9;
        private ComboBox cmbActivityLevel;
        private PictureBox pictureBox1;
    }
}