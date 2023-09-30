namespace GetBalance.UI
{
    partial class FormAyarlar
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
            btnHesabiSil = new Button();
            btnCikisYap = new Button();
            SuspendLayout();
            // 
            // btnHesabiSil
            // 
            btnHesabiSil.BackColor = Color.FromArgb(2, 53, 53);
            btnHesabiSil.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesabiSil.ForeColor = Color.White;
            btnHesabiSil.Location = new Point(340, 125);
            btnHesabiSil.Name = "btnHesabiSil";
            btnHesabiSil.Size = new Size(299, 65);
            btnHesabiSil.TabIndex = 0;
            btnHesabiSil.Text = "Hesabı Sil";
            btnHesabiSil.UseVisualStyleBackColor = false;
            btnHesabiSil.Click += btnHesabiSil_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.FromArgb(2, 53, 53);
            btnCikisYap.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikisYap.ForeColor = Color.White;
            btnCikisYap.Location = new Point(340, 218);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(299, 65);
            btnCikisYap.TabIndex = 1;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // FormAyarlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 432);
            Controls.Add(btnCikisYap);
            Controls.Add(btnHesabiSil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAyarlar";
            Text = "FormAyarlar";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHesabiSil;
        private Button btnCikisYap;
    }
}