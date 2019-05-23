using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordlearn.Control;
using static wordlearn.Control.Events;

namespace wordlearn
{
    public class MoveControl
    {
        static Point farkNokta;

        public static event CheckAnswerEventHandler CheckAnswer;


        public static void Ekle(System.Windows.Forms.Control c)
        {
            c.MouseDown += Control_MouseDown;
            c.MouseUp += Control_MouseUp;
            c.MouseMove += Control_MouseMove;
        }

        public static void Kaldir(System.Windows.Forms.Control c)
        {
            c.MouseDown -= Control_MouseDown;
            c.MouseUp -= Control_MouseUp;
            c.MouseMove -= Control_MouseMove;
        }

        private static void Control_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Control suruklenen = sender as System.Windows.Forms.Control;

            if (suruklenen != null)
            {
                if (e.Button == MouseButtons.Left)
                {                  
                    Point pt = suruklenen.Parent.PointToClient(Cursor.Position);
                    suruklenen.Location = new Point(pt.X + farkNokta.X, pt.Y + farkNokta.Y);
                }
            }
        }
        private static void Control_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Control suruklenen = sender as System.Windows.Forms.Control;

            if (suruklenen != null)
            {
                suruklenen.BringToFront();
                Point pt = suruklenen.Parent.PointToClient(Cursor.Position);
                farkNokta = new Point(suruklenen.Left - pt.X, suruklenen.Top - pt.Y);
            }
        }
        private static void Control_MouseUp(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Control suruklenen = sender as System.Windows.Forms.Control;
            Point pt = suruklenen.Parent.PointToClient(Cursor.Position);
           
            foreach (System.Windows.Forms.Control hedef in suruklenen.Parent.Controls)
            {
                if (hedef != sender && hedef.Visible && hedef.Tag is Question && hedef.Bounds.Contains(pt))
                {
                    CheckAnswer(suruklenen, hedef);
                }
            }
        }
    }
}
