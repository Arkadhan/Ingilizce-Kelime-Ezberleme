using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordlearn.Control;


namespace wordlearn
{
    public partial class mainForm : MetroFramework.Forms.MetroForm

    {
        List<Rectangle> SaveControlBounds = new List<Rectangle>();
        public mainForm()
        {
            InitializeComponent();

            MoveControl.Ekle(mtAnswer1);
            MoveControl.Ekle(mtAnswer2);
            MoveControl.Ekle(mtAnswer3);
          

            MoveControl.CheckAnswer += MoveControl_CheckAnswer;
        }

        private void MoveControl_CheckAnswer(System.Windows.Forms.Control suruklenen, System.Windows.Forms.Control hedef)
        {
            if(WordProvider.CheckWord(suruklenen.Tag as Model.tbltrWord, hedef.Tag as Question))
            {
                WordProvider.SetKnownWord((hedef.Tag as Question).EnWord,true);
                MessageBox.Show("Bildiniz");


                
            }
            else
            {
                WordProvider.SetKnownWord((hedef.Tag as Question).EnWord, false);
                MessageBox.Show("Uzgunum Bılemedınız");
            }

            ShowNewQuestion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ShowNewQuestion();

        }

        private void ShowNewQuestion()
        {

            Question q = WordProvider.GetQuestion();


            mtQuestion.Text = q.EnWord.engWord.ToUpper();
            mtQuestion.Tag = q;


            mtAnswer1.Text = q.TrAnswer1.trWord.ToUpper();
            mtAnswer1.Tag = q.TrAnswer1;

            mtAnswer2.Text = q.TrAnswer2.trWord.ToUpper();
            mtAnswer2.Tag = q.TrAnswer2;

            mtAnswer3.Text = q.TrAnswer3.trWord.ToUpper();
            mtAnswer3.Tag = q.TrAnswer3;

            if (SaveControlBounds.Count > 0)
            {
                mtAnswer1.Bounds = SaveControlBounds[0];
                mtAnswer2.Bounds = SaveControlBounds[1];
                mtAnswer3.Bounds = SaveControlBounds[2];
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SaveControlBounds.Add(mtAnswer1.Bounds);
            SaveControlBounds.Add(mtAnswer2.Bounds);
            SaveControlBounds.Add(mtAnswer3.Bounds);
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MtAddWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            wordadd wordAddForm = new wordadd();
            wordAddForm.Show();
           
        }

        private void MtIstatistik_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics istatistikForm = new statistics();
            istatistikForm.Show();

        }
    }
}
