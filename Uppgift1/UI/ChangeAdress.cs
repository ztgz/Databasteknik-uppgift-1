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
    public partial class ChangeAdress : Form
    {
        private string oldPostalCode;
        private string oldAdress;
        private string oldCity;
        private int id;

        public ChangeAdress(string postalCode, string adress, string city, int id)
        {
            InitializeComponent();

            oldPostalCode = postalCode;
            oldAdress = adress;
            oldCity = city;

            playerIDLabel.Text = "Person id:" + id;

            postOrtLabel.Text = city;
            postortTextBox.Text = city;
            StreetTextBox.Text = adress;
            postalCodeTextBox.Text = postalCode;
            this.id = id;

            removeLabel.Text = $"Ta bort: {postalCode}; {adress}; {city} för person {id}";
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            SQLCommands.DeleteAdressInRegister(dataAccess, oldPostalCode, oldAdress, id);
            Close();
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            if (postalCodeTextBox.Text.Length > 0 && StreetTextBox.Text.Length > 0 && 
                postortTextBox.Text.Length > 0)
            {
                DataAccess dataAccess = new DataAccess();
                SQLCommands.ChangePersonAdress(dataAccess, oldPostalCode, oldAdress, oldCity,
                    postalCodeTextBox.Text, StreetTextBox.Text, postortTextBox.Text, id);
                Close();
            }
        }
    }
}
