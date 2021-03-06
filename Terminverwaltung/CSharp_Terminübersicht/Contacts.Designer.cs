﻿namespace CSharp_Terminübersicht
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
            this.components = new System.ComponentModel.Container();
            this.vorname = new System.Windows.Forms.Label();
            this.anschrift = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.Label();
            this.kontaktdaten = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtAnschrift = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.nachname = new System.Windows.Forms.Label();
            this.Contactdate = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKTK_Key = new System.Windows.Forms.TextBox();
            this.dB_TermineDataSet = new CSharp_Terminübersicht.DB_TermineDataSet();
            this.kontakteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontakteTableAdapter = new CSharp_Terminübersicht.DB_TermineDataSetTableAdapters.KontakteTableAdapter();
            this.kTKKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kTKNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kTKVornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kTKAnschriftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kTKTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kTKEMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.Contactdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TermineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteBindingSource)).BeginInit();
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
            this.anschrift.Size = new System.Drawing.Size(57, 13);
            this.anschrift.TabIndex = 2;
            this.anschrift.Text = "Anschrift";
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
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(69, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorname.Location = new System.Drawing.Point(69, 51);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(151, 22);
            this.txtVorname.TabIndex = 8;
            // 
            // txtAnschrift
            // 
            this.txtAnschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnschrift.Location = new System.Drawing.Point(69, 77);
            this.txtAnschrift.Multiline = true;
            this.txtAnschrift.Name = "txtAnschrift";
            this.txtAnschrift.Size = new System.Drawing.Size(151, 130);
            this.txtAnschrift.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(390, 25);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(163, 22);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(390, 51);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(163, 22);
            this.txtMail.TabIndex = 11;
            // 
            // ProfilePic
            // 
            this.ProfilePic.Location = new System.Drawing.Point(391, 79);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(124, 139);
            this.ProfilePic.TabIndex = 12;
            this.ProfilePic.TabStop = false;
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
            this.Contactdate.Controls.Add(this.ProfilePic);
            this.Contactdate.Controls.Add(this.anschrift);
            this.Contactdate.Controls.Add(this.txtMail);
            this.Contactdate.Controls.Add(this.txtName);
            this.Contactdate.Controls.Add(this.txtTelefon);
            this.Contactdate.Controls.Add(this.txtVorname);
            this.Contactdate.Controls.Add(this.txtAnschrift);
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
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.save.Location = new System.Drawing.Point(276, 487);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 40);
            this.save.TabIndex = 16;
            this.save.Text = "Speichern";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kTKKeyDataGridViewTextBoxColumn,
            this.kTKNameDataGridViewTextBoxColumn,
            this.kTKVornameDataGridViewTextBoxColumn,
            this.kTKAnschriftDataGridViewTextBoxColumn,
            this.kTKTelefonDataGridViewTextBoxColumn,
            this.kTKEMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontakteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 126);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtKTK_Key
            // 
            this.txtKTK_Key.Location = new System.Drawing.Point(461, 498);
            this.txtKTK_Key.Name = "txtKTK_Key";
            this.txtKTK_Key.Size = new System.Drawing.Size(100, 20);
            this.txtKTK_Key.TabIndex = 18;
            this.txtKTK_Key.Visible = false;
            // 
            // dB_TermineDataSet
            // 
            this.dB_TermineDataSet.DataSetName = "DB_TermineDataSet";
            this.dB_TermineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontakteBindingSource
            // 
            this.kontakteBindingSource.DataMember = "Kontakte";
            this.kontakteBindingSource.DataSource = this.dB_TermineDataSet;
            // 
            // kontakteTableAdapter
            // 
            this.kontakteTableAdapter.ClearBeforeFill = true;
            // 
            // kTKKeyDataGridViewTextBoxColumn
            // 
            this.kTKKeyDataGridViewTextBoxColumn.DataPropertyName = "KTK_Key";
            this.kTKKeyDataGridViewTextBoxColumn.HeaderText = "KTK_Key";
            this.kTKKeyDataGridViewTextBoxColumn.Name = "kTKKeyDataGridViewTextBoxColumn";
            this.kTKKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // kTKNameDataGridViewTextBoxColumn
            // 
            this.kTKNameDataGridViewTextBoxColumn.DataPropertyName = "KTK_Name";
            this.kTKNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.kTKNameDataGridViewTextBoxColumn.Name = "kTKNameDataGridViewTextBoxColumn";
            this.kTKNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // kTKVornameDataGridViewTextBoxColumn
            // 
            this.kTKVornameDataGridViewTextBoxColumn.DataPropertyName = "KTK_Vorname";
            this.kTKVornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.kTKVornameDataGridViewTextBoxColumn.Name = "kTKVornameDataGridViewTextBoxColumn";
            this.kTKVornameDataGridViewTextBoxColumn.Width = 125;
            // 
            // kTKAnschriftDataGridViewTextBoxColumn
            // 
            this.kTKAnschriftDataGridViewTextBoxColumn.DataPropertyName = "KTK_Anschrift";
            this.kTKAnschriftDataGridViewTextBoxColumn.HeaderText = "Anschrift";
            this.kTKAnschriftDataGridViewTextBoxColumn.Name = "kTKAnschriftDataGridViewTextBoxColumn";
            this.kTKAnschriftDataGridViewTextBoxColumn.Width = 125;
            // 
            // kTKTelefonDataGridViewTextBoxColumn
            // 
            this.kTKTelefonDataGridViewTextBoxColumn.DataPropertyName = "KTK_Telefon";
            this.kTKTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.kTKTelefonDataGridViewTextBoxColumn.Name = "kTKTelefonDataGridViewTextBoxColumn";
            this.kTKTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // kTKEMailDataGridViewTextBoxColumn
            // 
            this.kTKEMailDataGridViewTextBoxColumn.DataPropertyName = "KTK_EMail";
            this.kTKEMailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.kTKEMailDataGridViewTextBoxColumn.Name = "kTKEMailDataGridViewTextBoxColumn";
            this.kTKEMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 539);
            this.Controls.Add(this.txtKTK_Key);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Contactdate);
            this.Controls.Add(this.kontaktdaten);
            this.Name = "Contacts";
            this.Text = "Kontaktansicht";
            this.Load += new System.EventHandler(this.Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.Contactdate.ResumeLayout(false);
            this.Contactdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TermineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtAnschrift;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Label nachname;
        private System.Windows.Forms.GroupBox Contactdate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKTK_Key;
        private DB_TermineDataSet dB_TermineDataSet;
        private System.Windows.Forms.BindingSource kontakteBindingSource;
        private DB_TermineDataSetTableAdapters.KontakteTableAdapter kontakteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTKKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTKNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTKVornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTKAnschriftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTKTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTKEMailDataGridViewTextBoxColumn;
    }
}