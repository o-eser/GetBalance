namespace GetBalance.UI
{
    partial class FormHatirlatici
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            btnAlarmKur = new Button();
            nupSure = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupSure).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnAlarmKur
            // 
            btnAlarmKur.Location = new Point(119, 101);
            btnAlarmKur.Name = "btnAlarmKur";
            btnAlarmKur.Size = new Size(100, 44);
            btnAlarmKur.TabIndex = 0;
            btnAlarmKur.Text = "Alarm Kur";
            btnAlarmKur.UseVisualStyleBackColor = true;
            btnAlarmKur.Click += btnAlarmKur_Click;
            // 
            // nupSure
            // 
            nupSure.Location = new Point(247, 114);
            nupSure.Name = "nupSure";
            nupSure.Size = new Size(130, 23);
            nupSure.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(237, 62);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 2;
            label1.Text = "Lütfen Saati Giriniz";
            // 
            // FormHatirlatici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 259);
            Controls.Add(label1);
            Controls.Add(nupSure);
            Controls.Add(btnAlarmKur);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHatirlatici";
            Text = "FormHatirlatici";
            Load += FormHatirlatici_Load;
            ((System.ComponentModel.ISupportInitialize)nupSure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnAlarmKur;
        private NumericUpDown nupSure;
        private Label label1;
    }
}