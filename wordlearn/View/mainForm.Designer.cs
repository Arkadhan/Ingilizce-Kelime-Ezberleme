namespace wordlearn
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.mtAnswer1 = new MetroFramework.Controls.MetroTile();
            this.mtAnswer3 = new MetroFramework.Controls.MetroTile();
            this.mtAnswer2 = new MetroFramework.Controls.MetroTile();
            this.mtIstatistik = new MetroFramework.Controls.MetroTile();
            this.mtAddWord = new MetroFramework.Controls.MetroTile();
            this.mtQuestion = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(345, 246);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(52, 47);
            this.metroProgressSpinner1.TabIndex = 12;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // mtAnswer1
            // 
            this.mtAnswer1.ActiveControl = null;
            this.mtAnswer1.AllowDrop = true;
            this.mtAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.mtAnswer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAnswer1.ForeColor = System.Drawing.Color.Black;
            this.mtAnswer1.Location = new System.Drawing.Point(199, 258);
            this.mtAnswer1.Name = "mtAnswer1";
            this.mtAnswer1.Size = new System.Drawing.Size(115, 86);
            this.mtAnswer1.TabIndex = 11;
            this.mtAnswer1.Text = "Kivi";
            this.mtAnswer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAnswer1.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAnswer1.TileImage")));
            this.mtAnswer1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtAnswer1.UseCustomBackColor = true;
            this.mtAnswer1.UseCustomForeColor = true;
            this.mtAnswer1.UseSelectable = true;
            this.mtAnswer1.UseStyleColors = true;
            this.mtAnswer1.UseTileImage = true;
            // 
            // mtAnswer3
            // 
            this.mtAnswer3.ActiveControl = null;
            this.mtAnswer3.AllowDrop = true;
            this.mtAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.mtAnswer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAnswer3.ForeColor = System.Drawing.Color.Black;
            this.mtAnswer3.Location = new System.Drawing.Point(441, 258);
            this.mtAnswer3.Name = "mtAnswer3";
            this.mtAnswer3.Size = new System.Drawing.Size(115, 86);
            this.mtAnswer3.TabIndex = 8;
            this.mtAnswer3.Text = "Elma";
            this.mtAnswer3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAnswer3.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAnswer3.TileImage")));
            this.mtAnswer3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtAnswer3.UseCustomBackColor = true;
            this.mtAnswer3.UseCustomForeColor = true;
            this.mtAnswer3.UseSelectable = true;
            this.mtAnswer3.UseStyleColors = true;
            this.mtAnswer3.UseTileImage = true;
            // 
            // mtAnswer2
            // 
            this.mtAnswer2.ActiveControl = null;
            this.mtAnswer2.AllowDrop = true;
            this.mtAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.mtAnswer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAnswer2.ForeColor = System.Drawing.Color.Black;
            this.mtAnswer2.Location = new System.Drawing.Point(320, 311);
            this.mtAnswer2.Name = "mtAnswer2";
            this.mtAnswer2.Size = new System.Drawing.Size(115, 86);
            this.mtAnswer2.TabIndex = 7;
            this.mtAnswer2.Text = "Çilek";
            this.mtAnswer2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAnswer2.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAnswer2.TileImage")));
            this.mtAnswer2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtAnswer2.UseCustomBackColor = true;
            this.mtAnswer2.UseCustomForeColor = true;
            this.mtAnswer2.UseSelectable = true;
            this.mtAnswer2.UseTileImage = true;
            // 
            // mtIstatistik
            // 
            this.mtIstatistik.ActiveControl = null;
            this.mtIstatistik.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mtIstatistik.ForeColor = System.Drawing.Color.White;
            this.mtIstatistik.Location = new System.Drawing.Point(574, 75);
            this.mtIstatistik.Name = "mtIstatistik";
            this.mtIstatistik.Size = new System.Drawing.Size(156, 308);
            this.mtIstatistik.TabIndex = 9;
            this.mtIstatistik.Text = "İstatistikler";
            this.mtIstatistik.TileImage = ((System.Drawing.Image)(resources.GetObject("mtIstatistik.TileImage")));
            this.mtIstatistik.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtIstatistik.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtIstatistik.UseCustomBackColor = true;
            this.mtIstatistik.UseCustomForeColor = true;
            this.mtIstatistik.UseSelectable = true;
            this.mtIstatistik.UseStyleColors = true;
            this.mtIstatistik.UseTileImage = true;
            this.mtIstatistik.Click += new System.EventHandler(this.MtIstatistik_Click);
            // 
            // mtAddWord
            // 
            this.mtAddWord.ActiveControl = null;
            this.mtAddWord.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mtAddWord.ForeColor = System.Drawing.Color.White;
            this.mtAddWord.Location = new System.Drawing.Point(18, 75);
            this.mtAddWord.Name = "mtAddWord";
            this.mtAddWord.Size = new System.Drawing.Size(156, 308);
            this.mtAddWord.TabIndex = 2;
            this.mtAddWord.Text = "Kelime ekle";
            this.mtAddWord.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAddWord.TileImage")));
            this.mtAddWord.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAddWord.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAddWord.UseCustomBackColor = true;
            this.mtAddWord.UseCustomForeColor = true;
            this.mtAddWord.UseSelectable = true;
            this.mtAddWord.UseTileImage = true;
            this.mtAddWord.Click += new System.EventHandler(this.MtAddWord_Click);
            // 
            // mtQuestion
            // 
            this.mtQuestion.ActiveControl = null;
            this.mtQuestion.BackColor = System.Drawing.Color.White;
            this.mtQuestion.ForeColor = System.Drawing.Color.Black;
            this.mtQuestion.Location = new System.Drawing.Point(246, 63);
            this.mtQuestion.Name = "mtQuestion";
            this.mtQuestion.Size = new System.Drawing.Size(255, 177);
            this.mtQuestion.TabIndex = 5;
            this.mtQuestion.Text = "Apple";
            this.mtQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtQuestion.TileImage = ((System.Drawing.Image)(resources.GetObject("mtQuestion.TileImage")));
            this.mtQuestion.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtQuestion.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtQuestion.UseCustomBackColor = true;
            this.mtQuestion.UseCustomForeColor = true;
            this.mtQuestion.UseSelectable = true;
            this.mtQuestion.UseTileImage = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.mtAnswer1);
            this.Controls.Add(this.mtAnswer3);
            this.Controls.Add(this.mtAnswer2);
            this.Controls.Add(this.mtIstatistik);
            this.Controls.Add(this.mtAddWord);
            this.Controls.Add(this.mtQuestion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Kelime Ezberleme Programı";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtQuestion;
        private MetroFramework.Controls.MetroTile mtAnswer2;
        private MetroFramework.Controls.MetroTile mtAnswer3;
        private MetroFramework.Controls.MetroTile mtAddWord;
        private MetroFramework.Controls.MetroTile mtIstatistik;
        private MetroFramework.Controls.MetroTile mtAnswer1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}

