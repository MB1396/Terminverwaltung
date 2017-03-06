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
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string strInsert = "", strValues = "";
            
            strInsert = "Insert Into Kontakte ";
            strValues = "Values (" + this.Name.ToString().Trim() + "," + this.vorname.ToString().Trim() + "," + this.anschrift.ToString().Trim() + "," +
                        this.phone.ToString().Trim() + "," + this.mail.ToString().Trim() + "," + this.ProfilePic.ToString().Trim() + ")";

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
                dbCommand.CommandText = Convert.ToString(strInsert + strValues); //"Insert Into Kontakte Values (1, 'Goertz', 'Pascal' , 'Garzweiler Allee' , 41363 , 'Juechen' , '1234567' , 'BlaBla.de' );";

                dbReader = dbCommand.ExecuteReader();
                while (dbReader.Read())
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
    }
}
