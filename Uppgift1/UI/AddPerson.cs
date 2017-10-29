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
            }
        }

        private bool CreatePerson(DataAccess dataAccess)
        {
            /* Add persons */
            string Namn = NamnTextbox.Text;
            string Telefon = TelefonTextbox.Text;
            string Epost = EpostTextbox.Text;

            List<SqlParameter> parameters = new List<SqlParameter>();

            string insertCommand = "Insert Into Person(Namn";
            string valueCommand = "values(@Namn";

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

            //SqlParameter[] parameters =
            //{
            //    new SqlParameter("@Namn", Namn),
            //    new SqlParameter("@Telefon", Telefon),
            //    new SqlParameter("@Epost", Epost),
            //};

            //var command = "Insert Into Person(Namn, Telefon, Epost) " +
            //              "values(@Namn, @Telefon, @Epost);";

            var command = insertCommand + valueCommand;

            return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters.ToArray());
        }
    }
}
