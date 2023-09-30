namespace GetBalance.UI
{
    partial class FormSuIhtiyaci
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
            label1 = new Label();
            txtKilo = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lblSuIhtiyaciDeger = new Label();
            label4 = new Label();
            btnHesapla = new Button();
            btnGeri = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 88);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 9;
            label1.Text = "SU İHTİYACI";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(282, 198);
            txtKilo.Multiline = true;
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(234, 32);
            txtKilo.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(282, 162);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 13;
            label3.Text = "Kilonuz (kg)";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblSuIhtiyaciDeger);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(228, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 100);
            panel1.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(158, 59);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 4;
            label7.Text = "Litre";
            // 
            // lblSuIhtiyaciDeger
            // 
            lblSuIhtiyaciDeger.AutoSize = true;
            lblSuIhtiyaciDeger.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuIhtiyaciDeger.Location = new Point(124, 59);
            lblSuIhtiyaciDeger.Name = "lblSuIhtiyaciDeger";
            lblSuIhtiyaciDeger.Size = new Size(19, 21);
            lblSuIhtiyaciDeger.TabIndex = 2;
            lblSuIhtiyaciDeger.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(109, 12);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 1;
            label4.Text = "SU İHTİYACI";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(2, 53, 53);
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(282, 260);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(234, 49);
            btnHesapla.TabIndex = 60;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(2, 53, 53);
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = Color.White;
            btnGeri.Location = new Point(282, 481);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(234, 49);
            btnGeri.TabIndex = 60;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // FormSuIhtiyaci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 568);
            Controls.Add(btnGeri);
            Controls.Add(btnHesapla);
            Controls.Add(panel1);
            Controls.Add(txtKilo);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSuIhtiyaci";
            Text = "FormSuIhtiyaci";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKilo;
        private Label label3;
        private Panel panel1;
        private Label lblSuIhtiyaciDeger;
        private Label label4;
        private Button btnHesapla;
        private Label label7;
        private Button btnGeri;
    }
}