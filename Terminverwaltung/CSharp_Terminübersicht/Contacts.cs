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
        DBConnect connection = new DBConnect();
        public Contacts()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string strInsert = "", strValues = "";
            
            strInsert = "Insert Into Kontakte ";
            strValues = "Values (" + this.txtName.Text.ToString().Trim() + "," + this.txtVorname.Text.ToString().Trim() + "," + this.txtAnschrift.Text.ToString().Trim() + "," +
                        this.txtTelefon.Text.ToString().Trim() + "," + this.txtMail.Text.ToString().Trim() + ")"; //+ "," + this.ProfilePic.ToString().Trim() + ")";

            connection.fCreateCommand(strInsert + " " + strValues);
        }




        private void Contacts_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dB_KTKDataSet.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kontakteTableAdapter.Fill(this.dB_KTKDataSet.Kontakte);

        }

        private void fClear()
        {
            this.txtName.Text = "";
            this.txtVorname.Text = "";
            this.txtAnschrift.Text = "";
            this.txtTelefon.Text = "";
            this.txtMail.Text = "";
        }

       
    }
}
