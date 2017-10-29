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

                SQLCommands.CreateAdressInDatabase(dataAccess, PostNummerTextBox.Text, GatuadressTextBox.Text,
                    PostortTextBox.Text);
            }
        }
    }
}
