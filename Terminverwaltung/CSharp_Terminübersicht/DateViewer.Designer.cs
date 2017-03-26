namespace CSharp_Terminübersicht
{
    partial class DateViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgAppointment = new System.Windows.Forms.DataGridView();
            this.cloTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloMontag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloDienstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloMittwoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloDonnerstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloFreitag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloSamstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloSonntag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAPT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAPTDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbldVon = new System.Windows.Forms.Label();
            this.lbldBis = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblKTK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentWeek = new System.Windows.Forms.TextBox();
            this.txtActiveWeek = new System.Windows.Forms.TextBox();
            this.txtdWeekStart = new System.Windows.Forms.TextBox();
            this.txtdWeekEnd = new System.Windows.Forms.TextBox();
            this.txtMondayOfWeek = new System.Windows.Forms.TextBox();
            this.btnShowCurrentWeek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAppointment
            // 
            this.dgAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cloTime,
            this.cloMontag,
            this.cloDienstag,
            this.cloMittwoch,
            this.cloDonnerstag,
            this.cloFreitag,
            this.cloSamstag,
            this.cloSonntag});
            this.dgAppointment.Location = new System.Drawing.Point(12, 12);
            this.dgAppointment.Name = "dgAppointment";
            this.dgAppointment.Size = new System.Drawing.Size(836, 462);
            this.dgAppointment.TabIndex = 0;
            // 
            // cloTime
            // 
            this.cloTime.HeaderText = "Zeit";
            this.cloTime.Name = "cloTime";
            this.cloTime.Width = 80;
            // 
            // cloMontag
            // 
            this.cloMontag.HeaderText = "Montag";
            this.cloMontag.Name = "cloMontag";
            // 
            // cloDienstag
            // 
            this.cloDienstag.HeaderText = "Dienstag";
            this.cloDienstag.Name = "cloDienstag";
            // 
            // cloMittwoch
            // 
            this.cloMittwoch.HeaderText = "Mittwoch";
            this.cloMittwoch.Name = "cloMittwoch";
            // 
            // cloDonnerstag
            // 
            this.cloDonnerstag.HeaderText = "Donnerstag";
            this.cloDonnerstag.Name = "cloDonnerstag";
            // 
            // cloFreitag
            // 
            this.cloFreitag.HeaderText = "Freitag";
            this.cloFreitag.Name = "cloFreitag";
            // 
            // cloSamstag
            // 
            this.cloSamstag.HeaderText = "Samstag";
            this.cloSamstag.Name = "cloSamstag";
            // 
            // cloSonntag
            // 
            this.cloSonntag.HeaderText = "Sonntag";
            this.cloSonntag.Name = "cloSonntag";
            // 
            // lblAPT
            // 
            this.lblAPT.AutoSize = true;
            this.lblAPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblAPT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAPT.Location = new System.Drawing.Point(861, 12);
            this.lblAPT.Name = "lblAPT";
            this.lblAPT.Size = new System.Drawing.Size(167, 29);
            this.lblAPT.TabIndex = 1;
            this.lblAPT.Text = "Termindetails:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(869, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Beschreibung";
            // 
            // txtAPTDesc
            // 
            this.txtAPTDesc.Location = new System.Drawing.Point(872, 241);
            this.txtAPTDesc.Multiline = true;
            this.txtAPTDesc.Name = "txtAPTDesc";
            this.txtAPTDesc.Size = new System.Drawing.Size(240, 233);
            this.txtAPTDesc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(43, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Terminübersicht für die Woche vom: ";
            // 
            // lbldVon
            // 
            this.lbldVon.AutoSize = true;
            this.lbldVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbldVon.Location = new System.Drawing.Point(281, 495);
            this.lbldVon.Name = "lbldVon";
            this.lbldVon.Size = new System.Drawing.Size(12, 17);
            this.lbldVon.TabIndex = 14;
            this.lbldVon.Text = ".";
            // 
            // lbldBis
            // 
            this.lbldBis.AutoSize = true;
            this.lbldBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbldBis.Location = new System.Drawing.Point(322, 495);
            this.lbldBis.Name = "lbldBis";
            this.lbldBis.Size = new System.Drawing.Size(12, 17);
            this.lbldBis.TabIndex = 15;
            this.lbldBis.Text = ".";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(642, 478);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 23);
            this.btnPrev.TabIndex = 16;
            this.btnPrev.Text = "Vorherige Woche";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(748, 478);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Nächste Woche";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(308, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "-";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime.Location = new System.Drawing.Point(963, 115);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(12, 17);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = ".";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(963, 88);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(12, 17);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = ".";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitel.Location = new System.Drawing.Point(963, 61);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(12, 17);
            this.lblTitel.TabIndex = 24;
            this.lblTitel.Text = ".";
            // 
            // lblKTK
            // 
            this.lblKTK.AutoSize = true;
            this.lblKTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblKTK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKTK.Location = new System.Drawing.Point(960, 159);
            this.lblKTK.Name = "lblKTK";
            this.lblKTK.Size = new System.Drawing.Size(12, 17);
            this.lblKTK.TabIndex = 23;
            this.lblKTK.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(869, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kontakt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(869, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Uhrzeit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(869, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(869, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Titel";
            // 
            // txtCurrentWeek
            // 
            this.txtCurrentWeek.Location = new System.Drawing.Point(872, 492);
            this.txtCurrentWeek.Name = "txtCurrentWeek";
            this.txtCurrentWeek.Size = new System.Drawing.Size(32, 20);
            this.txtCurrentWeek.TabIndex = 27;
            // 
            // txtActiveWeek
            // 
            this.txtActiveWeek.Location = new System.Drawing.Point(910, 492);
            this.txtActiveWeek.Name = "txtActiveWeek";
            this.txtActiveWeek.Size = new System.Drawing.Size(35, 20);
            this.txtActiveWeek.TabIndex = 28;
            // 
            // txtdWeekStart
            // 
            this.txtdWeekStart.Location = new System.Drawing.Point(1043, 480);
            this.txtdWeekStart.Name = "txtdWeekStart";
            this.txtdWeekStart.Size = new System.Drawing.Size(69, 20);
            this.txtdWeekStart.TabIndex = 29;
            // 
            // txtdWeekEnd
            // 
            this.txtdWeekEnd.Location = new System.Drawing.Point(1043, 502);
            this.txtdWeekEnd.Name = "txtdWeekEnd";
            this.txtdWeekEnd.Size = new System.Drawing.Size(69, 20);
            this.txtdWeekEnd.TabIndex = 30;
            // 
            // txtMondayOfWeek
            // 
            this.txtMondayOfWeek.Location = new System.Drawing.Point(977, 492);
            this.txtMondayOfWeek.Name = "txtMondayOfWeek";
            this.txtMondayOfWeek.Size = new System.Drawing.Size(60, 20);
            this.txtMondayOfWeek.TabIndex = 31;
            // 
            // btnShowCurrentWeek
            // 
            this.btnShowCurrentWeek.Location = new System.Drawing.Point(697, 504);
            this.btnShowCurrentWeek.Name = "btnShowCurrentWeek";
            this.btnShowCurrentWeek.Size = new System.Drawing.Size(100, 23);
            this.btnShowCurrentWeek.TabIndex = 32;
            this.btnShowCurrentWeek.Text = "Aktuelle Woche";
            this.btnShowCurrentWeek.UseVisualStyleBackColor = true;
            this.btnShowCurrentWeek.Click += new System.EventHandler(this.btnShowCurrentWeek_Click);
            // 
            // DateViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 534);
            this.Controls.Add(this.btnShowCurrentWeek);
            this.Controls.Add(this.txtMondayOfWeek);
            this.Controls.Add(this.txtdWeekEnd);
            this.Controls.Add(this.txtdWeekStart);
            this.Controls.Add(this.txtActiveWeek);
            this.Controls.Add(this.txtCurrentWeek);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblKTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lbldBis);
            this.Controls.Add(this.lbldVon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAPTDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAPT);
            this.Controls.Add(this.dgAppointment);
            this.Name = "DateViewer";
            this.Text = ".";
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloMontag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloDienstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloMittwoch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloDonnerstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloFreitag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloSamstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloSonntag;
        private System.Windows.Forms.Label lblAPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAPTDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbldVon;
        private System.Windows.Forms.Label lbldBis;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblKTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentWeek;
        private System.Windows.Forms.TextBox txtActiveWeek;
        private System.Windows.Forms.TextBox txtdWeekStart;
        private System.Windows.Forms.TextBox txtdWeekEnd;
        private System.Windows.Forms.TextBox txtMondayOfWeek;
        private System.Windows.Forms.Button btnShowCurrentWeek;
    }
}