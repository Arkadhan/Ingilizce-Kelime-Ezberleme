namespace wordlearn
{
    partial class wordadd
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.trTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.engTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.trSentencesTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.enSentencesTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.wordAddBtn = new MetroFramework.Controls.MetroButton();
            this.turnBackMainFormBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(130, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Türkçe Kelime";
            this.metroLabel1.Click += new System.EventHandler(this.MetroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(130, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "İngilizce Kelime";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(130, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Türkçe Cümle";
            this.metroLabel3.Click += new System.EventHandler(this.MetroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(130, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "İngilizce Cümle";
            // 
            // trTxtBox
            // 
            // 
            // 
            // 
            this.trTxtBox.CustomButton.Image = null;
            this.trTxtBox.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.trTxtBox.CustomButton.Name = "";
            this.trTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.trTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.trTxtBox.CustomButton.TabIndex = 1;
            this.trTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trTxtBox.CustomButton.UseSelectable = true;
            this.trTxtBox.CustomButton.Visible = false;
            this.trTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.trTxtBox.Lines = new string[0];
            this.trTxtBox.Location = new System.Drawing.Point(282, 86);
            this.trTxtBox.MaxLength = 25;
            this.trTxtBox.Name = "trTxtBox";
            this.trTxtBox.PasswordChar = '\0';
            this.trTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.trTxtBox.SelectedText = "";
            this.trTxtBox.SelectionLength = 0;
            this.trTxtBox.SelectionStart = 0;
            this.trTxtBox.ShortcutsEnabled = true;
            this.trTxtBox.Size = new System.Drawing.Size(278, 23);
            this.trTxtBox.TabIndex = 4;
            this.trTxtBox.UseSelectable = true;
            this.trTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.trTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // engTxtBox
            // 
            // 
            // 
            // 
            this.engTxtBox.CustomButton.Image = null;
            this.engTxtBox.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.engTxtBox.CustomButton.Name = "";
            this.engTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.engTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.engTxtBox.CustomButton.TabIndex = 1;
            this.engTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.engTxtBox.CustomButton.UseSelectable = true;
            this.engTxtBox.CustomButton.Visible = false;
            this.engTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.engTxtBox.Lines = new string[0];
            this.engTxtBox.Location = new System.Drawing.Point(282, 165);
            this.engTxtBox.MaxLength = 25;
            this.engTxtBox.Name = "engTxtBox";
            this.engTxtBox.PasswordChar = '\0';
            this.engTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.engTxtBox.SelectedText = "";
            this.engTxtBox.SelectionLength = 0;
            this.engTxtBox.SelectionStart = 0;
            this.engTxtBox.ShortcutsEnabled = true;
            this.engTxtBox.Size = new System.Drawing.Size(278, 23);
            this.engTxtBox.TabIndex = 5;
            this.engTxtBox.UseSelectable = true;
            this.engTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.engTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // trSentencesTxtBox
            // 
            // 
            // 
            // 
            this.trSentencesTxtBox.CustomButton.Image = null;
            this.trSentencesTxtBox.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.trSentencesTxtBox.CustomButton.Name = "";
            this.trSentencesTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.trSentencesTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.trSentencesTxtBox.CustomButton.TabIndex = 1;
            this.trSentencesTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trSentencesTxtBox.CustomButton.UseSelectable = true;
            this.trSentencesTxtBox.CustomButton.Visible = false;
            this.trSentencesTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.trSentencesTxtBox.Lines = new string[0];
            this.trSentencesTxtBox.Location = new System.Drawing.Point(282, 127);
            this.trSentencesTxtBox.MaxLength = 250;
            this.trSentencesTxtBox.Name = "trSentencesTxtBox";
            this.trSentencesTxtBox.PasswordChar = '\0';
            this.trSentencesTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.trSentencesTxtBox.SelectedText = "";
            this.trSentencesTxtBox.SelectionLength = 0;
            this.trSentencesTxtBox.SelectionStart = 0;
            this.trSentencesTxtBox.ShortcutsEnabled = true;
            this.trSentencesTxtBox.Size = new System.Drawing.Size(278, 23);
            this.trSentencesTxtBox.TabIndex = 6;
            this.trSentencesTxtBox.UseSelectable = true;
            this.trSentencesTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.trSentencesTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // enSentencesTxtBox
            // 
            // 
            // 
            // 
            this.enSentencesTxtBox.CustomButton.Image = null;
            this.enSentencesTxtBox.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.enSentencesTxtBox.CustomButton.Name = "";
            this.enSentencesTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.enSentencesTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.enSentencesTxtBox.CustomButton.TabIndex = 1;
            this.enSentencesTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.enSentencesTxtBox.CustomButton.UseSelectable = true;
            this.enSentencesTxtBox.CustomButton.Visible = false;
            this.enSentencesTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.enSentencesTxtBox.Lines = new string[0];
            this.enSentencesTxtBox.Location = new System.Drawing.Point(282, 201);
            this.enSentencesTxtBox.MaxLength = 250;
            this.enSentencesTxtBox.Name = "enSentencesTxtBox";
            this.enSentencesTxtBox.PasswordChar = '\0';
            this.enSentencesTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.enSentencesTxtBox.SelectedText = "";
            this.enSentencesTxtBox.SelectionLength = 0;
            this.enSentencesTxtBox.SelectionStart = 0;
            this.enSentencesTxtBox.ShortcutsEnabled = true;
            this.enSentencesTxtBox.Size = new System.Drawing.Size(278, 23);
            this.enSentencesTxtBox.TabIndex = 7;
            this.enSentencesTxtBox.UseSelectable = true;
            this.enSentencesTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.enSentencesTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // wordAddBtn
            // 
            this.wordAddBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.wordAddBtn.Location = new System.Drawing.Point(130, 247);
            this.wordAddBtn.Name = "wordAddBtn";
            this.wordAddBtn.Size = new System.Drawing.Size(430, 43);
            this.wordAddBtn.TabIndex = 8;
            this.wordAddBtn.Text = "Kelime Ekle";
            this.wordAddBtn.UseSelectable = true;
            this.wordAddBtn.Click += new System.EventHandler(this.WordAddBtn_Click);
            // 
            // turnBackMainFormBtn
            // 
            this.turnBackMainFormBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.turnBackMainFormBtn.Location = new System.Drawing.Point(130, 310);
            this.turnBackMainFormBtn.Name = "turnBackMainFormBtn";
            this.turnBackMainFormBtn.Size = new System.Drawing.Size(430, 43);
            this.turnBackMainFormBtn.TabIndex = 9;
            this.turnBackMainFormBtn.Text = "Geri Dön";
            this.turnBackMainFormBtn.UseSelectable = true;
            this.turnBackMainFormBtn.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // wordadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.turnBackMainFormBtn);
            this.Controls.Add(this.wordAddBtn);
            this.Controls.Add(this.enSentencesTxtBox);
            this.Controls.Add(this.trSentencesTxtBox);
            this.Controls.Add(this.engTxtBox);
            this.Controls.Add(this.trTxtBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "wordadd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kelime Ekle";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Wordadd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox trTxtBox;
        private MetroFramework.Controls.MetroTextBox engTxtBox;
        private MetroFramework.Controls.MetroTextBox trSentencesTxtBox;
        private MetroFramework.Controls.MetroTextBox enSentencesTxtBox;
        private MetroFramework.Controls.MetroButton wordAddBtn;
        private MetroFramework.Controls.MetroButton turnBackMainFormBtn;
    }
}