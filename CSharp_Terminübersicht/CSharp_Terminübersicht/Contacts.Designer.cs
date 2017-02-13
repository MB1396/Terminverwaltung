namespace CSharp_Terminübersicht
{
    partial class Contacts
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
            this.vorname = new System.Windows.Forms.Label();
            this.anschrift = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.Label();
            this.kontaktdaten = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nachname = new System.Windows.Forms.Label();
            this.Contactdate = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Contactdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vorname
            // 
            this.vorname.AutoSize = true;
            this.vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vorname.Location = new System.Drawing.Point(12, 54);
            this.vorname.Name = "vorname";
            this.vorname.Size = new System.Drawing.Size(56, 13);
            this.vorname.TabIndex = 1;
            this.vorname.Text = "Vorname";
            // 
            // anschrift
            // 
            this.anschrift.AutoSize = true;
            this.anschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anschrift.Location = new System.Drawing.Point(12, 79);
            this.anschrift.Name = "anschrift";
            this.anschrift.Size = new System.Drawing.Size(52, 13);
            this.anschrift.TabIndex = 2;
            this.anschrift.Text = "Adresse";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(334, 28);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(50, 13);
            this.phone.TabIndex = 3;
            this.phone.Text = "Telefon";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(334, 54);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(42, 13);
            this.mail.TabIndex = 4;
            this.mail.Text = "E-Mail";
            // 
            // picture
            // 
            this.picture.AutoSize = true;
            this.picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture.Location = new System.Drawing.Point(334, 79);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(28, 13);
            this.picture.TabIndex = 5;
            this.picture.Text = "Bild";
            // 
            // kontaktdaten
            // 
            this.kontaktdaten.AutoSize = true;
            this.kontaktdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontaktdaten.Location = new System.Drawing.Point(13, 13);
            this.kontaktdaten.Name = "kontaktdaten";
            this.kontaktdaten.Size = new System.Drawing.Size(117, 20);
            this.kontaktdaten.TabIndex = 6;
            this.kontaktdaten.Text = "Kontaktdaten";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 77);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 130);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(390, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(390, 51);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 22);
            this.textBox5.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(391, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 139);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // nachname
            // 
            this.nachname.AutoSize = true;
            this.nachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nachname.Location = new System.Drawing.Point(12, 28);
            this.nachname.Name = "nachname";
            this.nachname.Size = new System.Drawing.Size(39, 13);
            this.nachname.TabIndex = 14;
            this.nachname.Text = "Name";
            // 
            // Contactdate
            // 
            this.Contactdate.Controls.Add(this.nachname);
            this.Contactdate.Controls.Add(this.vorname);
            this.Contactdate.Controls.Add(this.pictureBox1);
            this.Contactdate.Controls.Add(this.anschrift);
            this.Contactdate.Controls.Add(this.textBox5);
            this.Contactdate.Controls.Add(this.textBox1);
            this.Contactdate.Controls.Add(this.textBox4);
            this.Contactdate.Controls.Add(this.textBox2);
            this.Contactdate.Controls.Add(this.textBox3);
            this.Contactdate.Controls.Add(this.picture);
            this.Contactdate.Controls.Add(this.phone);
            this.Contactdate.Controls.Add(this.mail);
            this.Contactdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactdate.Location = new System.Drawing.Point(12, 181);
            this.Contactdate.Name = "Contactdate";
            this.Contactdate.Size = new System.Drawing.Size(665, 253);
            this.Contactdate.TabIndex = 15;
            this.Contactdate.TabStop = false;
            this.Contactdate.Text = "Kontaktdaten";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(295, 501);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(93, 26);
            this.save.TabIndex = 16;
            this.save.Text = "Speichern";
            this.save.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(9, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 126);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vorname";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adresse";
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "E-Mail";
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Contactdate);
            this.Controls.Add(this.kontaktdaten);
            this.Name = "Contacts";
            this.Text = "Kontaktansicht";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Contactdate.ResumeLayout(false);
            this.Contactdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vorname;
        private System.Windows.Forms.Label anschrift;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label picture;
        private System.Windows.Forms.Label kontaktdaten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nachname;
        private System.Windows.Forms.GroupBox Contactdate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}