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
            if (!string.IsNullOrEmpty(TelefonnummerTextBox.Text) &&
                int.TryParse(idTextBox.Text, out int id))
            {
                DataAccess dataAccess = new DataAccess();
                if (SQLCommands.UpdatePhonenumber(dataAccess, id, "", TelefonnummerTextBox.Text))
                {
                    InfoLabel.Text = "Telefonnummer har lagts till i listan.";
                }
                else
                {
                    InfoLabel.Text =
                        "Telefonnummer kunde inte läggas till.";
                }
                TelefonnummerTextBox.Text = "";
                idTextBox.Text = "";
                LoadPhonenumbers();
            }
            else
            {
                InfoLabel.Text = "Rätt nummer och id har ej angivits;";
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
