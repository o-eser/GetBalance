namespace GetBalance.UI
{
    partial class FormHesaplamalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHesaplamalar));
            btnVKE = new Button();
            btnBMH = new Button();
            pnlSide = new Panel();
            btnMKAH = new Button();
            btnGSI = new Button();
            btnIdealKilo = new Button();
            btnVYO = new Button();
            btnGKİ = new Button();
            pnlHesaplamalar = new Panel();
            pnlSide.SuspendLayout();
            SuspendLayout();
            // 
            // btnVKE
            // 
            btnVKE.BackColor = Color.FromArgb(15, 194, 192);
            btnVKE.FlatAppearance.BorderSize = 0;
            btnVKE.FlatStyle = FlatStyle.Flat;
            btnVKE.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVKE.ForeColor = Color.White;
            btnVKE.Image = (Image)resources.GetObject("btnVKE.Image");
            btnVKE.ImageAlign = ContentAlignment.MiddleLeft;
            btnVKE.Location = new Point(0, 33);
            btnVKE.Name = "btnVKE";
            btnVKE.Size = new Size(230, 41);
            btnVKE.TabIndex = 0;
            btnVKE.Tag = "VKI";
            btnVKE.Text = "        Vücut Kitle Endeksi ( BMI)";
            btnVKE.UseVisualStyleBackColor = false;
            btnVKE.Click += btnClick;
            // 
            // btnBMH
            // 
            btnBMH.BackColor = Color.FromArgb(15, 194, 192);
            btnBMH.FlatStyle = FlatStyle.Flat;
            btnBMH.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBMH.ForeColor = Color.White;
            btnBMH.Image = (Image)resources.GetObject("btnBMH.Image");
            btnBMH.ImageAlign = ContentAlignment.MiddleLeft;
            btnBMH.Location = new Point(0, 116);
            btnBMH.Name = "btnBMH";
            btnBMH.Size = new Size(230, 41);
            btnBMH.TabIndex = 1;
            btnBMH.Tag = "BMR";
            btnBMH.Text = "      Bazal Metaboliz Hızı (BMR)";
            btnBMH.UseVisualStyleBackColor = false;
            btnBMH.Click += btnClick;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(244, 240, 232);
            pnlSide.Controls.Add(btnMKAH);
            pnlSide.Controls.Add(btnVKE);
            pnlSide.Controls.Add(btnGSI);
            pnlSide.Controls.Add(btnBMH);
            pnlSide.Controls.Add(btnIdealKilo);
            pnlSide.Controls.Add(btnVYO);
            pnlSide.Controls.Add(btnGKİ);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(232, 607);
            pnlSide.TabIndex = 8;
            // 
            // btnMKAH
            // 
            btnMKAH.BackColor = Color.FromArgb(15, 194, 192);
            btnMKAH.FlatAppearance.BorderSize = 0;
            btnMKAH.FlatStyle = FlatStyle.Flat;
            btnMKAH.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMKAH.ForeColor = Color.White;
            btnMKAH.Image = (Image)resources.GetObject("btnMKAH.Image");
            btnMKAH.ImageAlign = ContentAlignment.MiddleLeft;
            btnMKAH.Location = new Point(0, 533);
            btnMKAH.Name = "btnMKAH";
            btnMKAH.Size = new Size(230, 41);
            btnMKAH.TabIndex = 14;
            btnMKAH.Tag = "MaksimumKalpHızı";
            btnMKAH.Text = "        Maksimum Kalp Hızı";
            btnMKAH.UseVisualStyleBackColor = false;
            btnMKAH.Click += btnClick;
            // 
            // btnGSI
            // 
            btnGSI.BackColor = Color.FromArgb(15, 194, 192);
            btnGSI.FlatAppearance.BorderSize = 0;
            btnGSI.FlatStyle = FlatStyle.Flat;
            btnGSI.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGSI.ForeColor = Color.White;
            btnGSI.Image = (Image)resources.GetObject("btnGSI.Image");
            btnGSI.ImageAlign = ContentAlignment.MiddleLeft;
            btnGSI.Location = new Point(0, 452);
            btnGSI.Name = "btnGSI";
            btnGSI.Size = new Size(230, 41);
            btnGSI.TabIndex = 13;
            btnGSI.Tag = "GünlükSuİhtiyacı";
            btnGSI.Text = "        Günlük Su İhtiyacı";
            btnGSI.UseVisualStyleBackColor = false;
            btnGSI.Click += btnClick;
            // 
            // btnIdealKilo
            // 
            btnIdealKilo.BackColor = Color.FromArgb(15, 194, 192);
            btnIdealKilo.FlatAppearance.BorderSize = 0;
            btnIdealKilo.FlatStyle = FlatStyle.Flat;
            btnIdealKilo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIdealKilo.ForeColor = Color.White;
            btnIdealKilo.Image = (Image)resources.GetObject("btnIdealKilo.Image");
            btnIdealKilo.ImageAlign = ContentAlignment.MiddleLeft;
            btnIdealKilo.Location = new Point(-1, 366);
            btnIdealKilo.Name = "btnIdealKilo";
            btnIdealKilo.Size = new Size(230, 41);
            btnIdealKilo.TabIndex = 12;
            btnIdealKilo.Tag = "İdealKilo";
            btnIdealKilo.Text = "        İdeal Kilo";
            btnIdealKilo.UseVisualStyleBackColor = false;
            btnIdealKilo.Click += btnClick;
            // 
            // btnVYO
            // 
            btnVYO.BackColor = Color.FromArgb(15, 194, 192);
            btnVYO.FlatAppearance.BorderSize = 0;
            btnVYO.FlatStyle = FlatStyle.Flat;
            btnVYO.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVYO.ForeColor = Color.White;
            btnVYO.Image = (Image)resources.GetObject("btnVYO.Image");
            btnVYO.ImageAlign = ContentAlignment.MiddleLeft;
            btnVYO.Location = new Point(-1, 199);
            btnVYO.Name = "btnVYO";
            btnVYO.Size = new Size(230, 41);
            btnVYO.TabIndex = 9;
            btnVYO.Tag = "VücutYağOranı";
            btnVYO.Text = "Vücut Yağ Oranı";
            btnVYO.UseVisualStyleBackColor = false;
            btnVYO.Click += btnClick;
            // 
            // btnGKİ
            // 
            btnGKİ.BackColor = Color.FromArgb(15, 194, 192);
            btnGKİ.FlatAppearance.BorderSize = 0;
            btnGKİ.FlatStyle = FlatStyle.Flat;
            btnGKİ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGKİ.ForeColor = Color.White;
            btnGKİ.Image = (Image)resources.GetObject("btnGKİ.Image");
            btnGKİ.ImageAlign = ContentAlignment.MiddleLeft;
            btnGKİ.Location = new Point(0, 283);
            btnGKİ.Name = "btnGKİ";
            btnGKİ.Size = new Size(230, 41);
            btnGKİ.TabIndex = 11;
            btnGKİ.Tag = "GünlükKaloriİhtiyacı";
            btnGKİ.Text = "        Günlük Kalori İhtiyacı";
            btnGKİ.UseVisualStyleBackColor = false;
            btnGKİ.Click += btnClick;
            // 
            // pnlHesaplamalar
            // 
            pnlHesaplamalar.Dock = DockStyle.Fill;
            pnlHesaplamalar.Location = new Point(232, 0);
            pnlHesaplamalar.Name = "pnlHesaplamalar";
            pnlHesaplamalar.Size = new Size(836, 607);
            pnlHesaplamalar.TabIndex = 9;
            // 
            // FormHesaplamalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 607);
            Controls.Add(pnlHesaplamalar);
            Controls.Add(pnlSide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHesaplamalar";
            Text = "FormHesaplamalar";
            Load += FormHesaplamalar_Load;
            pnlSide.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion



        private Button btnVKE;
        private Button btnBMH;
        private Panel pnlSide;
        private Button btnGSI;
        private Button btnIdealKilo;
        private Button btnVYO;
        private Button btnGKİ;
        private Button btnMKAH;
        private Panel pnlHesaplamalar;

    }
}