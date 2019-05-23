using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordlearn.Control
{
    public class Question
    {
        public Model.tblengWord EnWord { get; set; }
        public Model.tbltrWord TrAnswer1 { get; set; }
        public Model.tbltrWord TrAnswer2 { get; set; }
        public Model.tbltrWord TrAnswer3 { get; set; }

        public Model.tbltrWord TrueAnswer { get; set; }
    }
}
