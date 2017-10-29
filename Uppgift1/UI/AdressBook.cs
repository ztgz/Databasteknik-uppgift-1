using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uppgift1.DAL;
using Uppgift1.Models;
using Uppgift1.UI;

namespace Uppgift1
{
    public partial class AdressBook : Form
    {
        public AdressBook()
        {
            InitializeComponent();

            InitializeAdressBook();
        }

        private void InitializeAdressBook()
        {
            AllaRadioBtn.Select();
            LoadAddressBook();
        }

        private void LoadAddressBook()
        {
            var dataAccess = new DataAccess();
            var commandText = "Select Id, Namn, Epost FROM Person;";
            

            if (AllaRadioBtn.Checked)
            {
                commandText = "SELECT p.Id, p.Namn, p.Epost, Telefonnummer.Nummer, Postnummer, Gatuadress, Postort " +
                                  "FROM Person p LEFT JOIN Telefonlista ON p.Id = Telefonlista.FK_Id " +
                                  "LEFT JOIN Telefonnummer ON Telefonlista.FK_Nummer = Telefonnummer.Nummer " +
                                  "LEFT JOIN Adressregister ON p.Id = Adressregister.FK_Id " +
                                  "LEFT JOIN Adress ON Adressregister.FK_Postnummer = Adress.Postnummer AND " +
                                  "Adressregister.FK_Gatuadress = Adress.Gatuadress;";

                DataLabel.Text = "Alla Kontakter";
            }
            else if (JobbRadioBTN.Checked)
            {
                commandText = "SELECT Person.Id, Namn, Epost, Telefonnummer.Nummer, Postnummer, Gatuadress, Postort " +
                              "From JobbKontakt LEFT JOIN Person ON JobbKontakt.FK_Id = Person.Id " +
                              "LEFT JOIN Telefonlista ON Person.Id = Telefonlista.FK_Id " +
                              "LEFT JOIN Telefonnummer ON Telefonlista.FK_Nummer = Telefonnummer.Nummer " +
                              "LEFT JOIN Adressregister ON Person.Id = Adressregister.FK_Id " +
                              "LEFT JOIN Adress ON Adressregister.FK_Postnummer = Adress.Postnummer AND " +
                              "Adressregister.FK_Gatuadress = Adress.Gatuadress;";

                DataLabel.Text = "Jobb Kontakter";
            }
            else if (PersonligRadioBTN.Checked)
            {
                commandText = "SELECT Person.Id, Namn, Epost, Telefonnummer.Nummer, Postnummer, Gatuadress, Postort " +
                              "From [PersonligKontakt] LEFT JOIN Person ON [PersonligKontakt].FK_Id = Person.Id " +
                              "LEFT JOIN Telefonlista ON Person.Id = Telefonlista.FK_Id " +
                              "LEFT JOIN Telefonnummer ON Telefonlista.FK_Nummer = Telefonnummer.Nummer " +
                              "LEFT JOIN Adressregister ON Person.Id = Adressregister.FK_Id " +
                              "LEFT JOIN Adress ON Adressregister.FK_Postnummer = Adress.Postnummer AND " +
                              "Adressregister.FK_Gatuadress = Adress.Gatuadress;";

                DataLabel.Text = "Personliga Kontakter";
            }
            else if (ÖvrigRadioBTN.Checked)
            {
                commandText = "SELECT Person.Id, Namn, Epost, Telefonnummer.Nummer, Postnummer, Gatuadress, Postort " +
                              "From [ÖvrigKontakt] LEFT JOIN Person ON [ÖvrigKontakt].FK_Id = Person.Id " +
                              "LEFT JOIN Telefonlista ON Person.Id = Telefonlista.FK_Id " +
                              "LEFT JOIN Telefonnummer ON Telefonlista.FK_Nummer = Telefonnummer.Nummer " +
                              "LEFT JOIN Adressregister ON Person.Id = Adressregister.FK_Id " +
                              "LEFT JOIN Adress ON Adressregister.FK_Postnummer = Adress.Postnummer AND " +
                              "Adressregister.FK_Gatuadress = Adress.Gatuadress;";

                DataLabel.Text = "Övriga Kontakter";
            }

            DataSet persons = dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);

            PersonsDataGridView.DataSource = persons.Tables[0];
        }

        private void UppdateraTabelBTN_Click(object sender, EventArgs e)
        {
            LoadAddressBook();
        }

        private void AddPersonBTN_Click(object sender, EventArgs e)
        {
            AddPerson addPersonWindow = new AddPerson();
            addPersonWindow.Show();
        }
    }
}
