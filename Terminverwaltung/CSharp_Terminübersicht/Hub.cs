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
            Contacts frm = new Contacts();
            frm.Show();
        }

        private void newdate_Click(object sender, EventArgs e)
        {
            //Termin frm = new Termin();
            //frm.Show();

                        OleDbConnection dbConnect = null;
            OleDbCommand dbCommand = null;
            OleDbDataReader dbReader = null;
            bool dbOpen = false;
            string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PGörtz.BKH\Desktop\DBProj.accdb";
            

            try
            {
                dbConnect = new OleDbConnection(strCon);
                dbConnect.Open();
                dbOpen = true;


                dbCommand = dbConnect.CreateCommand();
                dbCommand.CommandText = "Insert Into Kontakte Values (1, 'Goertz', 'Pascal' , 'Garzweiler Allee' , 41363 , 'Juechen' , '1234567' , 'BlaBla.de' );";

                dbReader = dbCommand.ExecuteReader();
                while(dbReader.Read())
                {
                    MessageBox.Show(dbReader.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbConnect.Close();
            }
        }

        private void dateview_Click(object sender, EventArgs e)
        {
            DateViewer frm = new DateViewer();
            frm.Show();
        }


    }
}
