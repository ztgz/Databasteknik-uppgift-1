namespace Uppgift1.UI
{
    partial class AddPhonenumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.TelefonnummerTextBox = new System.Windows.Forms.TextBox();
            this.telefonnummerDataGridView = new System.Windows.Forms.DataGridView();
            this.AddPhonenumberBTN = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.telefonnummerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefonnummer";
            // 
            // TelefonnummerTextBox
            // 
            this.TelefonnummerTextBox.Location = new System.Drawing.Point(126, 13);
            this.TelefonnummerTextBox.Name = "TelefonnummerTextBox";
            this.TelefonnummerTextBox.Size = new System.Drawing.Size(100, 22);
            this.TelefonnummerTextBox.TabIndex = 1;
            // 
            // telefonnummerDataGridView
            // 
            this.telefonnummerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefonnummerDataGridView.Location = new System.Drawing.Point(12, 126);
            this.telefonnummerDataGridView.Name = "telefonnummerDataGridView";
            this.telefonnummerDataGridView.RowTemplate.Height = 24;
            this.telefonnummerDataGridView.Size = new System.Drawing.Size(665, 232);
            this.telefonnummerDataGridView.TabIndex = 2;
            // 
            // AddPhonenumberBTN
            // 
            this.AddPhonenumberBTN.Location = new System.Drawing.Point(273, 20);
            this.AddPhonenumberBTN.Name = "AddPhonenumberBTN";
            this.AddPhonenumberBTN.Size = new System.Drawing.Size(194, 44);
            this.AddPhonenumberBTN.TabIndex = 3;
            this.AddPhonenumberBTN.Text = "Lägg till nummer";
            this.AddPhonenumberBTN.UseVisualStyleBackColor = true;
            this.AddPhonenumberBTN.Click += new System.EventHandler(this.AddPhonenumberBTN_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 106);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 17);
            this.InfoLabel.TabIndex = 4;
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.Location = new System.Drawing.Point(551, -1);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(137, 51);
            this.DeleteRowBtn.TabIndex = 5;
            this.DeleteRowBtn.Text = "Ta bort rad";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(126, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 7;
            // 
            // AddPhonenumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 370);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AddPhonenumberBTN);
            this.Controls.Add(this.telefonnummerDataGridView);
            this.Controls.Add(this.TelefonnummerTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddPhonenumber";
            this.Text = "AddPhonenumber";
            ((System.ComponentModel.ISupportInitialize)(this.telefonnummerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TelefonnummerTextBox;
        private System.Windows.Forms.DataGridView telefonnummerDataGridView;
        private System.Windows.Forms.Button AddPhonenumberBTN;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
    }
}