namespace Uppgift1.UI
{
    partial class MoreInfoWindow
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
            this.moreInfoDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moreInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moreInfoDataGridView
            // 
            this.moreInfoDataGridView.AllowUserToAddRows = false;
            this.moreInfoDataGridView.AllowUserToDeleteRows = false;
            this.moreInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moreInfoDataGridView.Location = new System.Drawing.Point(31, 25);
            this.moreInfoDataGridView.Name = "moreInfoDataGridView";
            this.moreInfoDataGridView.ReadOnly = true;
            this.moreInfoDataGridView.RowTemplate.Height = 24;
            this.moreInfoDataGridView.Size = new System.Drawing.Size(1000, 390);
            this.moreInfoDataGridView.TabIndex = 0;
            // 
            // MoreInfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 444);
            this.Controls.Add(this.moreInfoDataGridView);
            this.Name = "MoreInfoWindow";
            this.Text = "MoreInfoWindow";
            ((System.ComponentModel.ISupportInitialize)(this.moreInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView moreInfoDataGridView;
    }
}