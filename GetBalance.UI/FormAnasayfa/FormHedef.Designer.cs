namespace GetBalance.UI
{
    partial class FormHedef
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtHedefKalori = new TextBox();
            txtHedefYag = new TextBox();
            txtHedefCarbon = new TextBox();
            txtHedefProtein = new TextBox();
            txtHedefKilo = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(172, 255);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 19;
            label5.Text = "Hedeflenen Kalori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(122, 216);
            label4.Name = "label4";
            label4.Size = new Size(201, 21);
            label4.TabIndex = 18;
            label4.Text = "Hedeflenen Yağ Yüzdesi %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 175);
            label3.Name = "label3";
            label3.Size = new Size(271, 21);
            label3.TabIndex = 17;
            label3.Text = "Hedeflenen Karbonhidrat Yüzdesi %";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 135);
            label2.Name = "label2";
            label2.Size = new Size(228, 21);
            label2.TabIndex = 16;
            label2.Text = "Hedeflenen Protein Yüzdesi %";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(195, 97);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 15;
            label1.Text = "Hedeflenen Kilo";
            // 
            // txtHedefKalori
            // 
            txtHedefKalori.Location = new Point(355, 253);
            txtHedefKalori.Name = "txtHedefKalori";
            txtHedefKalori.Size = new Size(183, 23);
            txtHedefKalori.TabIndex = 14;
            // 
            // txtHedefYag
            // 
            txtHedefYag.Location = new Point(355, 214);
            txtHedefYag.Name = "txtHedefYag";
            txtHedefYag.Size = new Size(183, 23);
            txtHedefYag.TabIndex = 13;
            // 
            // txtHedefCarbon
            // 
            txtHedefCarbon.Location = new Point(355, 173);
            txtHedefCarbon.Name = "txtHedefCarbon";
            txtHedefCarbon.Size = new Size(183, 23);
            txtHedefCarbon.TabIndex = 12;
            // 
            // txtHedefProtein
            // 
            txtHedefProtein.Location = new Point(355, 133);
            txtHedefProtein.Name = "txtHedefProtein";
            txtHedefProtein.Size = new Size(183, 23);
            txtHedefProtein.TabIndex = 11;
            // 
            // txtHedefKilo
            // 
            txtHedefKilo.Location = new Point(355, 95);
            txtHedefKilo.Name = "txtHedefKilo";
            txtHedefKilo.Size = new Size(183, 23);
            txtHedefKilo.TabIndex = 10;
            // 
            // FormHedef
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 380);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHedefKalori);
            Controls.Add(txtHedefYag);
            Controls.Add(txtHedefCarbon);
            Controls.Add(txtHedefProtein);
            Controls.Add(txtHedefKilo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHedef";
            Text = "FormHedef";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtHedefKalori;
        private TextBox txtHedefYag;
        private TextBox txtHedefCarbon;
        private TextBox txtHedefProtein;
        private TextBox txtHedefKilo;
    }
}