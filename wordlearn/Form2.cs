using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordlearn
{
    public partial class Form2 : Form
    {
        Point farkNokta;
        public Form2()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox tile = sender as PictureBox;

            if (tile != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    label1.Text = e.Location.ToString() + ";" + tile.Location.ToString();
                
                    Point pt = PointToClient(Cursor.Position);

                    tile.Location = new Point(pt.X+ farkNokta.X, pt.Y+ farkNokta.Y);
                }
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox tile = sender as PictureBox;

            if (tile != null)
            {
                Point pt = PointToClient(Cursor.Position);
                farkNokta = new Point(tile.Left - pt.X, tile.Top - pt.Y); 
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Point pt = PointToClient(Cursor.Position);


           foreach(System.Windows.Forms.Control c in Controls)
            {
                if(c!=sender && c.Bounds.Contains(pt))
                {
                    MessageBox.Show(c.Name);
                    return;
                }
            }
        }
    }
}
