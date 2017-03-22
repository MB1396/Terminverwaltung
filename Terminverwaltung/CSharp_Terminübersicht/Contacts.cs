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
            this.txtKTK_Key.Text = "0";
            fClear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Insert oder Update...
            string strInsert = "", strUpdate = "", strValues = "";

            Boolean fSuccess = false;
            OleDbDataAdapter adapter;
            DataTable DT = new DataTable();

            try
            {
               // Wenn die ID des Datensatzes größer 0 ist, wird ein Update gemacht
                if (Convert.ToInt32(this.txtKTK_Key.Text) > 0)
                {
                    fCheckFields(true);
                    strUpdate = "Update Kontakte " +
                                "   Set KTK_Name = '" + this.txtName.Text + "'," +
                                "       KTK_Vorname = '" + this.txtVorname.Text + "'," +
                                "       KTK_Anschrift = '" + this.txtAnschrift.Text + "'," +
                                "       KTK_Telefon = '" + this.txtTelefon.Text + "'," +
                                "       KTK_EMail = '" + this.txtMail.Text + "' " +
                    " Where KTK_Key = " + Convert.ToInt32(this.txtKTK_Key.Text);
                    fSuccess = connection.fCreateCommand(strUpdate);
                    if (fSuccess == true)
                    {
                        //Aktualisieren des Datagrids
                        adapter = new OleDbDataAdapter("Select * From Kontakte", connection.getConn());
                        adapter.Fill(DT);
                        this.dataGridView1.DataSource = DT;
                        this.dataGridView1.EndEdit();
                        this.dataGridView1.Refresh();
                        fClear();
                    }
                }
                else
                {
                    //Wenn die ID = 0 wird ein Insert gemacht
                    strInsert = "Insert Into Kontakte (KTK_Name, KTK_Vorname, KTK_Anschrift, KTK_Telefon, KTK_EMail )";
                    strValues = fCheckFields(false);

                    fSuccess = connection.fCreateCommand(strInsert + " " + strValues);
                    if (fSuccess == true)
                    {
                        adapter = new OleDbDataAdapter("Select * From Kontakte", connection.getConn());
                        adapter.Fill(DT);
                        this.dataGridView1.DataSource = DT;
                        this.dataGridView1.EndEdit();
                        this.dataGridView1.Refresh();
                        fClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            


        private void fClear()
        {
            //Zurücksetzen der Felder....
            this.txtName.Text = "";
            this.txtVorname.Text = "";
            this.txtAnschrift.Text = "";
            this.txtTelefon.Text = "";
            this.txtMail.Text = "";
            this.txtKTK_Key.Text = "0";
        }

        private string fCheckFields(Boolean bIsUpdate)
        {
            //Prüfen der Feldwerte - Regulär beim Ausführen eines SQLs
            string name, vorname, anschrift, telefon, mail;

            if (this.txtName.Text == "")
                name = " ";
            else
                name = this.txtName.Text.ToString().Trim();

            if (this.txtVorname.Text == "")
                vorname = " ";
            else
                vorname = this.txtVorname.Text.ToString().Trim();

            if (this.txtAnschrift.Text == "")
                anschrift = " ";
            else
                anschrift = this.txtAnschrift.Text.ToString().Trim();

            if (this.txtTelefon.Text == "")
                telefon = " ";
            else
                telefon = this.txtTelefon.Text.ToString().Trim();

            if (this.txtMail.Text == "")
                mail = " ";
            else
                mail = this.txtMail.Text.ToString().Trim();

            if (bIsUpdate == false)
                return "VALUES ('" + name + "','" + vorname + "','" + anschrift + "','" + telefon + "','" + mail + "');";
            else
            {
                this.txtName.Text = name;
                this.txtVorname.Text = vorname;
                this.txtAnschrift.Text = anschrift;
                this.txtTelefon.Text = telefon;
                this.txtMail.Text = mail;
                return "";
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Abfragen der Informationen aus der Datenbank und Anzeige im Form
            int tmpKey = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["kTKKeyDataGridViewTextBoxColumn"].Value);
            OleDbCommand cmd = new OleDbCommand("Select * From Kontakte Where KTK_Key = " + tmpKey, connection.getConn());
            OleDbDataReader reader;

            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                this.txtKTK_Key.Text = fCheckForVal(reader.GetValue(0).ToString());
                this.txtName.Text = fCheckForVal(reader.GetValue(1).ToString());
                this.txtVorname.Text = fCheckForVal(reader.GetValue(2).ToString());
                this.txtAnschrift.Text = fCheckForVal(reader.GetValue(3).ToString());
                this.txtTelefon.Text = fCheckForVal(reader.GetValue(4).ToString());
                this.txtMail.Text = fCheckForVal(reader.GetValue(5).ToString());
            }
        }

        private string fCheckForVal(String str)
        {
            // Prüfen ob ein Wert gefüllt ist...
            if (str == String.Empty )
            { return ""; }
            else
            { return str; }
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dB_TermineDataSet.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kontakteTableAdapter.Fill(this.dB_TermineDataSet.Kontakte);

        }
    }
}