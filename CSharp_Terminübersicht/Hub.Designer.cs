namespace CSharp_Terminübersicht
{
    partial class hub
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
            this.contacts = new System.Windows.Forms.Button();
            this.dateview = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contacts
            // 
            this.contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.contacts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.contacts.Location = new System.Drawing.Point(69, 52);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(246, 63);
            this.contacts.TabIndex = 0;
            this.contacts.Text = "Kontaktdaten";
            this.contacts.UseVisualStyleBackColor = true;
            this.contacts.Click += new System.EventHandler(this.contacts_Click);
            // 
            // dateview
            // 
            this.dateview.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dateview.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateview.Location = new System.Drawing.Point(69, 146);
            this.dateview.Name = "dateview";
            this.dateview.Size = new System.Drawing.Size(246, 63);
            this.dateview.TabIndex = 1;
            this.dateview.Text = "Terminansicht";
            this.dateview.UseVisualStyleBackColor = true;
            this.dateview.Click += new System.EventHandler(this.dateview_Click);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.end.Location = new System.Drawing.Point(207, 326);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(167, 54);
            this.end.TabIndex = 2;
            this.end.Text = "Ende";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 408);
            this.Controls.Add(this.end);
            this.Controls.Add(this.dateview);
            this.Controls.Add(this.contacts);
            this.Name = "hub";
            this.Text = "Terminverwaltung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contacts;
        private System.Windows.Forms.Button dateview;
        private System.Windows.Forms.Button end;
    }
}