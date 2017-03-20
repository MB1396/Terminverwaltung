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
        public Contacts()
        {
            InitializeComponent();
            this.txtName.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string strInsert = "", strValues = "";
            Boolean fSuccess = false;
            OleDbDataAdapter adapter;
            DataTable DT = new DataTable();
            


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
                    adapter = new OleDbDataAdapter("Select * From Kontakte", connection.getConn());
                    adapter.Fill(DT);
                    this.dataGridView1.DataSource = DT;
                    this.dataGridView1.EndEdit();
                    this.dataGridView1.Refresh();
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
            //int tmpKey;

            //tmpKey = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["KTK_Key"].Value);


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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // int tmpRow = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int tmpKey = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["kTKKeyDataGridViewTextBoxColumn"].Value);
            OleDbCommand cmd = new OleDbCommand("Select * From Kontakte Where KTK_Key = " + tmpKey, connection.getConn());
            OleDbDataReader reader;
            string result;
            //OleDbDataAdapter adapter = new OleDbDataAdapter();
            //adapter.SelectCommand = cmd;

            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                result = reader.GetString(1) + ";" + reader.GetString(2);
                MessageBox.Show(result);
                //this.txtName.Text = reader.GetString(1);
                //this.txtVorname.Text = reader.GetString(2);
                //this.txtAnschrift.Text = reader.GetString(3);
                //this.txtTelefon.Text = reader.GetString(4);
                //this.txtMail.Text = reader.GetString(5);
               // MessageBox.Show(result);
            }

            //this.txtName.Text

            //if (tmpRow > 0)
            //{
            //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //    for (int i = 0; i < tmpRow; i++)
            //    {
            //        sb.Append("Row: ");
            //        sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
            //        sb.Append(Environment.NewLine);
            //    }
            //}
        }

    }
}