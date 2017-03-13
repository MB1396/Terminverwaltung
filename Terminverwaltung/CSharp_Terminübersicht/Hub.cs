using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CSharp_Terminübersicht
{
    public partial class hub : Form
    {
        DBConnect Connection = new DBConnect();
        public hub()
        {
            InitializeComponent();
            //DBConnect Connection = new DBConnect();
            if(Connection.dbOpen != true)
            {
                MessageBox.Show("Fehler bei Datenbankverbindung");
                Connection = null;
                this.Close();
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.UserName);
            this.Close();
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            Contacts frm = new Contacts();
            frm.Show();
        }

        private void newdate_Click(object sender, EventArgs e)
        {
            //Termin frm = new Termin();
            //frm.Show();

            
        }

        private void dateview_Click(object sender, EventArgs e)
        {
            DateViewer frm = new DateViewer();
            frm.Show();
        }


    }
}
