namespace CSharp_Terminübersicht
{
    partial class Termin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAPT_Caption = new System.Windows.Forms.Label();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAPTInfo = new System.Windows.Forms.TextBox();
            this.rd8 = new System.Windows.Forms.RadioButton();
            this.rd9 = new System.Windows.Forms.RadioButton();
            this.rd10 = new System.Windows.Forms.RadioButton();
            this.rd11 = new System.Windows.Forms.RadioButton();
            this.rd12 = new System.Windows.Forms.RadioButton();
            this.rd13 = new System.Windows.Forms.RadioButton();
            this.rd14 = new System.Windows.Forms.RadioButton();
            this.rd15 = new System.Windows.Forms.RadioButton();
            this.txtElse = new System.Windows.Forms.TextBox();
            this.rdElse = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstAPT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAPT_Caption
            // 
            this.lblAPT_Caption.AutoSize = true;
            this.lblAPT_Caption.Location = new System.Drawing.Point(13, 13);
            this.lblAPT_Caption.Name = "lblAPT_Caption";
            this.lblAPT_Caption.Size = new System.Drawing.Size(10, 13);
            this.lblAPT_Caption.TabIndex = 0;
            this.lblAPT_Caption.Text = ".";
            // 
            // DTPicker
            // 
            this.DTPicker.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPicker.Location = new System.Drawing.Point(16, 13);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(198, 20);
            this.DTPicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terminbeschreibung";
            // 
            // txtAPTInfo
            // 
            this.txtAPTInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAPTInfo.Location = new System.Drawing.Point(16, 80);
            this.txtAPTInfo.Multiline = true;
            this.txtAPTInfo.Name = "txtAPTInfo";
            this.txtAPTInfo.Size = new System.Drawing.Size(198, 169);
            this.txtAPTInfo.TabIndex = 3;
            this.txtAPTInfo.TextChanged += new System.EventHandler(this.txtAPTInfo_TextChanged);
            // 
            // rd8
            // 
            this.rd8.AutoSize = true;
            this.rd8.Location = new System.Drawing.Point(310, 57);
            this.rd8.Name = "rd8";
            this.rd8.Size = new System.Drawing.Size(66, 17);
            this.rd8.TabIndex = 4;
            this.rd8.TabStop = true;
            this.rd8.Text = "8.00 Uhr";
            this.rd8.UseVisualStyleBackColor = true;
            // 
            // rd9
            // 
            this.rd9.AutoSize = true;
            this.rd9.Location = new System.Drawing.Point(310, 80);
            this.rd9.Name = "rd9";
            this.rd9.Size = new System.Drawing.Size(66, 17);
            this.rd9.TabIndex = 5;
            this.rd9.TabStop = true;
            this.rd9.Text = "9.00 Uhr";
            this.rd9.UseVisualStyleBackColor = true;
            // 
            // rd10
            // 
            this.rd10.AutoSize = true;
            this.rd10.Location = new System.Drawing.Point(310, 103);
            this.rd10.Name = "rd10";
            this.rd10.Size = new System.Drawing.Size(72, 17);
            this.rd10.TabIndex = 6;
            this.rd10.TabStop = true;
            this.rd10.Text = "10.00 Uhr";
            this.rd10.UseVisualStyleBackColor = true;
            // 
            // rd11
            // 
            this.rd11.AutoSize = true;
            this.rd11.Location = new System.Drawing.Point(310, 126);
            this.rd11.Name = "rd11";
            this.rd11.Size = new System.Drawing.Size(72, 17);
            this.rd11.TabIndex = 7;
            this.rd11.TabStop = true;
            this.rd11.Text = "11.00 Uhr";
            this.rd11.UseVisualStyleBackColor = true;
            // 
            // rd12
            // 
            this.rd12.AutoSize = true;
            this.rd12.Location = new System.Drawing.Point(310, 149);
            this.rd12.Name = "rd12";
            this.rd12.Size = new System.Drawing.Size(72, 17);
            this.rd12.TabIndex = 8;
            this.rd12.TabStop = true;
            this.rd12.Text = "12.00 Uhr";
            this.rd12.UseVisualStyleBackColor = true;
            // 
            // rd13
            // 
            this.rd13.AutoSize = true;
            this.rd13.Location = new System.Drawing.Point(310, 172);
            this.rd13.Name = "rd13";
            this.rd13.Size = new System.Drawing.Size(72, 17);
            this.rd13.TabIndex = 9;
            this.rd13.TabStop = true;
            this.rd13.Text = "13.00 Uhr";
            this.rd13.UseVisualStyleBackColor = true;
            // 
            // rd14
            // 
            this.rd14.AutoSize = true;
            this.rd14.Location = new System.Drawing.Point(310, 195);
            this.rd14.Name = "rd14";
            this.rd14.Size = new System.Drawing.Size(72, 17);
            this.rd14.TabIndex = 10;
            this.rd14.TabStop = true;
            this.rd14.Text = "14.00 Uhr";
            this.rd14.UseVisualStyleBackColor = true;
            // 
            // rd15
            // 
            this.rd15.AutoSize = true;
            this.rd15.Location = new System.Drawing.Point(310, 218);
            this.rd15.Name = "rd15";
            this.rd15.Size = new System.Drawing.Size(72, 17);
            this.rd15.TabIndex = 11;
            this.rd15.TabStop = true;
            this.rd15.Text = "15.00 Uhr";
            this.rd15.UseVisualStyleBackColor = true;
            // 
            // txtElse
            // 
            this.txtElse.Location = new System.Drawing.Point(410, 240);
            this.txtElse.Name = "txtElse";
            this.txtElse.Size = new System.Drawing.Size(104, 20);
            this.txtElse.TabIndex = 13;
            // 
            // rdElse
            // 
            this.rdElse.AutoSize = true;
            this.rdElse.Location = new System.Drawing.Point(310, 241);
            this.rdElse.Name = "rdElse";
            this.rdElse.Size = new System.Drawing.Size(94, 17);
            this.rdElse.TabIndex = 14;
            this.rdElse.TabStop = true;
            this.rdElse.Text = "andere Uhrzeit";
            this.rdElse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 26);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstAPT
            // 
            this.lstAPT.FormattingEnabled = true;
            this.lstAPT.Location = new System.Drawing.Point(16, 310);
            this.lstAPT.Name = "lstAPT";
            this.lstAPT.Size = new System.Drawing.Size(497, 108);
            this.lstAPT.TabIndex = 16;
            this.lstAPT.SelectedIndexChanged += new System.EventHandler(this.lstAPT_SelectedIndexChanged);
            // 
            // frmAPT
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(548, 448);
            this.Controls.Add(this.lstAPT);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdElse);
            this.Controls.Add(this.txtElse);
            this.Controls.Add(this.rd15);
            this.Controls.Add(this.rd14);
            this.Controls.Add(this.rd13);
            this.Controls.Add(this.rd12);
            this.Controls.Add(this.rd11);
            this.Controls.Add(this.rd10);
            this.Controls.Add(this.rd9);
            this.Controls.Add(this.rd8);
            this.Controls.Add(this.txtAPTInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.lblAPT_Caption);
            this.Name = "frmAPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAPT_Caption;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAPTInfo;
        private System.Windows.Forms.RadioButton rd8;
        private System.Windows.Forms.RadioButton rd9;
        private System.Windows.Forms.RadioButton rd10;
        private System.Windows.Forms.RadioButton rd11;
        private System.Windows.Forms.RadioButton rd12;
        private System.Windows.Forms.RadioButton rd13;
        private System.Windows.Forms.RadioButton rd14;
        private System.Windows.Forms.RadioButton rd15;
        private System.Windows.Forms.TextBox txtElse;
        private System.Windows.Forms.RadioButton rdElse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstAPT;

    }
}

