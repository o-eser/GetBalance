namespace GetBalance.UI
{
    partial class FormRapor
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
            grpbxKiyasRaporu = new GroupBox();
            listView1 = new ListView();
            label2 = new Label();
            cmbxKategori = new ComboBox();
            grpbxYemekcesidiRaporu = new GroupBox();
            listView2 = new ListView();
            clmnYemekAdi = new ColumnHeader();
            clmnMiktar = new ColumnHeader();
            label1 = new Label();
            cmbxOgun = new ComboBox();
            chbxHafta = new CheckBox();
            chbxAylik = new CheckBox();
            cmbxOgun2 = new ComboBox();
            label3 = new Label();
            clmnYemekAdi1 = new ColumnHeader();
            clmnMiktar1 = new ColumnHeader();
            grpbxKiyasRaporu.SuspendLayout();
            grpbxYemekcesidiRaporu.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxKiyasRaporu
            // 
            grpbxKiyasRaporu.Controls.Add(label3);
            grpbxKiyasRaporu.Controls.Add(cmbxOgun2);
            grpbxKiyasRaporu.Controls.Add(chbxAylik);
            grpbxKiyasRaporu.Controls.Add(chbxHafta);
            grpbxKiyasRaporu.Controls.Add(listView1);
            grpbxKiyasRaporu.Controls.Add(label2);
            grpbxKiyasRaporu.Controls.Add(cmbxKategori);
            grpbxKiyasRaporu.Dock = DockStyle.Left;
            grpbxKiyasRaporu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpbxKiyasRaporu.Location = new Point(0, 0);
            grpbxKiyasRaporu.Name = "grpbxKiyasRaporu";
            grpbxKiyasRaporu.Size = new Size(520, 685);
            grpbxKiyasRaporu.TabIndex = 0;
            grpbxKiyasRaporu.TabStop = false;
            grpbxKiyasRaporu.Text = "Kıyas Raporu";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clmnYemekAdi1, clmnMiktar1 });
            listView1.Location = new Point(37, 121);
            listView1.Name = "listView1";
            listView1.Size = new Size(453, 514);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(186, 21);
            label2.TabIndex = 3;
            label2.Text = "Lütfen Kategori Seçiniz";
            // 
            // cmbxKategori
            // 
            cmbxKategori.FormattingEnabled = true;
            cmbxKategori.Location = new Point(12, 71);
            cmbxKategori.Name = "cmbxKategori";
            cmbxKategori.Size = new Size(186, 29);
            cmbxKategori.TabIndex = 2;
            // 
            // grpbxYemekcesidiRaporu
            // 
            grpbxYemekcesidiRaporu.Controls.Add(listView2);
            grpbxYemekcesidiRaporu.Controls.Add(label1);
            grpbxYemekcesidiRaporu.Controls.Add(cmbxOgun);
            grpbxYemekcesidiRaporu.Dock = DockStyle.Right;
            grpbxYemekcesidiRaporu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpbxYemekcesidiRaporu.Location = new Point(578, 0);
            grpbxYemekcesidiRaporu.Name = "grpbxYemekcesidiRaporu";
            grpbxYemekcesidiRaporu.Size = new Size(522, 685);
            grpbxYemekcesidiRaporu.TabIndex = 1;
            grpbxYemekcesidiRaporu.TabStop = false;
            grpbxYemekcesidiRaporu.Text = "Yemek Çeşidi Raporu";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { clmnYemekAdi, clmnMiktar });
            listView2.Location = new Point(33, 121);
            listView2.Name = "listView2";
            listView2.Size = new Size(453, 514);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // clmnYemekAdi
            // 
            clmnYemekAdi.Text = "Yemek Adı";
            clmnYemekAdi.Width = 300;
            // 
            // clmnMiktar
            // 
            clmnMiktar.Text = "Miktar";
            clmnMiktar.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 38);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 1;
            label1.Text = "Lütfen Öğün Seçiniz";
            // 
            // cmbxOgun
            // 
            cmbxOgun.FormattingEnabled = true;
            cmbxOgun.Location = new Point(142, 71);
            cmbxOgun.Name = "cmbxOgun";
            cmbxOgun.Size = new Size(235, 29);
            cmbxOgun.TabIndex = 0;
            // 
            // chbxHafta
            // 
            chbxHafta.AutoSize = true;
            chbxHafta.Location = new Point(424, 38);
            chbxHafta.Name = "chbxHafta";
            chbxHafta.Size = new Size(90, 25);
            chbxHafta.TabIndex = 5;
            chbxHafta.Text = "Haftalık";
            chbxHafta.UseVisualStyleBackColor = true;
            // 
            // chbxAylik
            // 
            chbxAylik.AutoSize = true;
            chbxAylik.Location = new Point(424, 75);
            chbxAylik.Name = "chbxAylik";
            chbxAylik.Size = new Size(68, 25);
            chbxAylik.TabIndex = 6;
            chbxAylik.Text = "Aylık";
            chbxAylik.UseVisualStyleBackColor = true;
            // 
            // cmbxOgun2
            // 
            cmbxOgun2.FormattingEnabled = true;
            cmbxOgun2.Location = new Point(214, 71);
            cmbxOgun2.Name = "cmbxOgun2";
            cmbxOgun2.Size = new Size(186, 29);
            cmbxOgun2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 39);
            label3.Name = "label3";
            label3.Size = new Size(163, 21);
            label3.TabIndex = 8;
            label3.Text = "Lütfen Öğün Seçiniz";
            // 
            // clmnYemekAdi1
            // 
            clmnYemekAdi1.Text = "Yemek Adı";
            clmnYemekAdi1.Width = 300;
            // 
            // clmnMiktar1
            // 
            clmnMiktar1.Text = "Miktar";
            clmnMiktar1.Width = 200;
            // 
            // FormRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 685);
            Controls.Add(grpbxYemekcesidiRaporu);
            Controls.Add(grpbxKiyasRaporu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRapor";
            Text = "FormRapor";
            grpbxKiyasRaporu.ResumeLayout(false);
            grpbxKiyasRaporu.PerformLayout();
            grpbxYemekcesidiRaporu.ResumeLayout(false);
            grpbxYemekcesidiRaporu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbxKiyasRaporu;
        private GroupBox grpbxYemekcesidiRaporu;
        private ListView listView1;
        private Label label2;
        private ComboBox cmbxKategori;
        private ListView listView2;
        private Label label1;
        private ComboBox cmbxOgun;
        private ColumnHeader clmnYemekAdi;
        private ColumnHeader clmnMiktar;
        private Label label3;
        private ComboBox cmbxOgun2;
        private CheckBox chbxAylik;
        private CheckBox chbxHafta;
        private ColumnHeader clmnYemekAdi1;
        private ColumnHeader clmnMiktar1;
    }
}