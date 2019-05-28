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
    public partial class statistics : MetroFramework.Forms.MetroForm
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void GeriDonBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm anaForm = new mainForm();
            anaForm.Show();
        }
    }
}
