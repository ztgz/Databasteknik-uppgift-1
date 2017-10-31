namespace Uppgift1
{
    partial class AdressBook
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
            this.PersonsDataGridView = new System.Windows.Forms.DataGridView();
            this.DataLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ÖvrigRadioBTN = new System.Windows.Forms.RadioButton();
            this.PersonligRadioBTN = new System.Windows.Forms.RadioButton();
            this.JobbRadioBTN = new System.Windows.Forms.RadioButton();
            this.AllaRadioBtn = new System.Windows.Forms.RadioButton();
            this.UppdateraTabelBTN = new System.Windows.Forms.Button();
            this.AddPersonBTN = new System.Windows.Forms.Button();
            this.AdressWindowBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.TelefonBTN = new System.Windows.Forms.Button();
            this.removeContactBTN = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonsDataGridView
            // 
            this.PersonsDataGridView.AllowUserToAddRows = false;
            this.PersonsDataGridView.AllowUserToDeleteRows = false;
            this.PersonsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsDataGridView.Location = new System.Drawing.Point(95, 154);
            this.PersonsDataGridView.Name = "PersonsDataGridView";
            this.PersonsDataGridView.RowTemplate.Height = 24;
            this.PersonsDataGridView.Size = new System.Drawing.Size(1052, 298);
            this.PersonsDataGridView.TabIndex = 0;
            this.PersonsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.PersonsDataGridView_CellBeginEdit);
            this.PersonsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonsDataGridView_CellClick);
            this.PersonsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonsDataGridView_CellEndEdit);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabel.Location = new System.Drawing.Point(95, 105);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(79, 32);
            this.DataLabel.TabIndex = 1;
            this.DataLabel.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ÖvrigRadioBTN);
            this.panel1.Controls.Add(this.PersonligRadioBTN);
            this.panel1.Controls.Add(this.JobbRadioBTN);
            this.panel1.Controls.Add(this.AllaRadioBtn);
            this.panel1.Location = new System.Drawing.Point(1166, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 127);
            this.panel1.TabIndex = 2;
            // 
            // ÖvrigRadioBTN
            // 
            this.ÖvrigRadioBTN.AutoSize = true;
            this.ÖvrigRadioBTN.Location = new System.Drawing.Point(3, 84);
            this.ÖvrigRadioBTN.Name = "ÖvrigRadioBTN";
            this.ÖvrigRadioBTN.Size = new System.Drawing.Size(63, 21);
            this.ÖvrigRadioBTN.TabIndex = 3;
            this.ÖvrigRadioBTN.TabStop = true;
            this.ÖvrigRadioBTN.Text = "Övrig";
            this.ÖvrigRadioBTN.UseVisualStyleBackColor = true;
            this.ÖvrigRadioBTN.CheckedChanged += new System.EventHandler(this.UppdateraTabelBTN_Click);
            // 
            // PersonligRadioBTN
            // 
            this.PersonligRadioBTN.AutoSize = true;
            this.PersonligRadioBTN.Location = new System.Drawing.Point(3, 54);
            this.PersonligRadioBTN.Name = "PersonligRadioBTN";
            this.PersonligRadioBTN.Size = new System.Drawing.Size(88, 21);
            this.PersonligRadioBTN.TabIndex = 2;
            this.PersonligRadioBTN.TabStop = true;
            this.PersonligRadioBTN.Text = "Personlig";
            this.PersonligRadioBTN.UseVisualStyleBackColor = true;
            this.PersonligRadioBTN.CheckedChanged += new System.EventHandler(this.UppdateraTabelBTN_Click);
            // 
            // JobbRadioBTN
            // 
            this.JobbRadioBTN.AutoSize = true;
            this.JobbRadioBTN.Location = new System.Drawing.Point(3, 27);
            this.JobbRadioBTN.Name = "JobbRadioBTN";
            this.JobbRadioBTN.Size = new System.Drawing.Size(60, 21);
            this.JobbRadioBTN.TabIndex = 1;
            this.JobbRadioBTN.TabStop = true;
            this.JobbRadioBTN.Text = "Jobb";
            this.JobbRadioBTN.UseVisualStyleBackColor = true;
            this.JobbRadioBTN.CheckedChanged += new System.EventHandler(this.UppdateraTabelBTN_Click);
            // 
            // AllaRadioBtn
            // 
            this.AllaRadioBtn.AutoSize = true;
            this.AllaRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.AllaRadioBtn.Name = "AllaRadioBtn";
            this.AllaRadioBtn.Size = new System.Drawing.Size(52, 21);
            this.AllaRadioBtn.TabIndex = 0;
            this.AllaRadioBtn.TabStop = true;
            this.AllaRadioBtn.Text = "Alla";
            this.AllaRadioBtn.UseVisualStyleBackColor = true;
            this.AllaRadioBtn.CheckedChanged += new System.EventHandler(this.UppdateraTabelBTN_Click);
            // 
            // UppdateraTabelBTN
            // 
            this.UppdateraTabelBTN.Location = new System.Drawing.Point(1166, 380);
            this.UppdateraTabelBTN.Name = "UppdateraTabelBTN";
            this.UppdateraTabelBTN.Size = new System.Drawing.Size(93, 72);
            this.UppdateraTabelBTN.TabIndex = 3;
            this.UppdateraTabelBTN.Text = "Uppdatera Tabell";
            this.UppdateraTabelBTN.UseVisualStyleBackColor = true;
            this.UppdateraTabelBTN.Click += new System.EventHandler(this.UppdateraTabelBTN_Click);
            // 
            // AddPersonBTN
            // 
            this.AddPersonBTN.Location = new System.Drawing.Point(870, 89);
            this.AddPersonBTN.Name = "AddPersonBTN";
            this.AddPersonBTN.Size = new System.Drawing.Size(115, 58);
            this.AddPersonBTN.TabIndex = 4;
            this.AddPersonBTN.Text = "Skapa Kontakt";
            this.AddPersonBTN.UseVisualStyleBackColor = true;
            this.AddPersonBTN.Click += new System.EventHandler(this.AddPersonBTN_Click);
            // 
            // AdressWindowBTN
            // 
            this.AdressWindowBTN.Location = new System.Drawing.Point(581, 90);
            this.AdressWindowBTN.Name = "AdressWindowBTN";
            this.AdressWindowBTN.Size = new System.Drawing.Size(114, 53);
            this.AdressWindowBTN.TabIndex = 5;
            this.AdressWindowBTN.Text = "Adresser";
            this.AdressWindowBTN.UseVisualStyleBackColor = true;
            this.AdressWindowBTN.Click += new System.EventHandler(this.AdressWindowBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(427, 88);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(114, 57);
            this.SearchBTN.TabIndex = 6;
            this.SearchBTN.Text = "Sök";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // TelefonBTN
            // 
            this.TelefonBTN.Location = new System.Drawing.Point(726, 90);
            this.TelefonBTN.Name = "TelefonBTN";
            this.TelefonBTN.Size = new System.Drawing.Size(114, 56);
            this.TelefonBTN.TabIndex = 7;
            this.TelefonBTN.Text = "Telefon";
            this.TelefonBTN.UseVisualStyleBackColor = true;
            this.TelefonBTN.Click += new System.EventHandler(this.TelefonBTN_Click);
            // 
            // removeContactBTN
            // 
            this.removeContactBTN.Location = new System.Drawing.Point(1031, 90);
            this.removeContactBTN.Name = "removeContactBTN";
            this.removeContactBTN.Size = new System.Drawing.Size(116, 57);
            this.removeContactBTN.TabIndex = 8;
            this.removeContactBTN.Text = "Ta bort kontakt";
            this.removeContactBTN.UseVisualStyleBackColor = true;
            this.removeContactBTN.Click += new System.EventHandler(this.removeContactBTN_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Uppgift1.Models.Person);
            // 
            // AdressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 520);
            this.Controls.Add(this.removeContactBTN);
            this.Controls.Add(this.TelefonBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.AdressWindowBTN);
            this.Controls.Add(this.AddPersonBTN);
            this.Controls.Add(this.UppdateraTabelBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.PersonsDataGridView);
            this.Name = "AdressBook";
            this.Text = "AdressBook";
            ((System.ComponentModel.ISupportInitialize)(this.PersonsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonsDataGridView;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton JobbRadioBTN;
        private System.Windows.Forms.RadioButton AllaRadioBtn;
        private System.Windows.Forms.RadioButton ÖvrigRadioBTN;
        private System.Windows.Forms.RadioButton PersonligRadioBTN;
        private System.Windows.Forms.Button UppdateraTabelBTN;
        private System.Windows.Forms.Button AddPersonBTN;
        private System.Windows.Forms.Button AdressWindowBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button TelefonBTN;
        private System.Windows.Forms.Button removeContactBTN;
    }
}

