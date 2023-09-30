namespace GetBalance.UI
{
    partial class BazalMetabolizHiziForm
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
            panel1 = new Panel();
            label7 = new Label();
            lblBMHDeger = new Label();
            label4 = new Label();
            btnHesapla = new Button();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtYas = new TextBox();
            label5 = new Label();
            label6 = new Label();
            rdbErkek = new RadioButton();
            rdbKadin = new RadioButton();
            btnGeri = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblBMHDeger);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(441, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 100);
            panel1.TabIndex = 15;
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
            // lblBMHDeger
            // 
            lblBMHDeger.AutoSize = true;
            lblBMHDeger.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBMHDeger.Location = new Point(93, 55);
            lblBMHDeger.Name = "lblBMHDeger";
            lblBMHDeger.Size = new Size(19, 21);
            lblBMHDeger.TabIndex = 2;
            lblBMHDeger.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 10);
            label4.Name = "label4";
            label4.Size = new Size(306, 25);
            label4.TabIndex = 1;
            label4.Text = "BAZAL METABOLİZMA HIZI (BMR)";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(2, 53, 53);
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(123, 460);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(234, 49);
            btnHesapla.TabIndex = 13;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(123, 246);
            txtKilo.Multiline = true;
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(234, 32);
            txtKilo.TabIndex = 12;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(123, 169);
            txtBoy.Multiline = true;
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(234, 32);
            txtBoy.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(123, 210);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 10;
            label3.Text = "Kilonuz (kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 136);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 9;
            label2.Text = "Boyunuz (cm)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(197, 98);
            label1.Name = "label1";
            label1.Size = new Size(306, 25);
            label1.TabIndex = 8;
            label1.Text = "BAZAL METABOLİZMA HIZI (BMR)";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(123, 320);
            txtYas.Multiline = true;
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(234, 32);
            txtYas.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(123, 287);
            label5.Name = "label5";
            label5.Size = new Size(33, 21);
            label5.TabIndex = 16;
            label5.Text = "Yaş";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(123, 370);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 18;
            label6.Text = "Cinsiyetiniz";
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(132, 412);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 19;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(233, 412);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 20;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(2, 53, 53);
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = Color.White;
            btnGeri.Location = new Point(441, 460);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(234, 49);
            btnGeri.TabIndex = 13;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // BazalMetabolizHiziForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 568);
            Controls.Add(rdbKadin);
            Controls.Add(rdbErkek);
            Controls.Add(label6);
            Controls.Add(txtYas);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btnGeri);
            Controls.Add(btnHesapla);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BazalMetabolizHiziForm";
            Text = "BazalMetabolizHiziForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblBMHDeger;
        private Label label4;
        private Button btnHesapla;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtYas;
        private Label label5;
        private Label label6;
        private RadioButton rdbErkek;
        private RadioButton rdbKadin;
        private Label label7;
        private Button btnGeri;
    }
}