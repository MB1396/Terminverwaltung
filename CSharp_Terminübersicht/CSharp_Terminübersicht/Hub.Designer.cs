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
            this.contacts.Location = new System.Drawing.Point(69, 52);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(246, 63);
            this.contacts.TabIndex = 0;
            this.contacts.Text = "Kontaktdaten";
            this.contacts.UseVisualStyleBackColor = true;
            // 
            // dateview
            // 
            this.dateview.Location = new System.Drawing.Point(69, 146);
            this.dateview.Name = "dateview";
            this.dateview.Size = new System.Drawing.Size(246, 63);
            this.dateview.TabIndex = 1;
            this.dateview.Text = "Terminansicht";
            this.dateview.UseVisualStyleBackColor = true;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(200, 319);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(174, 61);
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