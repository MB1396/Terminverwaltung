using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb;

namespace CSharp_Terminübersicht
{
    public partial class DateViewer : Form
    {
        DBConnect connection = new DBConnect();

        public DateViewer()
        {
            InitializeComponent();
            fBuildView();
            fGetThisWeek();
        }






        private void fBuildView()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From Termine Where APT_dDate Between " , connection.getConn());
            for (int i = 6; i <= 24; i++)
            {
                this.dgAppointment.Rows.Add(1);
                this.dgAppointment.Rows[i - 6].Cells[0].Value = i.ToString("00") + ".00";
            }
        }

        private void fGetThisWeek()
        {
            DateTime Today;
            int FirstWeekDay;
            string DayToday;

            Today = DateTime.Now.Date;
            DayToday = Today.DayOfWeek.ToString();
            //Die aktuelle Woche des Kalenders
            this.txtCurrentWeek.Text = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, 
                                                                                         CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, 
                                                                                         CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek).ToString();
            // Die Woche, die auf dem Formular angezeigt wird
            this.txtActiveWeek.Text = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now,
                                                                                        CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule,
                                                                                        CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek).ToString();

            
            switch (DayToday)
            {
                case "Montag":
                case "Monday":
                    FirstWeekDay = DateTime.Now.Date.Day;
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = DateTime.Now.AddDays(6).ToString("dd.MMMM yyyy");
                    break;
                case "Dienstag":
                case "Tuesday":
                    FirstWeekDay = DateTime.Now.Date.AddDays(-1).Day;
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = DateTime.Now.AddDays(5).ToString("dd.MMMM yyyy");
                    break;
                case "Mittwoch":
                case "Wednesday":
                    FirstWeekDay = DateTime.Now.Date.AddDays(-2).Day;
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = DateTime.Now.AddDays(4).ToString("dd.MMMM yyyy");
                    break;
                case "Donnerstag":
                case "Thursday":
                    FirstWeekDay = DateTime.Now.Date.AddDays(-3).Day;
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = DateTime.Now.AddDays(3).ToString("dd.MMMM yyyy");
                    break;
                case "Freitag":
                case "Friday":
                    FirstWeekDay = DateTime.Now.Date.AddDays(-4).Day;
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = DateTime.Now.AddDays(2).ToString("dd.MMMM yyyy");
                    break;
                case "Samstag":
                case "Saturday":
                    FirstWeekDay = DateTime.Now.Date.AddDays(-5).Day;
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = DateTime.Now.AddDays(1).ToString("dd.MMMM yyyy");
                    break;
                case "Sonntag":
                case "Sunday":
                    FirstWeekDay = DateTime.Now.Date.AddDays(-6).Day;
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = DateTime.Now.Date.ToString("dd.MMMM yyyy");
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //int iActiveWeek = Convert.ToInt32(this.txtActiveWeek.Text);


        }
    }
}
