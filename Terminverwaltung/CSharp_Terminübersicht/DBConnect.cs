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
        public string strCon = "";
        public Boolean dbOpen = false;

        public DBConnect()
        {
            strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory.ToString() + @"\DB_Termine.accdb";
            OleDbConnection Connection;

            Connection = new OleDbConnection(strCon);

            try
            {
                Connection.Open();
                dbOpen = true;
            }
            catch(Exception ex)
            {
                dbOpen = false;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
