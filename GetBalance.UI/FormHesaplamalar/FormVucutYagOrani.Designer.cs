namespace GetBalance.UI
{
    partial class FormVucutYagOrani
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
            txtKalcaCevresi = new TextBox();
            label8 = new Label();
            rdbKadin = new RadioButton();
            rdbErkek = new RadioButton();
            label6 = new Label();
            txtBelCevresi = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            lblYorum = new Label();
            lblVYODeger = new Label();
            label4 = new Label();
            cpbYVK = new ReaLTaiizor.Controls.CircleProgressBar();
            btnHesapla = new Button();
            txtBoyunCevresi = new TextBox();
            txtBoy = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGeri = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtKalcaCevresi
            // 
            txtKalcaCevresi.Location = new Point(85, 347);
            txtKalcaCevresi.Multiline = true;
            txtKalcaCevresi.Name = "txtKalcaCevresi";
            txtKalcaCevresi.Size = new Size(234, 32);
            txtKalcaCevresi.TabIndex = 65;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(85, 314);
            label8.Name = "label8";
            label8.Size = new Size(141, 21);
            label8.TabIndex = 64;
            label8.Text = "Kalça Çevresi (cm)";
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(195, 426);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 63;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(94, 426);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 62;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(85, 394);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 61;
            label6.Text = "Cinsiyetiniz";
            // 
            // txtBelCevresi
            // 
            txtBelCevresi.Location = new Point(85, 276);
            txtBelCevresi.Multiline = true;
            txtBelCevresi.Name = "txtBelCevresi";
            txtBelCevresi.Size = new Size(234, 32);
            txtBelCevresi.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(85, 243);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 59;
            label5.Text = "Bel Çevresi (cm)";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblYorum);
            panel1.Controls.Add(lblVYODeger);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(403, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 146);
            panel1.TabIndex = 58;
            // 
            // lblYorum
            // 
            lblYorum.AutoSize = true;
            lblYorum.Location = new Point(127, 100);
            lblYorum.Name = "lblYorum";
            lblYorum.Size = new Size(0, 15);
            lblYorum.TabIndex = 66;
            // 
            // lblVYODeger
            // 
            lblVYODeger.AutoSize = true;
            lblVYODeger.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVYODeger.Location = new Point(127, 55);
            lblVYODeger.Name = "lblVYODeger";
            lblVYODeger.Size = new Size(19, 21);
            lblVYODeger.TabIndex = 2;
            lblVYODeger.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(77, 11);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 1;
            label4.Text = "VÜCUT YAĞ ORANI";
            // 
            // cpbYVK
            // 
            cpbYVK.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cpbYVK.Location = new Point(496, 145);
            cpbYVK.Maximum = 100L;
            cpbYVK.MinimumSize = new Size(100, 100);
            cpbYVK.Name = "cpbYVK";
            cpbYVK.PercentColor = Color.Cyan;
            cpbYVK.ProgressColor1 = Color.White;
            cpbYVK.ProgressColor2 = Color.Red;
            cpbYVK.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            cpbYVK.Size = new Size(130, 130);
            cpbYVK.TabIndex = 57;
            cpbYVK.Text = "circleProgressBar1";
            cpbYVK.Value = 0L;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(2, 53, 53);
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(85, 474);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(234, 49);
            btnHesapla.TabIndex = 56;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtBoyunCevresi
            // 
            txtBoyunCevresi.Location = new Point(85, 202);
            txtBoyunCevresi.Multiline = true;
            txtBoyunCevresi.Name = "txtBoyunCevresi";
            txtBoyunCevresi.Size = new Size(234, 32);
            txtBoyunCevresi.TabIndex = 55;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(85, 125);
            txtBoy.Multiline = true;
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(234, 32);
            txtBoy.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 166);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 53;
            label3.Text = "Boyun Çevresi (cm)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 92);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 52;
            label2.Text = "Boyunuz (cm)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 44);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 51;
            label1.Text = "VÜCUT YAĞ ORANI";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(2, 53, 53);
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = Color.White;
            btnGeri.Location = new Point(403, 474);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(234, 49);
            btnGeri.TabIndex = 56;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // FormVucutYagOrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 568);
            Controls.Add(txtKalcaCevresi);
            Controls.Add(label8);
            Controls.Add(rdbKadin);
            Controls.Add(rdbErkek);
            Controls.Add(label6);
            Controls.Add(txtBelCevresi);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(cpbYVK);
            Controls.Add(btnGeri);
            Controls.Add(btnHesapla);
            Controls.Add(txtBoyunCevresi);
            Controls.Add(txtBoy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVucutYagOrani";
            Text = "FormVucutYagOrani";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKalcaCevresi;
        private Label label8;
        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private Label label6;
        private TextBox txtBelCevresi;
        private Label label5;
        private Panel panel1;
        private Label lblVYODeger;
        private Label label4;
        private ReaLTaiizor.Controls.CircleProgressBar cpbYVK;
        private Button btnHesapla;
        private TextBox txtBoyunCevresi;
        private TextBox txtBoy;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGeri;
        private Label lblYorum;
    }
}