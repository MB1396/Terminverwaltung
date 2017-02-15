using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CSharp_Terminübersicht
{
    public partial class Termin : Form
    {
        Hashtable HashAPT = new Hashtable();
        int cntAPT = 0;

        public Termin()
        {
            InitializeComponent();
            this.Text = "Terminverwaltung";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string values, uhrzeit;
            uhrzeit = fGetActiveRD();
            values = this.DTPicker.Text.ToString() + " " + this.txtAPTInfo.Text + " " + uhrzeit;
            HashAPT.Add(cntAPT, values);
            cntAPT++;
            fClear();
        }

        private string fGetActiveRD()
        {
            if (this.rd8.Checked)
                return "8.00 Uhr";
            if (this.rd9.Checked)
                return "9.00 Uhr";
            if (this.rd10.Checked)
                return "10.00 Uhr";
            if (this.rd11.Checked)
                return "11.00";
            if (this.rd12.Checked)
                return "12.00";
            if (this.rd13.Checked)
                return "13.00 Uhr";
            if (this.rd14.Checked)
                return "14.00 Uhr";
            if (this.rd15.Checked)
                return "15.00 Uhr";
            else
            {
                if(this.rdElse.Checked && this.txtElse.Text != "")
                {
                    return this.txtElse.Text + ".00" + " Uhr";
                }
                else
                {
                    return "Uhrzeit unbekannt";
                }
            }
        }

        private void fClear()
        {
            this.DTPicker.Value = DateTime.Now.Date;
            this.txtAPTInfo.Text = "";
            this.rd8.Checked = false;
            this.rd9.Checked = false;
            this.rd10.Checked = false;
            this.rd11.Checked = false;
            this.rd12.Checked = false;
            this.rd13.Checked = false;
            this.rd14.Checked = false;
            this.rd15.Checked = false;
            this.rdElse.Checked = false;
            this.txtElse.Text = "";
            this.lstAPT.Items.Clear();
            fRefresh();
        }

        private void fRefresh()
        {
            foreach(DictionaryEntry de in HashAPT)
            {
                this.lstAPT.Items.Add(de.Value);
            }
        }

        private void lstAPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAPTInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
