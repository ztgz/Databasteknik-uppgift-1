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

            if (!String.IsNullOrEmpty(NamnTextbox.Text))
            {
                InfoLabel.Text = "En kontakt har lagts till.";

                CreatePerson(dataAccess);

                /* Get the id of the last added person */
                int Id = GetIdOfLastPersonInList(dataAccess);

                if (JobbKontaktCheckBox.Checked)
                    CreateJobbKontakt(dataAccess, Id);

                if (PersonligKontaktCheckBox.Checked)
                    CreatePersonligKontakt(dataAccess, Id);

                if (ÖvrigKontaktCheckBox.Checked)
                    CreateÖvrigKontakt(dataAccess, Id);

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
            /* Add persons */
            string Namn = NamnTextbox.Text;
            //string Telefon = TelefonTextbox.Text;
            string Epost = EpostTextbox.Text;

            List<SqlParameter> parameters = new List<SqlParameter>();

            string insertCommand = "INSERT INTO Person(Namn";
            string valueCommand = "VALUES(@Namn";

            parameters.Add(new SqlParameter("@Namn", Namn));

            if (!string.IsNullOrEmpty(Epost))
            {
                insertCommand += ", Epost";
                valueCommand += ", @Epost";
                parameters.Add(new SqlParameter("@Epost", Epost));
            }
            
            insertCommand += ") ";
            valueCommand += ");";

            var command = insertCommand + valueCommand;

            dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters.ToArray());
        }

        private void CreateJobbKontakt(DataAccess dataAccess, int Id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", Id), 
            };

            var commandText = "INSERT INTO JobbKontakt(FK_Id) " +
                              "VALUES(@FK_Id);";

            dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        private void CreatePersonligKontakt(DataAccess dataAccess, int Id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", Id),
            };

            var commandText = "INSERT INTO PersonligKontakt(FK_Id) " +
                              "VALUES(@FK_Id);";

            dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        private void CreateÖvrigKontakt(DataAccess dataAccess, int Id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", Id),
            };

            var commandText = "INSERT INTO ÖvrigKontakt(FK_Id) " +
                              "VALUES(@FK_Id);";

            dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        private void AddPhoneNumberToPerson(DataAccess dataAccess, string phoneNumber, int Id)
        {

            SQLCommands.CreatePhoneNumberInDatabase(dataAccess, phoneNumber);

            SQLCommands.AddPhonenumberToPhonelist(dataAccess, phoneNumber, Id);
        }

        private void AddAdressToPerson(DataAccess dataAccess, string postalCode, string adress, string city, int Id)
        {
            SQLCommands.AddAdressToAdressregister(dataAccess, postalCode, adress, city, Id);
        }
    }
}
