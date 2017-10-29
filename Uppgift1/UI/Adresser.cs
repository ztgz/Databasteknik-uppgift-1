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
    public partial class Adresser : Form
    {
        public Adresser()
        {
            InitializeComponent();

            LoadAdresses();
        }

        private void LoadAdresses()
        {
            DataSet dataSet = SQLCommands.LoadAdresses();

            addresserDataGridView.DataSource = dataSet.Tables[0];
        }

        private void AddAdressBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GatuadressTextBox.Text) &&
                !string.IsNullOrEmpty(PostNummerTextBox.Text) &&
                !string.IsNullOrEmpty(PostortTextBox.Text))
            {
                DataAccess dataAccess = new DataAccess();

                if (SQLCommands.CreateAdressInDatabase(dataAccess, PostNummerTextBox.Text, 
                    GatuadressTextBox.Text, PostortTextBox.Text))
                {
                    InfoLabel.Text = "Adress kunde skapas.";

                    GatuadressTextBox.Text = "";
                    PostNummerTextBox.Text = "";
                    PostortTextBox.Text = "";

                    LoadAdresses();
                }
                else
                {
                    InfoLabel.Text = "Adress kunde inte skapas." + 
                        "\nVänligen se efter om postnummer och adress redan finns i databasen.";
                }
            }

            else
            {
                InfoLabel.Text = "Adress kan inte skapas föräns alla fält är ifyllda.";
            }
        }

        private void DeleteAdressBTN_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            for (int i = 0; i < addresserDataGridView.RowCount; i++)
            {
                if (addresserDataGridView.Rows[i].Selected)
                {
                    SQLCommands.DeleteAdress(dataAccess, addresserDataGridView[0,i].Value.ToString(),
                        addresserDataGridView[1,i].Value.ToString() );
                }
            }

            LoadAdresses();
        }
    }
}
