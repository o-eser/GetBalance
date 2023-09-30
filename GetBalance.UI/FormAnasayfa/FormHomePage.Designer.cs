namespace GetBalance.UI
{
    partial class FormHomePage
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
            components = new System.ComponentModel.Container();
            pnlTop = new Panel();
            label2 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHome = new PictureBox();
            menuContainer = new FlowLayoutPanel();
            pnlMenu = new Panel();
            pnlAnaSayfa = new Panel();
            btnAnaSayfa = new Button();
            pnlProfil = new Panel();
            btnProfil = new Button();
            pnlGunluk = new Panel();
            btnGunluk = new Button();
            pnlRaporlar = new Panel();
            btnRaporlar = new Button();
            pnlHesaplamalar = new Panel();
            btnHesaplamalar = new Button();
            pnlCikis = new Panel();
            btnCikis = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            pnlAnaPanel = new Panel();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            menuContainer.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlAnaSayfa.SuspendLayout();
            pnlProfil.SuspendLayout();
            pnlGunluk.SuspendLayout();
            pnlRaporlar.SuspendLayout();
            pnlHesaplamalar.SuspendLayout();
            pnlCikis.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(2, 53, 53);
            pnlTop.Controls.Add(label2);
            pnlTop.Controls.Add(nightControlBox1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1280, 35);
            pnlTop.TabIndex = 0;
            pnlTop.MouseDown += pnlTop_MouseDown;
            pnlTop.MouseMove += pnlTop_MouseMove;
            pnlTop.MouseUp += pnlTop_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(583, 6);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 3;
            label2.Text = "H E A L T H Y  D I E T";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.Dock = DockStyle.Right;
            nightControlBox1.EnableCloseColor = Color.White;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.White;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.White;
            nightControlBox1.Location = new Point(1141, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 2;
            label1.Text = "MENU";
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Image = Properties.Resources.menu_4_32;
            btnHome.Location = new Point(9, 20);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(30, 30);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(2, 53, 53);
            menuContainer.Controls.Add(pnlMenu);
            menuContainer.Controls.Add(pnlAnaSayfa);
            menuContainer.Controls.Add(pnlProfil);
            menuContainer.Controls.Add(pnlGunluk);
            menuContainer.Controls.Add(pnlRaporlar);
            menuContainer.Controls.Add(pnlHesaplamalar);
            menuContainer.Controls.Add(pnlCikis);
            menuContainer.Dock = DockStyle.Left;
            menuContainer.Location = new Point(0, 35);
            menuContainer.MaximumSize = new Size(205, 685);
            menuContainer.MinimumSize = new Size(58, 685);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(205, 685);
            menuContainer.TabIndex = 1;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Location = new Point(3, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(202, 71);
            pnlMenu.TabIndex = 0;
            // 
            // pnlAnaSayfa
            // 
            pnlAnaSayfa.Controls.Add(btnAnaSayfa);
            pnlAnaSayfa.Location = new Point(3, 80);
            pnlAnaSayfa.Name = "pnlAnaSayfa";
            pnlAnaSayfa.Size = new Size(173, 40);
            pnlAnaSayfa.TabIndex = 1;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackColor = Color.FromArgb(2, 53, 53);
            btnAnaSayfa.FlatAppearance.BorderSize = 0;
            btnAnaSayfa.FlatStyle = FlatStyle.Flat;
            btnAnaSayfa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnaSayfa.ForeColor = Color.White;
            btnAnaSayfa.Image = Properties.Resources.home_7_32;
            btnAnaSayfa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnaSayfa.Location = new Point(-13, -9);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Padding = new Padding(15, 0, 0, 0);
            btnAnaSayfa.Size = new Size(233, 58);
            btnAnaSayfa.TabIndex = 0;
            btnAnaSayfa.Text = "            Ana Sayfa";
            btnAnaSayfa.TextAlign = ContentAlignment.MiddleLeft;
            btnAnaSayfa.UseVisualStyleBackColor = false;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // pnlProfil
            // 
            pnlProfil.Controls.Add(btnProfil);
            pnlProfil.Location = new Point(3, 126);
            pnlProfil.Name = "pnlProfil";
            pnlProfil.Size = new Size(173, 40);
            pnlProfil.TabIndex = 1;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.FromArgb(2, 53, 53);
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfil.ForeColor = Color.White;
            btnProfil.Image = Properties.Resources.user_32;
            btnProfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfil.Location = new Point(-13, -9);
            btnProfil.Name = "btnProfil";
            btnProfil.Padding = new Padding(15, 0, 0, 0);
            btnProfil.Size = new Size(233, 58);
            btnProfil.TabIndex = 0;
            btnProfil.Text = "            Profil";
            btnProfil.TextAlign = ContentAlignment.MiddleLeft;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // pnlGunluk
            // 
            pnlGunluk.Controls.Add(btnGunluk);
            pnlGunluk.Location = new Point(3, 172);
            pnlGunluk.Name = "pnlGunluk";
            pnlGunluk.Size = new Size(173, 40);
            pnlGunluk.TabIndex = 1;
            // 
            // btnGunluk
            // 
            btnGunluk.BackColor = Color.FromArgb(2, 53, 53);
            btnGunluk.FlatAppearance.BorderSize = 0;
            btnGunluk.FlatStyle = FlatStyle.Flat;
            btnGunluk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGunluk.ForeColor = Color.White;
            btnGunluk.Image = Properties.Resources.today_32;
            btnGunluk.ImageAlign = ContentAlignment.MiddleLeft;
            btnGunluk.Location = new Point(-13, -9);
            btnGunluk.Name = "btnGunluk";
            btnGunluk.Padding = new Padding(15, 0, 0, 0);
            btnGunluk.Size = new Size(233, 58);
            btnGunluk.TabIndex = 0;
            btnGunluk.Text = "            Günlük";
            btnGunluk.TextAlign = ContentAlignment.MiddleLeft;
            btnGunluk.UseVisualStyleBackColor = false;
            btnGunluk.Click += btnGunluk_Click;
            // 
            // pnlRaporlar
            // 
            pnlRaporlar.Controls.Add(btnRaporlar);
            pnlRaporlar.Location = new Point(3, 218);
            pnlRaporlar.Name = "pnlRaporlar";
            pnlRaporlar.Size = new Size(173, 40);
            pnlRaporlar.TabIndex = 1;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.FromArgb(2, 53, 53);
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporlar.ForeColor = Color.White;
            btnRaporlar.Image = Properties.Resources.report_3_32;
            btnRaporlar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRaporlar.Location = new Point(-13, -9);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Padding = new Padding(15, 0, 0, 0);
            btnRaporlar.Size = new Size(233, 58);
            btnRaporlar.TabIndex = 0;
            btnRaporlar.Text = "            Raporlar";
            btnRaporlar.TextAlign = ContentAlignment.MiddleLeft;
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // pnlHesaplamalar
            // 
            pnlHesaplamalar.Controls.Add(btnHesaplamalar);
            pnlHesaplamalar.Location = new Point(3, 264);
            pnlHesaplamalar.Name = "pnlHesaplamalar";
            pnlHesaplamalar.Size = new Size(173, 40);
            pnlHesaplamalar.TabIndex = 1;
            // 
            // btnHesaplamalar
            // 
            btnHesaplamalar.BackColor = Color.FromArgb(2, 53, 53);
            btnHesaplamalar.FlatAppearance.BorderSize = 0;
            btnHesaplamalar.FlatStyle = FlatStyle.Flat;
            btnHesaplamalar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesaplamalar.ForeColor = Color.White;
            btnHesaplamalar.Image = Properties.Resources.calculator_7_32;
            btnHesaplamalar.ImageAlign = ContentAlignment.MiddleLeft;
            btnHesaplamalar.Location = new Point(-13, -9);
            btnHesaplamalar.Name = "btnHesaplamalar";
            btnHesaplamalar.Padding = new Padding(15, 0, 0, 0);
            btnHesaplamalar.Size = new Size(233, 58);
            btnHesaplamalar.TabIndex = 0;
            btnHesaplamalar.Text = "            Hesaplamalar";
            btnHesaplamalar.TextAlign = ContentAlignment.MiddleLeft;
            btnHesaplamalar.UseVisualStyleBackColor = false;
            btnHesaplamalar.Click += btnHesaplamalar_Click;
            // 
            // pnlCikis
            // 
            pnlCikis.Controls.Add(btnCikis);
            pnlCikis.Location = new Point(3, 310);
            pnlCikis.Name = "pnlCikis";
            pnlCikis.Size = new Size(173, 40);
            pnlCikis.TabIndex = 1;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(2, 53, 53);
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.Image = Properties.Resources.exit_32;
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.Location = new Point(-13, -9);
            btnCikis.Name = "btnCikis";
            btnCikis.Padding = new Padding(15, 0, 0, 0);
            btnCikis.Size = new Size(233, 58);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "            Çıkış";
            btnCikis.TextAlign = ContentAlignment.MiddleLeft;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // pnlAnaPanel
            // 
            pnlAnaPanel.AutoSize = true;
            pnlAnaPanel.Dock = DockStyle.Fill;
            pnlAnaPanel.Location = new Point(205, 35);
            pnlAnaPanel.Name = "pnlAnaPanel";
            pnlAnaPanel.Size = new Size(1075, 625);
            pnlAnaPanel.TabIndex = 2;
            // 
            // FormHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 660);
            ControlBox = false;
            Controls.Add(pnlAnaPanel);
            Controls.Add(menuContainer);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1280, 720);
            Name = "FormHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormHomePage_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            menuContainer.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlAnaSayfa.ResumeLayout(false);
            pnlProfil.ResumeLayout(false);
            pnlGunluk.ResumeLayout(false);
            pnlRaporlar.ResumeLayout(false);
            pnlHesaplamalar.ResumeLayout(false);
            pnlCikis.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private PictureBox btnHome;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel menuContainer;
        private Button btnAnaSayfa;
        private System.Windows.Forms.Timer menuTransition;
        private Panel pnlMenu;
        private Panel pnlAnaSayfa;
        private Panel pnlProfil;
        private Button btnProfil;
        private Panel pnlGunluk;
        private Button btnGunluk;
        private Panel pnlRaporlar;
        private Button btnRaporlar;
        private Panel pnlCikis;
        private Button btnCikis;
        private Panel pnlAnaPanel;
        private Label label2;
        private Panel pnlHesaplamalar;
        private Button btnHesaplamalar;
    }
}