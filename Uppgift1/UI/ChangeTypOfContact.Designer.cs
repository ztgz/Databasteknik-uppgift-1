namespace Uppgift1.UI
{
    partial class ChangeTypOfContact
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
            this.JobbCheckBox = new System.Windows.Forms.CheckBox();
            this.personligCheckBox = new System.Windows.Forms.CheckBox();
            this.ÖvrigCheckBox = new System.Windows.Forms.CheckBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JobbCheckBox
            // 
            this.JobbCheckBox.AutoSize = true;
            this.JobbCheckBox.Location = new System.Drawing.Point(13, 29);
            this.JobbCheckBox.Name = "JobbCheckBox";
            this.JobbCheckBox.Size = new System.Drawing.Size(111, 21);
            this.JobbCheckBox.TabIndex = 0;
            this.JobbCheckBox.Text = "Jobb kontakt";
            this.JobbCheckBox.UseVisualStyleBackColor = true;
            // 
            // personligCheckBox
            // 
            this.personligCheckBox.AutoSize = true;
            this.personligCheckBox.Location = new System.Drawing.Point(13, 66);
            this.personligCheckBox.Name = "personligCheckBox";
            this.personligCheckBox.Size = new System.Drawing.Size(141, 21);
            this.personligCheckBox.TabIndex = 1;
            this.personligCheckBox.Text = "Personlig Kontakt";
            this.personligCheckBox.UseVisualStyleBackColor = true;
            // 
            // ÖvrigCheckBox
            // 
            this.ÖvrigCheckBox.AutoSize = true;
            this.ÖvrigCheckBox.Location = new System.Drawing.Point(13, 107);
            this.ÖvrigCheckBox.Name = "ÖvrigCheckBox";
            this.ÖvrigCheckBox.Size = new System.Drawing.Size(116, 21);
            this.ÖvrigCheckBox.TabIndex = 2;
            this.ÖvrigCheckBox.Text = "Övrig Kontakt";
            this.ÖvrigCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(13, 156);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(168, 49);
            this.saveBTN.TabIndex = 3;
            this.saveBTN.Text = "Spara";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // ChangeTypOfContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 228);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.ÖvrigCheckBox);
            this.Controls.Add(this.personligCheckBox);
            this.Controls.Add(this.JobbCheckBox);
            this.Name = "ChangeTypOfContact";
            this.Text = "ChangeTypOfContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox JobbCheckBox;
        private System.Windows.Forms.CheckBox personligCheckBox;
        private System.Windows.Forms.CheckBox ÖvrigCheckBox;
        private System.Windows.Forms.Button saveBTN;
    }
}