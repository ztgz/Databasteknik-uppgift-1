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

            /*if (!String.IsNullOrEmpty(Telefon))
            {
                insertCommand += ", Telefon";
                valueCommand += ", @Telefon";
                parameters.Add(new SqlParameter("@Telefon", Telefon));
            }*/

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
            /*Check if number exists*/
            bool numberExists = false;
            
            DataSet dataSet = new DataSet();

            var commandText = "Select Nummer FROM Telefonnummer";

            dataSet = dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if ((string)dataSet.Tables[0].Rows[i][0] == phoneNumber)
                {
                    numberExists = true;
                    break;
                }
            }

            SqlParameter[] parameters;
            /* If number does not exsist, add number*/
            if (!numberExists)
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@phoneNumber", phoneNumber), 
                };

                commandText = "INSERT INTO Telefonnummer " + "values(@phoneNumber);";

                dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
            }

            /* Add to phonelist */
            parameters = new SqlParameter[]
            {
                new SqlParameter("@FK_Nummer", phoneNumber),
                new SqlParameter("@FK_Id", Id), 
            };

            commandText = "INSERT INTO Telefonlista(FK_Nummer, FK_Id) " + "values(@FK_Nummer, @FK_Id);";

            dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        private void AddAdressToPerson(DataAccess dataAccess, string postalCode, string adress, string city, int Id)
        {
            /*Check if adress exists*/
            bool adressExists = false;

            DataSet dataSet = new DataSet();

            var commandText = "Select Postnummer, Gatuadress, Postort FROM Adress";

            dataSet = dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if ((string)dataSet.Tables[0].Rows[i][0] == postalCode && 
                    (string)dataSet.Tables[0].Rows[i][1] == adress)
                {
                    adressExists = true;
                    break;
                }
            }

            SqlParameter[] parameters;
            /* If adress does not exsist, add adress*/
            if (!adressExists)
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Postnummer", postalCode),
                    new SqlParameter("@Gatuadress", adress),
                    new SqlParameter("@Postort", city), 
                };

                commandText = "INSERT INTO Adress(Postnummer, Gatuadress, Postort) " + "values(@Postnummer, @Gatuadress, @Postort);";

                dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
            }

            /* Add to adressregister */
            parameters = new SqlParameter[]
            {
                new SqlParameter("@FK_Id", Id),
                new SqlParameter("@FK_Postnummer", postalCode),
                new SqlParameter("@FK_Gatuadress", adress), 
            };

            commandText = "INSERT INTO Adressregister(FK_Id, FK_Postnummer, FK_Gatuadress) " + "values(@FK_Id, @FK_Postnummer, @FK_Gatuadress);";

            dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);

        }
    }
}
