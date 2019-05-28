using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordlearn.Control
{
    public class WordProvider
    {
        static Random r = new Random();

        public static bool CheckWord(Model.tbltrWord trWorld, Question question)
        {
            if (trWorld != null && question != null)
            {
                if (trWorld.trID == question.EnWord.engID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public static Question GetQuestion()
        {
            DateTime simdi = DateTime.Now;
            DateTime hafta = simdi.AddDays(-7);
            DateTime ay = simdi.AddMonths(-1);
            DateTime ay6 = simdi.AddMonths(-6);

            
            // Veritabanından üretilen rasgele kelime geliyor
            var liste = OrtakDb.db.tblengWords.ToList();

            //** var liste = OrtakDb.db.tblengWords.Where(
            //x =>!x.yesterday ||
            //x.tarıh>hafta&&!x.lastweek||
            //x.tarıh>ay&&!x.lastmount||
            //x.tarıh>ay6&&x.lastsixmounth).ToList();

            int randomWordID = r.Next(0, liste.Count-1);

            //var word = OrtakDb.db.tblengWords.FirstOrDefault(x => x.engID == randomWordID);
            var word = liste[randomWordID];



            // Gelen kelime doğru cevabada atanıyor
            var trueanswer = OrtakDb.db.tbltrWords.FirstOrDefault(x => x.trID == word.engID);

            var liste2 = OrtakDb.db.tbltrWords.ToList();
            // 2 tane yanlış cevap geliyor
            int randomvt = r.Next(0, liste2.Count-1);
            var answer2 = liste2[randomvt];
            //OrtakDb.db.tbltrWords.FirstOrDefault(x => x.trID == randomvt);

            int randomvt2 = r.Next(0, liste2.Count - 1);
            var answer3 = liste2[randomvt2];
            //int randomvt2 = r.Next(1, 1000);
            //var answer3 = OrtakDb.db.tbltrWords.FirstOrDefault(x => x.trID == randomvt2);


            int trueIndex = r.Next(1, 3);

            if(trueIndex==1)
                return new Question() { EnWord = word, TrAnswer1 = trueanswer, TrAnswer2 = answer2, TrAnswer3 = answer3, TrueAnswer = trueanswer };
            else if (trueIndex == 2)
                return new Question() { EnWord = word, TrAnswer1 = answer2, TrAnswer2 = trueanswer, TrAnswer3 = answer3, TrueAnswer = trueanswer };
            else 
                return new Question() { EnWord = word, TrAnswer1 = answer3, TrAnswer2 = answer2, TrAnswer3 = trueanswer , TrueAnswer = trueanswer };
        }

        public static void SetKnownWord(Model.tblengWord enWorld,bool isKnown)
        {
            /*................. tarihlerrrr
             eğer isknow doğruysa tarihler set edilecek date olacak onu da güncelleyecez
                       
             
             */
            
        }
        public static bool AddWord(string trWord, string trSentences, string enWord, string enSentences)
        {
            if (!string.IsNullOrEmpty(trWord))
            {
                Model.tbltrWord yeniTrWord = new Model.tbltrWord();
                yeniTrWord.trWord = trWord;
                yeniTrWord.trSentences = trSentences;

                Model.tblengWord yeniEngWord = new Model.tblengWord();
                yeniEngWord.engWord = enWord;
                yeniEngWord.engSentences = enSentences;

                OrtakDb.db.tbltrWords.Add(yeniTrWord);
                OrtakDb.db.tblengWords.Add(yeniEngWord);
                OrtakDb.db.SaveChanges();
                return true;
            }
            return false;


        }
    }
}
