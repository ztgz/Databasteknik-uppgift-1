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
            this.addresserDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PostNummerTextBox = new System.Windows.Forms.TextBox();
            this.GatuadressTextBox = new System.Windows.Forms.TextBox();
            this.PostortTextBox = new System.Windows.Forms.TextBox();
            this.AddAdressBTN = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addresserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addresserDataGridView
            // 
            this.addresserDataGridView.AllowUserToAddRows = false;
            this.addresserDataGridView.AllowUserToDeleteRows = false;
            this.addresserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addresserDataGridView.Location = new System.Drawing.Point(13, 300);
            this.addresserDataGridView.Name = "addresserDataGridView";
            this.addresserDataGridView.ReadOnly = true;
            this.addresserDataGridView.RowTemplate.Height = 24;
            this.addresserDataGridView.Size = new System.Drawing.Size(1081, 282);
            this.addresserDataGridView.TabIndex = 0;
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
            this.AddAdressBTN.Location = new System.Drawing.Point(259, 11);
            this.AddAdressBTN.Name = "AddAdressBTN";
            this.AddAdressBTN.Size = new System.Drawing.Size(151, 91);
            this.AddAdressBTN.TabIndex = 7;
            this.AddAdressBTN.Text = "Lägg till Adress";
            this.AddAdressBTN.UseVisualStyleBackColor = true;
            this.AddAdressBTN.Click += new System.EventHandler(this.AddAdressBTN_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(13, 119);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 17);
            this.InfoLabel.TabIndex = 8;
            // 
            // Adresser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 618);
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
    }
}