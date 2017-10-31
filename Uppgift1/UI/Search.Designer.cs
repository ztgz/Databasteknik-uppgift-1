namespace Uppgift1.UI
{
    partial class Search
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
            this.NamnLabel = new System.Windows.Forms.Label();
            this.PostortLabel = new System.Windows.Forms.Label();
            this.NamnTextBox = new System.Windows.Forms.TextBox();
            this.PostortTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ÖvrigaKontakterBTN = new System.Windows.Forms.RadioButton();
            this.PersonligaKontakterBTN = new System.Windows.Forms.RadioButton();
            this.JobKontakterBTN = new System.Windows.Forms.RadioButton();
            this.allaKontakterBTN = new System.Windows.Forms.RadioButton();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NamnLabel
            // 
            this.NamnLabel.AutoSize = true;
            this.NamnLabel.Location = new System.Drawing.Point(13, 13);
            this.NamnLabel.Name = "NamnLabel";
            this.NamnLabel.Size = new System.Drawing.Size(49, 17);
            this.NamnLabel.TabIndex = 0;
            this.NamnLabel.Text = "Namn:";
            // 
            // PostortLabel
            // 
            this.PostortLabel.AutoSize = true;
            this.PostortLabel.Location = new System.Drawing.Point(13, 71);
            this.PostortLabel.Name = "PostortLabel";
            this.PostortLabel.Size = new System.Drawing.Size(57, 17);
            this.PostortLabel.TabIndex = 1;
            this.PostortLabel.Text = "Postort:";
            // 
            // NamnTextBox
            // 
            this.NamnTextBox.Location = new System.Drawing.Point(96, 13);
            this.NamnTextBox.Name = "NamnTextBox";
            this.NamnTextBox.Size = new System.Drawing.Size(100, 22);
            this.NamnTextBox.TabIndex = 2;
            // 
            // PostortTextBox
            // 
            this.PostortTextBox.Location = new System.Drawing.Point(96, 71);
            this.PostortTextBox.Name = "PostortTextBox";
            this.PostortTextBox.Size = new System.Drawing.Size(100, 22);
            this.PostortTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ÖvrigaKontakterBTN);
            this.panel1.Controls.Add(this.PersonligaKontakterBTN);
            this.panel1.Controls.Add(this.JobKontakterBTN);
            this.panel1.Controls.Add(this.allaKontakterBTN);
            this.panel1.Location = new System.Drawing.Point(239, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 116);
            this.panel1.TabIndex = 4;
            // 
            // ÖvrigaKontakterBTN
            // 
            this.ÖvrigaKontakterBTN.AutoSize = true;
            this.ÖvrigaKontakterBTN.Location = new System.Drawing.Point(4, 88);
            this.ÖvrigaKontakterBTN.Name = "ÖvrigaKontakterBTN";
            this.ÖvrigaKontakterBTN.Size = new System.Drawing.Size(134, 21);
            this.ÖvrigaKontakterBTN.TabIndex = 3;
            this.ÖvrigaKontakterBTN.TabStop = true;
            this.ÖvrigaKontakterBTN.Text = "Övriga kontakter";
            this.ÖvrigaKontakterBTN.UseVisualStyleBackColor = true;
            // 
            // PersonligaKontakterBTN
            // 
            this.PersonligaKontakterBTN.AutoSize = true;
            this.PersonligaKontakterBTN.Location = new System.Drawing.Point(4, 60);
            this.PersonligaKontakterBTN.Name = "PersonligaKontakterBTN";
            this.PersonligaKontakterBTN.Size = new System.Drawing.Size(159, 21);
            this.PersonligaKontakterBTN.TabIndex = 2;
            this.PersonligaKontakterBTN.TabStop = true;
            this.PersonligaKontakterBTN.Text = "Personliga kontakter";
            this.PersonligaKontakterBTN.UseVisualStyleBackColor = true;
            // 
            // JobKontakterBTN
            // 
            this.JobKontakterBTN.AutoSize = true;
            this.JobKontakterBTN.Location = new System.Drawing.Point(4, 32);
            this.JobKontakterBTN.Name = "JobKontakterBTN";
            this.JobKontakterBTN.Size = new System.Drawing.Size(123, 21);
            this.JobKontakterBTN.TabIndex = 1;
            this.JobKontakterBTN.TabStop = true;
            this.JobKontakterBTN.Text = "Jobb kontakter";
            this.JobKontakterBTN.UseVisualStyleBackColor = true;
            // 
            // allaKontakterBTN
            // 
            this.allaKontakterBTN.AutoSize = true;
            this.allaKontakterBTN.Location = new System.Drawing.Point(4, 4);
            this.allaKontakterBTN.Name = "allaKontakterBTN";
            this.allaKontakterBTN.Size = new System.Drawing.Size(115, 21);
            this.allaKontakterBTN.TabIndex = 0;
            this.allaKontakterBTN.TabStop = true;
            this.allaKontakterBTN.Text = "Alla kontakter";
            this.allaKontakterBTN.UseVisualStyleBackColor = true;
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(32, 151);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(409, 63);
            this.searchBTN.TabIndex = 5;
            this.searchBTN.Text = "Sök";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchResultDataGridView
            // 
            this.searchResultDataGridView.AllowUserToAddRows = false;
            this.searchResultDataGridView.AllowUserToDeleteRows = false;
            this.searchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultDataGridView.Location = new System.Drawing.Point(32, 242);
            this.searchResultDataGridView.Name = "searchResultDataGridView";
            this.searchResultDataGridView.ReadOnly = true;
            this.searchResultDataGridView.RowTemplate.Height = 24;
            this.searchResultDataGridView.Size = new System.Drawing.Size(744, 262);
            this.searchResultDataGridView.TabIndex = 6;
            this.searchResultDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultDataGridView_CellDoubleClick);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 539);
            this.Controls.Add(this.searchResultDataGridView);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PostortTextBox);
            this.Controls.Add(this.NamnTextBox);
            this.Controls.Add(this.PostortLabel);
            this.Controls.Add(this.NamnLabel);
            this.Name = "Search";
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamnLabel;
        private System.Windows.Forms.Label PostortLabel;
        private System.Windows.Forms.TextBox NamnTextBox;
        private System.Windows.Forms.TextBox PostortTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ÖvrigaKontakterBTN;
        private System.Windows.Forms.RadioButton PersonligaKontakterBTN;
        private System.Windows.Forms.RadioButton JobKontakterBTN;
        private System.Windows.Forms.RadioButton allaKontakterBTN;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.DataGridView searchResultDataGridView;
    }
}