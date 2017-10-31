using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Uppgift1.DAL;
using Uppgift1.UI;

namespace Uppgift1
{
    public partial class AdressBook : Form
    {
        private string oldCellValue;

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

            var commandText = "SELECT Person.Id, Namn, Epost, Telefonnummer.Nummer, Postnummer, Gatuadress, Postort ";

            if (AllaRadioBtn.Checked)
            {
                commandText += "FROM Person ";
                DataLabel.Text = "Alla Kontakter";
            }
            else if (JobbRadioBTN.Checked)
            {
                commandText += "From JobbKontakt LEFT JOIN Person ON JobbKontakt.FK_Id = Person.Id ";
                DataLabel.Text = "Jobb Kontakter";
            }
            else if (PersonligRadioBTN.Checked)
            {
                commandText += "From [PersonligKontakt] LEFT JOIN Person ON [PersonligKontakt].FK_Id = Person.Id ";
                DataLabel.Text = "Personliga Kontakter";
            }
            else if (ÖvrigRadioBTN.Checked)
            {
                commandText += "From [ÖvrigKontakt] LEFT JOIN Person ON [ÖvrigKontakt].FK_Id = Person.Id ";
                DataLabel.Text = "Övriga Kontakter";
            }

            commandText += "LEFT JOIN Telefonlista ON Person.Id = Telefonlista.FK_Id " +
                           "LEFT JOIN Telefonnummer ON Telefonlista.FK_Nummer = Telefonnummer.Nummer " +
                           "LEFT JOIN Adressregister ON Person.Id = Adressregister.FK_Id " +
                           "LEFT JOIN Adress ON Adressregister.FK_Postnummer = Adress.Postnummer AND " +
                           "Adressregister.FK_Gatuadress = Adress.Gatuadress;";

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

        private void AdressWindowBTN_Click(object sender, EventArgs e)
        {
            Adresser adressWindow = new Adresser();
            adressWindow.Show();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            Search searchWindow = new Search();
            searchWindow.Show();
        }

        private void TelefonBTN_Click(object sender, EventArgs e)
        {
            AddPhonenumber phoneWindow = new AddPhonenumber();
            phoneWindow.Show();
        }

        private void removeContactBTN_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();

            for (int i = 0; i < PersonsDataGridView.RowCount; i++)
            {
                if (PersonsDataGridView.Rows[i].Selected)
                {
                    SQLCommands.DeletePerson(dataAccess, int.Parse(PersonsDataGridView[0, i].Value.ToString()));
                }
            }

            LoadAddressBook();
        }

        private void PersonsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (PersonsDataGridView.Columns[e.ColumnIndex].HeaderText != "Id")
            {
                DataAccess dataAccess = new DataAccess();
                int id = (int)PersonsDataGridView[0, e.RowIndex].Value;
                string value = Regex.Replace(PersonsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString(), "[;]", "");
                //string value = PersonsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();

                switch (PersonsDataGridView.Columns[e.ColumnIndex].HeaderText)
                {
                    case "Namn":
                        SQLCommands.UpdateNamn(dataAccess, id, value);
                        break;
                    case "Epost":
                        SQLCommands.UpdateEpost(dataAccess, id, value);
                        break;
                    case "Nummer":
                        SQLCommands.UpdatePhonenumber(dataAccess, id, oldCellValue, value);
                        break;
                    case "Postnummer":
                    case "Gatuadress":
                        break;
                    case "Postort":
                        string postalCode = PersonsDataGridView[4, e.RowIndex].Value.ToString();
                        string adress = PersonsDataGridView[5, e.RowIndex].Value.ToString();

                        if (!string.IsNullOrEmpty(postalCode) && !string.IsNullOrEmpty(adress))
                            SQLCommands.UpdatePostort(dataAccess, postalCode, adress, value);
                        break;
                }
            }

            LoadAddressBook();
        }

        private void PersonsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Store cell value when begining to edit
            if (PersonsDataGridView[e.ColumnIndex, e.RowIndex].Value != null)
                oldCellValue = PersonsDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
            else
                oldCellValue = "";
        }

        private void PersonsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (PersonsDataGridView.Columns[e.ColumnIndex].HeaderText == "Postnummer" ||
                PersonsDataGridView.Columns[e.ColumnIndex].HeaderText == "Gatuadress")
            {
                int id = (int)PersonsDataGridView[0, e.RowIndex].Value;

                ChangeAdress changeAdressWindow = new ChangeAdress(PersonsDataGridView[4, e.RowIndex].Value.ToString(),
                    PersonsDataGridView[5, e.RowIndex].Value.ToString(),
                    PersonsDataGridView[6, e.RowIndex].Value.ToString(), id);

                changeAdressWindow.Show();
            }
            else if(PersonsDataGridView.Columns[e.ColumnIndex].HeaderText == "Id")
            {
                int id = (int)PersonsDataGridView[0, e.RowIndex].Value;
                DataAccess dataAccess = new DataAccess();
                ChangeTypOfContact typOfContactForm = new ChangeTypOfContact(id,
                    SQLCommands.PersonIsJobbKontakt(dataAccess, id),
                    SQLCommands.PersonIsPersonligKontakt(dataAccess, id),
                    SQLCommands.PersonIsÖvrigKontakt(dataAccess, id));
                typOfContactForm.Show();
            }
        }
    }
}
