﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Uppgift1.DAL;

namespace Uppgift1.UI
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void AddContactBTN_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            NamnTextbox.Text = Regex.Replace(NamnTextbox.Text, "[;]", "");
            GatuadressTextbox.Text = Regex.Replace(GatuadressTextbox.Text, "[;]", "");
            PostnummerTextbox.Text = Regex.Replace(PostnummerTextbox.Text, "[;]", "");
            PostortTextbox.Text = Regex.Replace(PostortTextbox.Text, "[;]", "");
            TelefonTextbox.Text = Regex.Replace(TelefonTextbox.Text, "[;]", "");
            EpostTextbox.Text = Regex.Replace(EpostTextbox.Text, "[;]", "");

            if (!String.IsNullOrEmpty(NamnTextbox.Text))
            {
                InfoLabel.Text = "En kontakt har lagts till.";

                CreatePerson(dataAccess);

                /* Get the id of the last added person */
                int Id = GetIdOfLastPersonInList(dataAccess);


                SQLCommands.ChangeKontakt(dataAccess, Id, JobbKontaktCheckBox.Checked,
                    PersonligKontaktCheckBox.Checked, ÖvrigKontaktCheckBox.Checked);

                // If Postnumber and gatuaddres exsists, add address
                if (!string.IsNullOrEmpty(PostnummerTextbox.Text) && !string.IsNullOrEmpty(GatuadressTextbox.Text)
                    && !string.IsNullOrEmpty(PostortTextbox.Text))
                {
                    AddAdressToPerson(dataAccess, PostnummerTextbox.Text, GatuadressTextbox.Text,
                        PostortTextbox.Text, Id);

                    InfoLabel.Text += "\nEn adress har lagts till i kontakten.";

                }
                else
                {
                    InfoLabel.Text += "\nIngen adress har lagts till i kontakten.";
                }

                //Add phone number
                if (!string.IsNullOrEmpty(TelefonTextbox.Text) && TelefonTextbox.Text.Length <= 20)
                {
                    AddPhoneNumberToPerson(dataAccess, TelefonTextbox.Text, Id);
                    InfoLabel.Text += "\nEtt telefonnummer har lagts till i kontakten.";
                }
                else
                {
                    InfoLabel.Text += "\nInget telefonnummer har lagts till i kontakten.";
                }

                /*Nollställ alla fält*/
                JobbKontaktCheckBox.Checked = false;
                ÖvrigKontaktCheckBox.Checked = false;
                PersonligKontaktCheckBox.Checked = false;

                PostnummerTextbox.Text = "";
                GatuadressTextbox.Text = "";
                PostortTextbox.Text = "";

                NamnTextbox.Text = "";
                EpostTextbox.Text = "";

                TelefonTextbox.Text = "";

            }
            else
            {
                InfoLabel.Text = "Ett namn måste anges för att kunna skapa kontakt.";
            }
        }

        private int GetIdOfLastPersonInList(DataAccess dataAccess)
        {
            DataSet dataSet = new DataSet();

            var commandText = "Select TOP 1 Id, Namn, Epost FROM Person " +
                              "ORDER BY Id DESC;";
            dataSet = dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);

            return int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
        }

        private void CreatePerson(DataAccess dataAccess)
        {
            ///* Add persons */
            string namn = NamnTextbox.Text;
            ////string Telefon = TelefonTextbox.Text;
            string epost = EpostTextbox.Text;

            SQLCommands.CreatePerson(dataAccess, namn, epost);
        }

        private void AddPhoneNumberToPerson(DataAccess dataAccess, string phoneNumber, int Id)
        {

            SQLCommands.CreatePhoneNumberInDatabase(dataAccess, phoneNumber);

            SQLCommands.AddPhonenumberToPhonelist(dataAccess, phoneNumber, Id);
        }

        private void AddAdressToPerson(DataAccess dataAccess, string postalCode, string adress, string city, int Id)
        {
            //SQLCommands.AddAdressToAdressregister(dataAccess, postalCode, adress, city, Id);            
            SQLCommands.CreateAdressInRegister(dataAccess, postalCode, adress, city, Id);
        }
    }
}
