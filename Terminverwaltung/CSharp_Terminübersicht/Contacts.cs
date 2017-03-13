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
using System.Data.SqlClient;

namespace CSharp_Terminübersicht
{
    public partial class Contacts : Form
    {
        DBConnect Connection = new DBConnect();
        public Contacts()
        {
            //private BindingSource bindingSource1 = new BindingSource();

            InitializeComponent();
            DataSet myDS = new DataSet("Contacts");
            this.dataGridView1.DataSource = "Select * From Contacts";
        }

        private void save_Click(object sender, EventArgs e)
        {
            string strInsert = "", strValues = "";
            
            strInsert = "Insert Into Kontakte ";
            strValues = "Values (" + this.Name.ToString().Trim() + "," + this.vorname.ToString().Trim() + "," + this.anschrift.ToString().Trim() + "," +
                        this.phone.ToString().Trim() + "," + this.mail.ToString().Trim() + "," + this.ProfilePic.ToString().Trim() + ")";

            Connection.fCreateCommand(strInsert + " " + strValues);
        }

       
    }
}
