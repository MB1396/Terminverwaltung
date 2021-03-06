﻿using System;
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
        OleDbCommand cmd;
        OleDbDataReader rder;


        public DateViewer()
        {
            InitializeComponent();
            fGetCurrWeek(DateTime.Now, true);
            fBuildView();
        }

        private void fBuildView()
        {
            DateTime DateAPT, resDate;
            int resTime;
            string DayTarget, PersonTarget;

            try
            {
                cmd = new OleDbCommand("     Select Termine.*, Kontakte.KTK_Name, Kontakte.KTK_Vorname " +
                                       "       From Termine " +
                                       " Inner Join Kontakte On Kontakte.KTK_Key = Termine.KTK_Key " +
                                       "      Where APT_dDate >= CDate('" + Convert.ToDateTime(this.txtdWeekStart.Text) + "') " +
                                       "        AND APT_dDate <= CDate('" + Convert.ToDateTime(this.txtdWeekEnd.Text) + "')", connection.getConn());
                //MessageBox.Show(cmd.CommandText.ToString());
                rder = cmd.ExecuteReader();

                //Beginnend bei 6, da Start bei 6.00 Uhr und Ende bei 24.00 Uhr
                for (int i = 6; i <= 24; i++)
                {
                    this.dgAppointment.Rows.Add(1);
                    this.dgAppointment.Rows[i - 6].Cells[0].Value = i.ToString("00") + ".00";
                }

                if (rder.HasRows)
                {
                    // Eintragen der Termine in die View
                    // Durchlaufen für jeden Datensatz
                    while (rder.Read())
                    {
                        for (int i = 6; i <= 24; i++)
                        {
                            DateAPT = rder.GetDateTime(2);
                            resDate = DateAPT.Date;
                            resTime = Convert.ToInt32(DateAPT.Hour);

                            //Wenn die Uhrzeit des eingetragenen Termins mit dem der Zeile übereinstimmt, kann der Termin gesetzt werden
                            if (resTime.ToString("00") == i.ToString("00"))
                            {
                                DayTarget = resDate.DayOfWeek.ToString();
                                PersonTarget = rder.GetValue(6).ToString() + ", " + rder.GetValue(7).ToString();
                                //Termin wird abhängig vom Wochentag gesetzt, damit die korrekte Spalte gewählt wird
                                switch (DayTarget)
                                {
                                    case "Montag":
                                    case "Monday":
                                        this.dgAppointment.Rows[i - 6].Cells[1].Value = PersonTarget;
                                        break;
                                    case "Dienstag":
                                    case "Tuesday":
                                        this.dgAppointment.Rows[i - 6].Cells[2].Value = PersonTarget;
                                        break;
                                    case "Mittwoch":
                                    case "Wednesday":
                                        this.dgAppointment.Rows[i - 6].Cells[3].Value = PersonTarget;
                                        break;
                                    case "Donnerstag":
                                    case "Thursday":
                                        this.dgAppointment.Rows[i - 6].Cells[4].Value = PersonTarget;
                                        break;
                                    case "Freitag":
                                    case "Friday":
                                        this.dgAppointment.Rows[i - 6].Cells[5].Value = PersonTarget;
                                        break;
                                    case "Samstag":
                                    case "Saturday":
                                        this.dgAppointment.Rows[i - 6].Cells[6].Value = PersonTarget;
                                        break;
                                    case "Sonntag":
                                    case "Sunday":
                                        this.dgAppointment.Rows[i - 6].Cells[7].Value = PersonTarget;
                                        break;
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fGetCurrWeek(DateTime pDate, Boolean CalcCurrentWeek)
        {
            DateTime Today, MondayOfWeek, SundayOfWeek;
            int FirstWeekDay;
            string DayToday;

            Today = pDate;
            DayToday = Today.DayOfWeek.ToString();

            if (CalcCurrentWeek == true)
            {
                //Die aktuelle Woche des Kalenders
                //Bleibt immer gleich
                this.txtCurrentWeek.Text = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Today,
                                                                                             CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule,
                                                                                             CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek).ToString();
            }
            // Die Woche, die auf dem Formular angezeigt wird
            // Wechselt mit Klick auf Woche weiter und Woche zurück
            this.txtActiveWeek.Text = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Today,
                                                                                        CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule,
                                                                                        CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek).ToString();

            /* Setzen der Datumswerte:
                   txtMondayOfWeek -> Montag der angezeigten Woche 
                   txtdWeekStart -> Startdatum der angezeigten Woche
                   txtdWeekEnd -> Enddatum der angezeigten Woche
                   lbldVon -> Woche geht von...
                   lbldBis -> Woche geht bis...
            */
            switch (DayToday)
            {
                case "Montag":
                case "Monday":
                    FirstWeekDay = Today.Date.Day;
                    MondayOfWeek = Today.Date;
                    SundayOfWeek = Today.AddDays(6);

                    this.txtMondayOfWeek.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekStart.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekEnd.Text = SundayOfWeek.ToString("dd.MM.yyyy");
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = SundayOfWeek.ToString("dd.MMMM yyyy");
                    break;
                case "Dienstag":
                case "Tuesday":
                    FirstWeekDay = Today.Date.AddDays(-1).Day;
                    MondayOfWeek = Today.Date.AddDays(-1);
                    SundayOfWeek = Today.Date.AddDays(5);

                    this.txtMondayOfWeek.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekStart.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekEnd.Text = SundayOfWeek.ToString("dd.MM.yyyy");
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = SundayOfWeek.ToString("dd.MMMM yyyy");
                    break;
                case "Mittwoch":
                case "Wednesday":
                    FirstWeekDay = Today.Date.AddDays(-2).Day;
                    MondayOfWeek = Today.Date.AddDays(-2);
                    SundayOfWeek = Today.Date.AddDays(4);

                    this.txtMondayOfWeek.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekStart.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekEnd.Text = SundayOfWeek.ToString("dd.MM.yyyy");
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = SundayOfWeek.ToString("dd.MMMM yyyy");
                    break;
                case "Donnerstag":
                case "Thursday":
                    FirstWeekDay = Today.Date.AddDays(-3).Day;
                    MondayOfWeek = Today.Date.AddDays(-3);
                    SundayOfWeek = Today.Date.AddDays(3);

                    this.txtMondayOfWeek.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekStart.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekEnd.Text = SundayOfWeek.ToString("dd.MM.yyyy");
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = SundayOfWeek.ToString("dd.MMMM yyyy");
                    break;
                case "Freitag":
                case "Friday":
                    FirstWeekDay = Today.Date.AddDays(-4).Day;
                    MondayOfWeek = Today.Date.AddDays(-4);
                    SundayOfWeek = Today.Date.AddDays(2);

                    this.txtMondayOfWeek.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekStart.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekEnd.Text = SundayOfWeek.ToString("dd.MM.yyyy");
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = SundayOfWeek.ToString("dd.MMMM yyyy");
                    break;
                case "Samstag":
                case "Saturday":
                    FirstWeekDay = Today.Date.AddDays(-5).Day;
                    MondayOfWeek = Today.Date.AddDays(-5);
                    SundayOfWeek = Today.Date.AddDays(1);

                    this.txtMondayOfWeek.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekStart.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekEnd.Text = SundayOfWeek.ToString("dd.MM.yyyy");
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = SundayOfWeek.ToString("dd.MMMM yyyy");
                    break;
                case "Sonntag":
                case "Sunday":
                    FirstWeekDay = Today.Date.AddDays(-6).Day;
                    MondayOfWeek = Today.Date.AddDays(-6);
                    SundayOfWeek = Today.Date;

                    this.txtMondayOfWeek.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekStart.Text = MondayOfWeek.ToString("dd.MM.yyyy");
                    this.txtdWeekEnd.Text = SundayOfWeek.ToString("dd.MM.yyyy");
                    this.lbldVon.Text = Convert.ToString(FirstWeekDay + ".");
                    this.lbldBis.Text = SundayOfWeek.ToString("dd.MMMM yyyy");
                    break;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnNext control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Aktualisieren des DataGrids anhand der neuen Woche
            DateTime CurrentMonday = Convert.ToDateTime(this.txtMondayOfWeek.Text);
            fGetCurrWeek(CurrentMonday.Date.AddDays(7), false);

            for (int i = 0; i < 19; i++)
            {
                //Aktuelle Zeilen entfernen, da sonst irgendwann eine Endlosliste entsteht...
                this.dgAppointment.Rows.RemoveAt(0);
            }
            fClear();
            //View neu aufbauen
            fBuildView();
        }

        private void btnShowCurrentWeek_Click(object sender, EventArgs e)
        {
            // Aktualisieren des DataGrids anhand der neuen Woche
            DateTime CurrentMonday = DateTime.Now;
            fGetCurrWeek(CurrentMonday.Date, false);

            for (int i = 0; i < 19; i++)
            {
                //Aktuelle Zeilen entfernen, da sonst irgendwann eine Endlosliste entsteht...
                this.dgAppointment.Rows.RemoveAt(0);
            }
            fClear();
            //View neu aufbauen
            fBuildView();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Aktualisieren des DataGrids anhand der neuen Woche
            DateTime CurrentMonday = Convert.ToDateTime(this.txtMondayOfWeek.Text);
            fGetCurrWeek(CurrentMonday.Date.AddDays(-7), false);

            for (int i = 0; i < 19; i++)
            {
                //Aktuelle Zeilen entfernen, da sonst irgendwann eine Endlosliste entsteht...
                this.dgAppointment.Rows.RemoveAt(0);
            }
            fClear();
            //View neu aufbauen
            fBuildView();

        }
        //private void dgAppointment_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        this.lblTitel.Text = "-";
        //    }
        //}

        private void dgAppointment_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DateTime CurrentMonday = Convert.ToDateTime(this.txtMondayOfWeek.Text);
            //DateTime Cellday = CurrentMonday.Date.AddDays(e.ColumnIndex -1);

            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && e.ColumnIndex > 0)
            //{
            //    //lblKTK, txtAPTDesc
            //    this.lblTitel.Text = Convert.ToString(dgAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //    this.lblDate.Text = Cellday.ToString("dd.MM.yyyy");
            //    this.lblTime.Text = Convert.ToString(dgAppointment.Rows[e.RowIndex].Cells[0].Value) + " Uhr";
            //    //this.lblKTK.Text = 
            //    this.txtAPTDesc.Text = "";
            //}
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            //{
            //    this.lblTitel.Text = "-";
            //    this.lblDate.Text = "-";
            //    this.lblTime.Text = "-";
            //}
        }

        private void dgAppointment_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string[] KTKtmp;
            string strSQLPRS, strSQLAPT, time, tmpVal;
            DateTime date, MondayOfWeek = Convert.ToDateTime(this.txtMondayOfWeek.Text), tmpDate;
            int KTK_Key = 0;
            OleDbCommand cmdFI;
            OleDbDataReader rderFI;

            try
            {
                if (dgAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "")
                {
                    KTKtmp = dgAppointment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Split(',');
                    KTKtmp[0] = KTKtmp[0].Trim();
                    KTKtmp[1] = KTKtmp[1].Trim();

                    strSQLPRS = "Select KTK_Key From Kontakte Where KTK_Vorname Like '" + KTKtmp[1] + "' AND KTK_Name Like '" + KTKtmp[0] + "'";
                    //MessageBox.Show(strSQLPRS);
                    cmdFI = new OleDbCommand(strSQLPRS, connection.getConn()); 

                    rderFI = cmdFI.ExecuteReader();
                    while (rderFI.Read())
                    { KTK_Key = Convert.ToInt32(rderFI.GetValue(0)); }

                    rderFI.Close();

                    if(KTK_Key > 0)
                    {
                        date = MondayOfWeek.Date.AddDays(e.ColumnIndex -1);
                        time = dgAppointment.Rows[e.RowIndex].Cells[0].Value.ToString();
                        strSQLAPT = " Select APT_Key, APT_dDate, APT_Note " + 
                                    "   From Termine " + 
                                    "  Where KTK_Key = " + KTK_Key + 
                                    "    AND APT_dDate = CDate('" + Convert.ToDateTime(date.AddHours(Convert.ToInt32(time.Substring(0, 2)))) + "')";
                        cmdFI = new OleDbCommand(strSQLAPT, connection.getConn());
                        rderFI = cmdFI.ExecuteReader();

                        while(rderFI.Read())
                        {
                            this.lblTitel.Text = "Termin für " + KTKtmp[0] + ", " + KTKtmp[1];
                            this.lblDate.Text = rderFI.GetValue(1).ToString().Substring(0, 10);
                            this.lblTime.Text = rderFI.GetValue(1).ToString().Substring(11, 5) + " Uhr";
                            this.lblKTK.Text = KTKtmp[0] + ", " + KTKtmp[1];
                            this.txtAPTDesc.Text = rderFI.GetValue(2).ToString();

                            this.txtAPT_Key.Text = rderFI.GetValue(0).ToString();
                            this.txtKTK_KeyForAPT.Text = KTK_Key.ToString();
                        }
                        
                    }
                    else
                    {
                        throw new ArgumentNullException("Person mit dem Key '" + KTK_Key.ToString() + "' nicht gefunden");
                    }
                }
                else
                {
                    fClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void fClear()
        {
            this.lblTitel.Text = ".";
            this.lblDate.Text = ".";
            this.lblTime.Text = ".";
            this.lblKTK.Text = ".";
            this.txtAPTDesc.Text = "";
        }

    }
}