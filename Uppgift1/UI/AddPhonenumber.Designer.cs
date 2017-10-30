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
            // AddPhonenumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 370);
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
    }
}