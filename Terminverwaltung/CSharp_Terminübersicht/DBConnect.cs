using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CSharp_Terminübersicht
{
    public class DBConnect
    {
        public static OleDbConnection Connection;
        public Boolean dbOpen = false;

        public DBConnect()
        {
            try
            {
                Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory.ToString() + @"\DB_Termine.accdb");
                Connection.Open();
                dbOpen = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbOpen = false;
            }
        }

        public OleDbConnection getConn()
        {
            return Connection;
        }

        public void fCloseConnection()
        {
            if (Connection != null && dbOpen == true)
                Connection.Close();
        }





        public Boolean fCreateCommand(string cmd)
        {
            OleDbCommand Command = new OleDbCommand(cmd, getConn());

            try
            {
                if (dbOpen == true)
                {
                    OleDbDataReader Reader;
                    Reader = Command.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
    }
}
