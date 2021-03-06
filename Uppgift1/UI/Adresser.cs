﻿using System;
using System.Data;
using System.Text.RegularExpressions;
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
            GatuadressTextBox.Text = Regex.Replace(GatuadressTextBox.Text, "[;]", "");
            PostNummerTextBox.Text = Regex.Replace(PostNummerTextBox.Text, "[;]", "");
            PostortTextBox.Text = Regex.Replace(PostortTextBox.Text, "[;]", "");
            IdTextBox.Text = Regex.Replace(IdTextBox.Text, "[;]", "");

            if (!string.IsNullOrEmpty(GatuadressTextBox.Text) &&
                !string.IsNullOrEmpty(PostNummerTextBox.Text) &&
                !string.IsNullOrEmpty(PostortTextBox.Text) &&
                int.TryParse(IdTextBox.Text, out int id))
            {
                DataAccess dataAccess = new DataAccess();

                //if (SQLCommands.CreateAdressInDatabase(dataAccess, PostNummerTextBox.Text, 
                //    GatuadressTextBox.Text, PostortTextBox.Text))
                if (SQLCommands.CreateAdressInRegister(dataAccess, PostNummerTextBox.Text, 
                    GatuadressTextBox.Text, PostortTextBox.Text, id))
                {
                    InfoLabel.Text = "Adress kunde skapas.";

                    GatuadressTextBox.Text = "";
                    PostNummerTextBox.Text = "";
                    PostortTextBox.Text = "";
                    IdTextBox.Text = "";

                    LoadAdresses();
                }
                else
                {
                    InfoLabel.Text = "Adress kunde inte skapas." + 
                        "\nVänligen se efter om postnummer och adress redan finns i databasen.\n" +
                                     "Eller att id är korrekt.";
                }
            }
            else
            {
                InfoLabel.Text = "Adress kan inte skapas föräns alla fält är korrekt ifyllda.";
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
