namespace GetBalance.UI
{
    partial class FormGunlukKaloriIhtiyaci
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
            rdbKadin = new RadioButton();
            rdbErkek = new RadioButton();
            label6 = new Label();
            txtYas = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lblGKIDeger = new Label();
            label4 = new Label();
            btnHesapla = new Button();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            cmbxAktiviteSeviyesi = new ComboBox();
            btnGeri = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(202, 419);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 33;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(101, 419);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 32;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(92, 385);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 31;
            label6.Text = "Cinsiyetiniz";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(92, 270);
            txtYas.Multiline = true;
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(234, 32);
            txtYas.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(92, 237);
            label5.Name = "label5";
            label5.Size = new Size(33, 21);
            label5.TabIndex = 29;
            label5.Text = "Yaş";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblGKIDeger);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(389, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 100);
            panel1.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(162, 55);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 3;
            label7.Text = "Kalori / Gün";
            // 
            // lblGKIDeger
            // 
            lblGKIDeger.AutoSize = true;
            lblGKIDeger.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGKIDeger.Location = new Point(93, 55);
            lblGKIDeger.Name = "lblGKIDeger";
            lblGKIDeger.Size = new Size(19, 21);
            lblGKIDeger.TabIndex = 2;
            lblGKIDeger.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 10);
            label4.Name = "label4";
            label4.Size = new Size(239, 25);
            label4.TabIndex = 1;
            label4.Text = "GÜNLÜK KALORİ İHTİYACI";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(2, 53, 53);
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(92, 467);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(234, 49);
            btnHesapla.TabIndex = 26;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(92, 196);
            txtKilo.Multiline = true;
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(234, 32);
            txtKilo.TabIndex = 25;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(92, 119);
            txtBoy.Multiline = true;
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(234, 32);
            txtBoy.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(92, 160);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 23;
            label3.Text = "Kilonuz (kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(92, 86);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 22;
            label2.Text = "Boyunuz (cm)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 38);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 21;
            label1.Text = "GÜNLÜK KALORİ İHTİYACI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(92, 309);
            label8.Name = "label8";
            label8.Size = new Size(128, 21);
            label8.TabIndex = 34;
            label8.Text = "Aktivite Seviyesi";
            // 
            // cmbxAktiviteSeviyesi
            // 
            cmbxAktiviteSeviyesi.FormattingEnabled = true;
            cmbxAktiviteSeviyesi.Location = new Point(92, 345);
            cmbxAktiviteSeviyesi.Name = "cmbxAktiviteSeviyesi";
            cmbxAktiviteSeviyesi.Size = new Size(234, 23);
            cmbxAktiviteSeviyesi.TabIndex = 35;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(2, 53, 53);
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = Color.White;
            btnGeri.Location = new Point(408, 467);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(234, 49);
            btnGeri.TabIndex = 36;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // FormGunlukKaloriIhtiyaci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 607);
            Controls.Add(btnGeri);
            Controls.Add(cmbxAktiviteSeviyesi);
            Controls.Add(label8);
            Controls.Add(rdbKadin);
            Controls.Add(rdbErkek);
            Controls.Add(label6);
            Controls.Add(txtYas);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btnHesapla);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGunlukKaloriIhtiyaci";
            Text = "FormGunlukKaloriIhtiyaci";
            Load += FormGunlukKaloriIhtiyaci_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private Label label6;
        private TextBox txtYas;
        private Label label5;
        private Panel panel1;
        private Label label7;
        private Label lblGKIDeger;
        private Label label4;
        private Button btnHesapla;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private ComboBox cmbxAktiviteSeviyesi;
        private System.CodeDom.CodeTypeReference gunlukControl1;
        private System.CodeDom.CodeTypeReference gunlukControl2;
        private Button btnGeri;
    }
}