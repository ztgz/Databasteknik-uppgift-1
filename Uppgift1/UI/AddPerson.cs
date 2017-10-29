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
                if (!string.IsNullOrEmpty(PostnummerTextbox.Text) && !string.IsNullOrEmpty(GatuadressTextbox.Text))
                {
                    CreateJobbKontakt(dataAccess, Id);
                }
            }
        }

        private int GetIdOfLastPersonInList(DataAccess dataAccess)
        {
            DataSet dataSet = new DataSet();

            var commandText = "Select TOP 1 Id, Namn, Telefon, Epost FROM Person " +
                              "ORDER BY Id DESC;";
            dataSet = dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);

            return int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
        }

        private bool CreatePerson(DataAccess dataAccess)
        {
            /* Add persons */
            string Namn = NamnTextbox.Text;
            string Telefon = TelefonTextbox.Text;
            string Epost = EpostTextbox.Text;

            List<SqlParameter> parameters = new List<SqlParameter>();

            string insertCommand = "INSERT INTO Person(Namn";
            string valueCommand = "VALUES(@Namn";

            parameters.Add(new SqlParameter("@Namn", Namn));

            if (!String.IsNullOrEmpty(Telefon))
            {
                insertCommand += ", Telefon";
                valueCommand += ", @Telefon";
                parameters.Add(new SqlParameter("@Telefon", Telefon));
            }

            if (!string.IsNullOrEmpty(Epost))
            {
                insertCommand += ", Epost";
                valueCommand += ", @Epost";
                parameters.Add(new SqlParameter("@Epost", Epost));
            }
            
            insertCommand += ") ";
            valueCommand += ");";

            var command = insertCommand + valueCommand;

            return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters.ToArray());
        }

        private bool CreateJobbKontakt(DataAccess dataAccess, int Id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", Id), 
            };

            var commandText = "INSERT INTO JobbKontakt(FK_Id) " +
                              "VALUES(@FK_Id);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        private bool CreatePersonligKontakt(DataAccess dataAccess, int Id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", Id),
            };

            var commandText = "INSERT INTO PersonligKontakt(FK_Id) " +
                              "VALUES(@FK_Id);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        private bool CreateÖvrigKontakt(DataAccess dataAccess, int Id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", Id),
            };

            var commandText = "INSERT INTO ÖvrigKontakt(FK_Id) " +
                              "VALUES(@FK_Id);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

    }
}
