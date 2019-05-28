using System;
using wordlearn.Control;
namespace wordlearn
{
    public partial class wordadd : MetroFramework.Forms.MetroForm


    {
        public wordadd()
        {
            InitializeComponent();
        }

        private void Wordadd_Load(object sender, EventArgs e)
        {

        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainform = new mainForm();
            mainform.Show();
        }


        private void WordAddBtn_Click(object sender, EventArgs e)
        {
            if (WordProvider.AddWord(trTxtBox.Text, trSentencesTxtBox.Text, engTxtBox.Text, enSentencesTxtBox.Text))
            {
                // kelime eklendi
            }
            else
            {
                // eklenemedi
            }
                


        }
    }
}
