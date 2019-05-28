namespace wordlearn
{
    partial class statistics
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
            this.geriDonBtn = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.mCmbMonths = new MetroFramework.Controls.MetroComboBox();
            this.mCmbYears = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // geriDonBtn
            // 
            this.geriDonBtn.Location = new System.Drawing.Point(235, 317);
            this.geriDonBtn.Name = "geriDonBtn";
            this.geriDonBtn.Size = new System.Drawing.Size(230, 45);
            this.geriDonBtn.TabIndex = 0;
            this.geriDonBtn.Text = "Geri Dön";
            this.geriDonBtn.UseSelectable = true;
            this.geriDonBtn.Click += new System.EventHandler(this.GeriDonBtn_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(189, 124);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(471, 29);
            this.metroProgressBar1.TabIndex = 1;
            this.metroProgressBar1.Value = 35;
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(189, 247);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(471, 28);
            this.metroProgressBar2.TabIndex = 3;
            this.metroProgressBar2.Value = 50;
            // 
            // mCmbMonths
            // 
            this.mCmbMonths.FormattingEnabled = true;
            this.mCmbMonths.ItemHeight = 23;
            this.mCmbMonths.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.mCmbMonths.Location = new System.Drawing.Point(52, 124);
            this.mCmbMonths.Name = "mCmbMonths";
            this.mCmbMonths.PromptText = "Ay Seçiniz....";
            this.mCmbMonths.Size = new System.Drawing.Size(121, 29);
            this.mCmbMonths.TabIndex = 5;
            this.mCmbMonths.UseSelectable = true;
            // 
            // mCmbYears
            // 
            this.mCmbYears.FormattingEnabled = true;
            this.mCmbYears.ItemHeight = 23;
            this.mCmbYears.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.mCmbYears.Location = new System.Drawing.Point(52, 246);
            this.mCmbYears.Name = "mCmbYears";
            this.mCmbYears.PromptText = "Yıl Seçiniz....";
            this.mCmbYears.Size = new System.Drawing.Size(121, 29);
            this.mCmbYears.TabIndex = 6;
            this.mCmbYears.UseSelectable = true;
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.mCmbYears);
            this.Controls.Add(this.mCmbMonths);
            this.Controls.Add(this.metroProgressBar2);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.geriDonBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "statistics";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "İstatistikler";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton geriDonBtn;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private MetroFramework.Controls.MetroComboBox mCmbMonths;
        private MetroFramework.Controls.MetroComboBox mCmbYears;
    }
}