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
        DBConnect connection = new DBConnect();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public Contacts()
        {
            InitializeComponent();
            this.txtName.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string strInsert = "", strValues = "";
            Boolean fSuccess = false;
            
            
            strInsert = "Insert Into Kontakte (KTK_Name, KTK_Vorname, KTK_Anschrift, KTK_Telefon, KTK_EMail )";
            strValues = fCheckFields(); //"Values (" + this.txtName.Text.ToString().Trim() + "," + 
                                     //this.txtVorname.Text.ToString().Trim() + "," + 
                                     //this.txtAnschrift.Text.ToString().Trim() + "," +
                                     //this.txtTelefon.Text.ToString().Trim() + "," + 
                                     //this.txtMail.Text.ToString().Trim() + ")";        //+ "," + this.ProfilePic.ToString().Trim() + ")";

            fSuccess = connection.fCreateCommand(strInsert + " " + strValues);
            if (fSuccess == true)
            {
                try
                {
                    //SqlCommand cmd = new SqlCommand("Select * From Kontakte", connection.getConn());
                    //DataTable tbl = new DataTable();
                    //adapter.Fill(tbl);

                    //BindingSource bs = new BindingSource();
                    //bs.DataSource = tbl;
                    //dataGridView1.DataSource = bs;

                    //this.kontakteTableAdapter.Fill(this.dB_TermineDataSet.Kontakte);
                    this.kontakteTableAdapter.Update(this.dB_TermineDataSet);

                    
                    //DataTable tbl = dB_TermineDataSet.Tables["Kontakte"];
                    //dataGridView1.DataSource = adapter.Update(tbl.Select(null, null, DataViewRowState.Added));
                    fClear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }




        private void Contacts_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dB_TermineDataSet.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kontakteTableAdapter.Fill(this.dB_TermineDataSet.Kontakte);

            // TODO: Diese Codezeile lädt Daten in die Tabelle "dB_KTKDS321.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.kontakteTableAdapter1.Fill(this.dB_KTKDS321.Kontakte);
        }

        private void fClear()
        {
            this.txtName.Text = "";
            this.txtVorname.Text = "";
            this.txtAnschrift.Text = "";
            this.txtTelefon.Text = "";
            this.txtMail.Text = "";
        }

        private string fCheckFields()
        {
            string name, vorname, anschrift, telefon, mail;

            if (this.txtName.Text == "")
                name = "";
            else
                name = this.txtName.Text.ToString().Trim();

            if (this.txtVorname.Text == "")
                vorname = "";
            else
                vorname = this.txtVorname.Text.ToString().Trim();

            if (this.txtAnschrift.Text == "")
                anschrift = "";
            else
                anschrift = this.txtAnschrift.Text.ToString().Trim();

            if (this.txtTelefon.Text == "")
                telefon = "";
            else
                telefon = this.txtTelefon.Text.ToString().Trim();

            if (this.txtMail.Text == "")
                mail = "";
            else
                mail = this.txtMail.Text.ToString().Trim();

            return "VALUES ('" + name + "','" + vorname + "','" + anschrift + "','" + telefon + "','" + mail + "');";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //OleDbCommand cmd = new OleDbCommand();
            //OleDbDataReader rde;
            //cmd.CommandText = "Select * From Kontakte Where KTK_Key = " + dataGridView1.Rows[e.RowIndex].Cells["KTK_Key"].Value;

            //rde = cmd.ExecuteReader();
            //while (rde.Read())
            //{
            //    this.txtName.Text = rde.GetString(1);
            //    this.txtVorname.Text = rde.GetString(2);
            //    this.txtAnschrift.Text = rde.GetString(3);
            //    this.txtTelefon.Text = rde.GetString(4);
            //    this.txtMail.Text = rde.GetString(5);
            //}

            
        }
       
    }
}
