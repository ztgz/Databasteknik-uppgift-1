namespace Uppgift1.UI
{
    partial class AddPerson
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
            this.GatuadressLabel = new System.Windows.Forms.Label();
            this.PostnummerLabel = new System.Windows.Forms.Label();
            this.PostordLabel = new System.Windows.Forms.Label();
            this.TelefonLabel = new System.Windows.Forms.Label();
            this.EpostLabel = new System.Windows.Forms.Label();
            this.NamnTextbox = new System.Windows.Forms.TextBox();
            this.GatuadressTextbox = new System.Windows.Forms.TextBox();
            this.PostnummerTextbox = new System.Windows.Forms.TextBox();
            this.PostortTextbox = new System.Windows.Forms.TextBox();
            this.TelefonTextbox = new System.Windows.Forms.TextBox();
            this.EpostTextbox = new System.Windows.Forms.TextBox();
            this.AddContactBTN = new System.Windows.Forms.Button();
            this.ÖvrigKontaktCheckBox = new System.Windows.Forms.CheckBox();
            this.JobbKontaktCheckBox = new System.Windows.Forms.CheckBox();
            this.PersonligKontaktCheckBox = new System.Windows.Forms.CheckBox();
            this.TypAvKontaktLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NamnLabel
            // 
            this.NamnLabel.AutoSize = true;
            this.NamnLabel.Location = new System.Drawing.Point(13, 13);
            this.NamnLabel.Name = "NamnLabel";
            this.NamnLabel.Size = new System.Drawing.Size(45, 17);
            this.NamnLabel.TabIndex = 0;
            this.NamnLabel.Text = "Namn";
            // 
            // GatuadressLabel
            // 
            this.GatuadressLabel.AutoSize = true;
            this.GatuadressLabel.Location = new System.Drawing.Point(16, 61);
            this.GatuadressLabel.Name = "GatuadressLabel";
            this.GatuadressLabel.Size = new System.Drawing.Size(82, 17);
            this.GatuadressLabel.TabIndex = 1;
            this.GatuadressLabel.Text = "Gatuadress";
            // 
            // PostnummerLabel
            // 
            this.PostnummerLabel.AutoSize = true;
            this.PostnummerLabel.Location = new System.Drawing.Point(19, 113);
            this.PostnummerLabel.Name = "PostnummerLabel";
            this.PostnummerLabel.Size = new System.Drawing.Size(87, 17);
            this.PostnummerLabel.TabIndex = 2;
            this.PostnummerLabel.Text = "Postnummer";
            // 
            // PostordLabel
            // 
            this.PostordLabel.AutoSize = true;
            this.PostordLabel.Location = new System.Drawing.Point(22, 161);
            this.PostordLabel.Name = "PostordLabel";
            this.PostordLabel.Size = new System.Drawing.Size(53, 17);
            this.PostordLabel.TabIndex = 3;
            this.PostordLabel.Text = "Postort";
            // 
            // TelefonLabel
            // 
            this.TelefonLabel.AutoSize = true;
            this.TelefonLabel.Location = new System.Drawing.Point(22, 204);
            this.TelefonLabel.Name = "TelefonLabel";
            this.TelefonLabel.Size = new System.Drawing.Size(56, 17);
            this.TelefonLabel.TabIndex = 4;
            this.TelefonLabel.Text = "Telefon";
            // 
            // EpostLabel
            // 
            this.EpostLabel.AutoSize = true;
            this.EpostLabel.Location = new System.Drawing.Point(25, 248);
            this.EpostLabel.Name = "EpostLabel";
            this.EpostLabel.Size = new System.Drawing.Size(44, 17);
            this.EpostLabel.TabIndex = 5;
            this.EpostLabel.Text = "Epost";
            // 
            // NamnTextbox
            // 
            this.NamnTextbox.Location = new System.Drawing.Point(127, 13);
            this.NamnTextbox.Name = "NamnTextbox";
            this.NamnTextbox.Size = new System.Drawing.Size(100, 22);
            this.NamnTextbox.TabIndex = 6;
            // 
            // GatuadressTextbox
            // 
            this.GatuadressTextbox.Location = new System.Drawing.Point(127, 61);
            this.GatuadressTextbox.Name = "GatuadressTextbox";
            this.GatuadressTextbox.Size = new System.Drawing.Size(100, 22);
            this.GatuadressTextbox.TabIndex = 7;
            // 
            // PostnummerTextbox
            // 
            this.PostnummerTextbox.Location = new System.Drawing.Point(127, 113);
            this.PostnummerTextbox.Name = "PostnummerTextbox";
            this.PostnummerTextbox.Size = new System.Drawing.Size(100, 22);
            this.PostnummerTextbox.TabIndex = 8;
            // 
            // PostortTextbox
            // 
            this.PostortTextbox.Location = new System.Drawing.Point(127, 161);
            this.PostortTextbox.Name = "PostortTextbox";
            this.PostortTextbox.Size = new System.Drawing.Size(100, 22);
            this.PostortTextbox.TabIndex = 9;
            // 
            // TelefonTextbox
            // 
            this.TelefonTextbox.Location = new System.Drawing.Point(127, 204);
            this.TelefonTextbox.Name = "TelefonTextbox";
            this.TelefonTextbox.Size = new System.Drawing.Size(100, 22);
            this.TelefonTextbox.TabIndex = 10;
            // 
            // EpostTextbox
            // 
            this.EpostTextbox.Location = new System.Drawing.Point(127, 242);
            this.EpostTextbox.Name = "EpostTextbox";
            this.EpostTextbox.Size = new System.Drawing.Size(100, 22);
            this.EpostTextbox.TabIndex = 11;
            // 
            // AddContactBTN
            // 
            this.AddContactBTN.Location = new System.Drawing.Point(127, 334);
            this.AddContactBTN.Name = "AddContactBTN";
            this.AddContactBTN.Size = new System.Drawing.Size(100, 60);
            this.AddContactBTN.TabIndex = 12;
            this.AddContactBTN.Text = "Skapa Kontakt";
            this.AddContactBTN.UseVisualStyleBackColor = true;
            this.AddContactBTN.Click += new System.EventHandler(this.AddContactBTN_Click);
            // 
            // ÖvrigKontaktCheckBox
            // 
            this.ÖvrigKontaktCheckBox.AutoSize = true;
            this.ÖvrigKontaktCheckBox.Location = new System.Drawing.Point(289, 281);
            this.ÖvrigKontaktCheckBox.Name = "ÖvrigKontaktCheckBox";
            this.ÖvrigKontaktCheckBox.Size = new System.Drawing.Size(64, 21);
            this.ÖvrigKontaktCheckBox.TabIndex = 13;
            this.ÖvrigKontaktCheckBox.Text = "Övrig";
            this.ÖvrigKontaktCheckBox.UseVisualStyleBackColor = true;
            // 
            // JobbKontaktCheckBox
            // 
            this.JobbKontaktCheckBox.AutoSize = true;
            this.JobbKontaktCheckBox.Location = new System.Drawing.Point(222, 281);
            this.JobbKontaktCheckBox.Name = "JobbKontaktCheckBox";
            this.JobbKontaktCheckBox.Size = new System.Drawing.Size(61, 21);
            this.JobbKontaktCheckBox.TabIndex = 14;
            this.JobbKontaktCheckBox.Text = "Jobb";
            this.JobbKontaktCheckBox.UseVisualStyleBackColor = true;
            // 
            // PersonligKontaktCheckBox
            // 
            this.PersonligKontaktCheckBox.AutoSize = true;
            this.PersonligKontaktCheckBox.Location = new System.Drawing.Point(127, 281);
            this.PersonligKontaktCheckBox.Name = "PersonligKontaktCheckBox";
            this.PersonligKontaktCheckBox.Size = new System.Drawing.Size(89, 21);
            this.PersonligKontaktCheckBox.TabIndex = 15;
            this.PersonligKontaktCheckBox.Text = "Personlig";
            this.PersonligKontaktCheckBox.UseVisualStyleBackColor = true;
            // 
            // TypAvKontaktLabel
            // 
            this.TypAvKontaktLabel.AutoSize = true;
            this.TypAvKontaktLabel.Location = new System.Drawing.Point(25, 281);
            this.TypAvKontaktLabel.Name = "TypAvKontaktLabel";
            this.TypAvKontaktLabel.Size = new System.Drawing.Size(79, 17);
            this.TypAvKontaktLabel.TabIndex = 16;
            this.TypAvKontaktLabel.Text = "Kontakt typ";
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 451);
            this.Controls.Add(this.TypAvKontaktLabel);
            this.Controls.Add(this.PersonligKontaktCheckBox);
            this.Controls.Add(this.JobbKontaktCheckBox);
            this.Controls.Add(this.ÖvrigKontaktCheckBox);
            this.Controls.Add(this.AddContactBTN);
            this.Controls.Add(this.EpostTextbox);
            this.Controls.Add(this.TelefonTextbox);
            this.Controls.Add(this.PostortTextbox);
            this.Controls.Add(this.PostnummerTextbox);
            this.Controls.Add(this.GatuadressTextbox);
            this.Controls.Add(this.NamnTextbox);
            this.Controls.Add(this.EpostLabel);
            this.Controls.Add(this.TelefonLabel);
            this.Controls.Add(this.PostordLabel);
            this.Controls.Add(this.PostnummerLabel);
            this.Controls.Add(this.GatuadressLabel);
            this.Controls.Add(this.NamnLabel);
            this.Name = "AddPerson";
            this.Text = "AddPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamnLabel;
        private System.Windows.Forms.Label GatuadressLabel;
        private System.Windows.Forms.Label PostnummerLabel;
        private System.Windows.Forms.Label PostordLabel;
        private System.Windows.Forms.Label TelefonLabel;
        private System.Windows.Forms.Label EpostLabel;
        private System.Windows.Forms.TextBox NamnTextbox;
        private System.Windows.Forms.TextBox GatuadressTextbox;
        private System.Windows.Forms.TextBox PostnummerTextbox;
        private System.Windows.Forms.TextBox PostortTextbox;
        private System.Windows.Forms.TextBox TelefonTextbox;
        private System.Windows.Forms.TextBox EpostTextbox;
        private System.Windows.Forms.Button AddContactBTN;
        private System.Windows.Forms.CheckBox ÖvrigKontaktCheckBox;
        private System.Windows.Forms.CheckBox JobbKontaktCheckBox;
        private System.Windows.Forms.CheckBox PersonligKontaktCheckBox;
        private System.Windows.Forms.Label TypAvKontaktLabel;
    }
}