namespace Uppgift1.UI
{
    partial class Adresser
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
            this.addresserDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PostNummerTextBox = new System.Windows.Forms.TextBox();
            this.GatuadressTextBox = new System.Windows.Forms.TextBox();
            this.PostortTextBox = new System.Windows.Forms.TextBox();
            this.AddAdressBTN = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.DeleteAdressBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.postnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatuadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addresserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addresserDataGridView
            // 
            this.addresserDataGridView.AllowUserToAddRows = false;
            this.addresserDataGridView.AllowUserToDeleteRows = false;
            this.addresserDataGridView.AutoGenerateColumns = false;
            this.addresserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addresserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postnummerDataGridViewTextBoxColumn,
            this.gatuadressDataGridViewTextBoxColumn,
            this.postortDataGridViewTextBoxColumn});
            this.addresserDataGridView.DataSource = this.adressBindingSource1;
            this.addresserDataGridView.Location = new System.Drawing.Point(13, 300);
            this.addresserDataGridView.Name = "addresserDataGridView";
            this.addresserDataGridView.ReadOnly = true;
            this.addresserDataGridView.RowTemplate.Height = 24;
            this.addresserDataGridView.Size = new System.Drawing.Size(856, 282);
            this.addresserDataGridView.TabIndex = 0;
            this.addresserDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.addresserDataGridView_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gatuadress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Postort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Postnummer:";
            // 
            // PostNummerTextBox
            // 
            this.PostNummerTextBox.Location = new System.Drawing.Point(111, 13);
            this.PostNummerTextBox.Name = "PostNummerTextBox";
            this.PostNummerTextBox.Size = new System.Drawing.Size(100, 22);
            this.PostNummerTextBox.TabIndex = 4;
            // 
            // GatuadressTextBox
            // 
            this.GatuadressTextBox.Location = new System.Drawing.Point(111, 45);
            this.GatuadressTextBox.Name = "GatuadressTextBox";
            this.GatuadressTextBox.Size = new System.Drawing.Size(100, 22);
            this.GatuadressTextBox.TabIndex = 5;
            // 
            // PostortTextBox
            // 
            this.PostortTextBox.Location = new System.Drawing.Point(111, 80);
            this.PostortTextBox.Name = "PostortTextBox";
            this.PostortTextBox.Size = new System.Drawing.Size(100, 22);
            this.PostortTextBox.TabIndex = 6;
            // 
            // AddAdressBTN
            // 
            this.AddAdressBTN.Location = new System.Drawing.Point(390, 9);
            this.AddAdressBTN.Name = "AddAdressBTN";
            this.AddAdressBTN.Size = new System.Drawing.Size(151, 91);
            this.AddAdressBTN.TabIndex = 7;
            this.AddAdressBTN.Text = "Lägg till adress";
            this.AddAdressBTN.UseVisualStyleBackColor = true;
            this.AddAdressBTN.Click += new System.EventHandler(this.AddAdressBTN_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 176);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 17);
            this.InfoLabel.TabIndex = 8;
            // 
            // DeleteAdressBTN
            // 
            this.DeleteAdressBTN.Location = new System.Drawing.Point(729, 243);
            this.DeleteAdressBTN.Name = "DeleteAdressBTN";
            this.DeleteAdressBTN.Size = new System.Drawing.Size(140, 51);
            this.DeleteAdressBTN.TabIndex = 9;
            this.DeleteAdressBTN.Text = "Ta bort adress";
            this.DeleteAdressBTN.UseVisualStyleBackColor = true;
            this.DeleteAdressBTN.Click += new System.EventHandler(this.DeleteAdressBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(111, 119);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 22);
            this.IdTextBox.TabIndex = 11;
            // 
            // postnummerDataGridViewTextBoxColumn
            // 
            this.postnummerDataGridViewTextBoxColumn.DataPropertyName = "Postnummer";
            this.postnummerDataGridViewTextBoxColumn.HeaderText = "Postnummer";
            this.postnummerDataGridViewTextBoxColumn.Name = "postnummerDataGridViewTextBoxColumn";
            this.postnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gatuadressDataGridViewTextBoxColumn
            // 
            this.gatuadressDataGridViewTextBoxColumn.DataPropertyName = "Gatuadress";
            this.gatuadressDataGridViewTextBoxColumn.HeaderText = "Gatuadress";
            this.gatuadressDataGridViewTextBoxColumn.Name = "gatuadressDataGridViewTextBoxColumn";
            this.gatuadressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postortDataGridViewTextBoxColumn
            // 
            this.postortDataGridViewTextBoxColumn.DataPropertyName = "Postort";
            this.postortDataGridViewTextBoxColumn.HeaderText = "Postort";
            this.postortDataGridViewTextBoxColumn.Name = "postortDataGridViewTextBoxColumn";
            this.postortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressBindingSource1
            // 
            this.adressBindingSource1.DataSource = typeof(Uppgift1.Models.Adress);
            // 
            // Adresser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 618);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteAdressBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AddAdressBTN);
            this.Controls.Add(this.PostortTextBox);
            this.Controls.Add(this.GatuadressTextBox);
            this.Controls.Add(this.PostNummerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addresserDataGridView);
            this.Name = "Adresser";
            this.Text = "Adresser";
            ((System.ComponentModel.ISupportInitialize)(this.addresserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView addresserDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PostNummerTextBox;
        private System.Windows.Forms.TextBox GatuadressTextBox;
        private System.Windows.Forms.TextBox PostortTextBox;
        private System.Windows.Forms.Button AddAdressBTN;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button DeleteAdressBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatuadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postortDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource adressBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdTextBox;
    }
}