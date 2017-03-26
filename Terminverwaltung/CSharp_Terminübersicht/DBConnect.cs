
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
                Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Castiel\Source\Repos\Terminverwaltung\Terminverwaltung\CSharp_Terminübersicht\DB_Termine.accdb");
                //Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PGörtz.BKH\Source\Repos\Terminverwaltung\Terminverwaltung\CSharp_Terminübersicht\DB_Termine.accdb");
                
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
            OleDbCommand Command = new OleDbCommand();
            Command = Connection.CreateCommand();
            Command.CommandText = cmd;
            int tmp = 0;

            try
            {
                //MessageBox.Show(Connection.State.ToString());
                if (dbOpen == true)
                {
                    tmp = Command.ExecuteNonQuery();
                }
                if (tmp > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}