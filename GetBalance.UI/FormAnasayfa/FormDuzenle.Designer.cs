namespace GetBalance.UI
{
    partial class FormDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuzenle));
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbxAktiviteSeviyesi = new ComboBox();
            txtKalcaCevresi = new TextBox();
            txtBelCevresi = new TextBox();
            txtBoyunCevresi = new TextBox();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            btnGuncelle = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(36, 262);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 27;
            label6.Text = "Aktivite Seviyesi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 219);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 26;
            label5.Text = "Kalça Çevresi (cm)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 176);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 25;
            label4.Text = "Bel Çevresi (cm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 137);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 24;
            label3.Text = "Boyun Çevresi (cm)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(92, 97);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 23;
            label2.Text = "Kilo (kg)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 55);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 22;
            label1.Text = "Boy (cm) ";
            // 
            // cbxAktiviteSeviyesi
            // 
            cbxAktiviteSeviyesi.FormattingEnabled = true;
            cbxAktiviteSeviyesi.Location = new Point(191, 264);
            cbxAktiviteSeviyesi.Name = "cbxAktiviteSeviyesi";
            cbxAktiviteSeviyesi.Size = new Size(191, 23);
            cbxAktiviteSeviyesi.TabIndex = 21;
            // 
            // txtKalcaCevresi
            // 
            txtKalcaCevresi.Location = new Point(191, 221);
            txtKalcaCevresi.Name = "txtKalcaCevresi";
            txtKalcaCevresi.Size = new Size(191, 23);
            txtKalcaCevresi.TabIndex = 20;
            // 
            // txtBelCevresi
            // 
            txtBelCevresi.Location = new Point(191, 178);
            txtBelCevresi.Name = "txtBelCevresi";
            txtBelCevresi.Size = new Size(191, 23);
            txtBelCevresi.TabIndex = 19;
            // 
            // txtBoyunCevresi
            // 
            txtBoyunCevresi.Location = new Point(191, 135);
            txtBoyunCevresi.Name = "txtBoyunCevresi";
            txtBoyunCevresi.Size = new Size(191, 23);
            txtBoyunCevresi.TabIndex = 18;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(191, 94);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(191, 23);
            txtKilo.TabIndex = 17;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(191, 52);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(191, 23);
            txtBoy.TabIndex = 16;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(15, 194, 192);
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.TopLeft;
            btnGuncelle.Location = new Point(191, 321);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(191, 41);
            btnGuncelle.TabIndex = 28;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // FormDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 423);
            Controls.Add(btnGuncelle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxAktiviteSeviyesi);
            Controls.Add(txtKalcaCevresi);
            Controls.Add(txtBelCevresi);
            Controls.Add(txtBoyunCevresi);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDuzenle";
            Text = "FormDuzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbxAktiviteSeviyesi;
        private TextBox txtKalcaCevresi;
        private TextBox txtBelCevresi;
        private TextBox txtBoyunCevresi;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private Button btnGuncelle;
    }
}