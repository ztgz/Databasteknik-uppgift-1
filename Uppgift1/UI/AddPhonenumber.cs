using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uppgift1.DAL;

namespace Uppgift1.UI
{
    public partial class AddPhonenumber : Form
    {
        public AddPhonenumber()
        {
            InitializeComponent();

            LoadPhonenumbers();
        }

        private void LoadPhonenumbers()
        {
            DataSet dataSet = SQLCommands.LoadPhonenumbers();

            telefonnummerDataGridView.DataSource = dataSet.Tables[0];
        }

        private void AddPhonenumberBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TelefonnummerTextBox.Text))
            {
                DataAccess dataAccess = new DataAccess();
                if (SQLCommands.CreatePhoneNumberInDatabase(dataAccess, TelefonnummerTextBox.Text))
                {
                    InfoLabel.Text = "Telefonnummer har lagts till i listan.";
                }
                else
                {
                    InfoLabel.Text =
                        "Telefonnummer kunde inte läggas till. Vänligen se efter om det inte redan finns i listan";
                }
                TelefonnummerTextBox.Text = "";
                LoadPhonenumbers();
            }
        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            for (int i = 0; i < telefonnummerDataGridView.RowCount; i++)
            {
                if (telefonnummerDataGridView.Rows[i].Selected)
                {
                    SQLCommands.DeletePhonenumber(dataAccess, telefonnummerDataGridView[0, i].Value.ToString());
                }
            }

            LoadPhonenumbers();
        }
    }
}
