using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordlearn.Control
{
    public class Events
    {
        public delegate void CheckAnswerEventHandler(System.Windows.Forms.Control suruklenen, System.Windows.Forms.Control hedef);
    }
}
