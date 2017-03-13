using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CSharp_Terminübersicht
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DBConnect connection = new DBConnect();

            //OleDbConnection dbConnect = null;
            //bool dbOpen = false;
            //string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory.ToString() + @"\DB_Termine.accdb";

            //dbConnect = new OleDbConnection(strCon);
            //dbConnect.Open();
            //dbOpen = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new hub());

        }
    }
}
