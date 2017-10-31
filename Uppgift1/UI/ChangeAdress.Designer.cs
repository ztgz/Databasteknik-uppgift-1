namespace Uppgift1.UI
{
    partial class ChangeAdress
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
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerIDLabel = new System.Windows.Forms.Label();
            this.removeLabel = new System.Windows.Forms.Label();
            this.removeBTN = new System.Windows.Forms.Button();
            this.changeBTN = new System.Windows.Forms.Button();
            this.postortTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(12, 35);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.postalCodeTextBox.TabIndex = 0;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(222, 35);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 22);
            this.StreetTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Postnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gatuadress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Postort";
            // 
            // playerIDLabel
            // 
            this.playerIDLabel.AutoSize = true;
            this.playerIDLabel.Location = new System.Drawing.Point(590, 35);
            this.playerIDLabel.Name = "playerIDLabel";
            this.playerIDLabel.Size = new System.Drawing.Size(65, 17);
            this.playerIDLabel.TabIndex = 6;
            this.playerIDLabel.Text = "Player ID";
            this.playerIDLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeLabel
            // 
            this.removeLabel.AutoSize = true;
            this.removeLabel.Location = new System.Drawing.Point(16, 144);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(55, 17);
            this.removeLabel.TabIndex = 7;
            this.removeLabel.Text = "remove";
            // 
            // removeBTN
            // 
            this.removeBTN.Location = new System.Drawing.Point(19, 179);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(141, 42);
            this.removeBTN.TabIndex = 8;
            this.removeBTN.Text = "Ta bort";
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // changeBTN
            // 
            this.changeBTN.Location = new System.Drawing.Point(16, 72);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(705, 46);
            this.changeBTN.TabIndex = 9;
            this.changeBTN.Text = "Ändra adress";
            this.changeBTN.UseVisualStyleBackColor = true;
            this.changeBTN.Click += new System.EventHandler(this.changeBTN_Click);
            // 
            // postortTextBox
            // 
            this.postortTextBox.Location = new System.Drawing.Point(445, 34);
            this.postortTextBox.Name = "postortTextBox";
            this.postortTextBox.Size = new System.Drawing.Size(100, 22);
            this.postortTextBox.TabIndex = 11;
            // 
            // ChangeAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 260);
            this.Controls.Add(this.postortTextBox);
            this.Controls.Add(this.changeBTN);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.removeLabel);
            this.Controls.Add(this.playerIDLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Name = "ChangeAdress";
            this.Text = "ChangeAdress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerIDLabel;
        private System.Windows.Forms.Label removeLabel;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button changeBTN;
        private System.Windows.Forms.TextBox postortTextBox;
    }
}