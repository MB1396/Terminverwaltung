using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Terminübersicht
{
    public partial class hub : Form
    {
        public hub()
        {
            InitializeComponent();
        }

        private void end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            this.Show(new Contacts());
        }

        private void dateview_Click(object sender, EventArgs e)
        {
            //tesr
        }


    }
}
