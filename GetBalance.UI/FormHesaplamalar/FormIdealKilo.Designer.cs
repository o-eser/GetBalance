namespace GetBalance.UI
{
    partial class FormIdealKilo
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
            lblIdealKiloDeger = new Label();
            label4 = new Label();
            cpbIdealKilo = new ReaLTaiizor.Controls.CircleProgressBar();
            btnHesapla = new Button();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rdbKadin = new RadioButton();
            rdbErkek = new RadioButton();
            label6 = new Label();
            btnGeri = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblIdealKiloDeger);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(418, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 124);
            panel1.TabIndex = 15;
            // 
            // lblIdealKiloDeger
            // 
            lblIdealKiloDeger.AutoSize = true;
            lblIdealKiloDeger.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdealKiloDeger.Location = new Point(116, 45);
            lblIdealKiloDeger.Name = "lblIdealKiloDeger";
            lblIdealKiloDeger.Size = new Size(19, 21);
            lblIdealKiloDeger.TabIndex = 2;
            lblIdealKiloDeger.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 9);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 1;
            label4.Text = "İDEAL KİLO";
            // 
            // cpbIdealKilo
            // 
            cpbIdealKilo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cpbIdealKilo.Location = new Point(490, 225);
            cpbIdealKilo.Maximum = 100L;
            cpbIdealKilo.MinimumSize = new Size(100, 100);
            cpbIdealKilo.Name = "cpbIdealKilo";
            cpbIdealKilo.PercentColor = Color.Cyan;
            cpbIdealKilo.ProgressColor1 = Color.White;
            cpbIdealKilo.ProgressColor2 = Color.Red;
            cpbIdealKilo.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            cpbIdealKilo.Size = new Size(130, 130);
            cpbIdealKilo.TabIndex = 14;
            cpbIdealKilo.Text = "circleProgressBar1";
            cpbIdealKilo.Value = 0L;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(2, 53, 53);
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(116, 456);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(234, 49);
            btnHesapla.TabIndex = 13;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(116, 320);
            txtKilo.Multiline = true;
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(234, 32);
            txtKilo.TabIndex = 12;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(116, 225);
            txtBoy.Multiline = true;
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(234, 32);
            txtBoy.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(116, 284);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 10;
            label3.Text = "Kilonuz (kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 192);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 9;
            label2.Text = "Boyunuz (cm)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 106);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 8;
            label1.Text = "İDEAL KİLO";
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(226, 406);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 51;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(125, 406);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 50;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(116, 374);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 49;
            label6.Text = "Cinsiyetiniz";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(2, 53, 53);
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = Color.White;
            btnGeri.Location = new Point(116, 533);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(234, 49);
            btnGeri.TabIndex = 13;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // FormIdealKilo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 607);
            Controls.Add(rdbKadin);
            Controls.Add(rdbErkek);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(cpbIdealKilo);
            Controls.Add(btnGeri);
            Controls.Add(btnHesapla);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIdealKilo";
            Text = "FormIdealKilo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblIdealKiloDeger;
        private Label label4;
        private ReaLTaiizor.Controls.CircleProgressBar cpbIdealKilo;
        private Button btnHesapla;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private Label label6;
        private Button btnGeri;
    }
}