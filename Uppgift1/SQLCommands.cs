using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift1.DAL;

namespace Uppgift1
{
    static class SQLCommands
    {

        public static DataSet LoadAdresses()
        {
            var dataAccess = new DataAccess();
            var commandText = "Select Postnummer, Gatuadress, Postort FROM Adress " +
                              "ORDER BY Postnummer;";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);
        }

        public static DataSet LoadPhonenumbers()
        {
            var dataAccess = new DataAccess();
            var commandText = "Select Nummer FROM Telefonnummer;";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);
        }

        public static bool DoesAdressExsist(DataAccess dataAccess, string postalCode, string adress)
        {
            DataSet dataSet = LoadAdresses();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if ((string)dataSet.Tables[0].Rows[i][0] == postalCode &&
                    (string)dataSet.Tables[0].Rows[i][1] == adress)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CreateAdressInDatabase(DataAccess dataAccess, string postalCode, string adress, string city)
        {
            if (DoesAdressExsist(dataAccess, postalCode, adress))
                return false;

            SqlParameter[] parameters =
            {
                new SqlParameter("@Postnummer", postalCode),
                new SqlParameter("@Gatuadress", adress),
                new SqlParameter("@Postort", city),
            };

            string commandText = "INSERT INTO Adress(Postnummer, Gatuadress, Postort) " + "values(@Postnummer, @Gatuadress, @Postort);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        public static bool AddAdressToAdressregister(DataAccess dataAccess, string postalCode, string adress,
            string city, int Id)
        {
            CreateAdressInDatabase(dataAccess, postalCode, adress, city);

            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", Id),
                new SqlParameter("@FK_Postnummer", postalCode),
                new SqlParameter("@FK_Gatuadress", adress),
            };

            string commandText = "INSERT INTO Adressregister(FK_Id, FK_Postnummer, FK_Gatuadress) " + 
                "values(@FK_Id, @FK_Postnummer, @FK_Gatuadress);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        public static bool DeleteAdress(DataAccess dataAccess, string postalCode, string adress)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Postnummer", postalCode),
                new SqlParameter("@Gatuadress", adress),
            };

            var command = "DELETE FROM Adress where Postnummer = @Postnummer " +
                           "AND Gatuadress = @Gatuadress;";

            return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);
        }

        public static bool DeletePhonenumber(DataAccess dataAccess, string phonenumber)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nummer", phonenumber),
            };

            var command = "DELETE FROM Telefonnummer where Nummer = @Nummer;";

            return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);
        }

        public static bool DeletePerson(DataAccess dataAccess, int id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id),
            };

            var command = "DELETE From ÖvrigKontakt WHERE FK_Id = @Id;";
            command += "DELETE From JobbKontakt WHERE FK_Id = @Id;";
            command += "DELETE From PersonligKontakt WHERE FK_Id = @Id;";
            command += "DELETE FROM Person where Id = @Id;";

           return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);
        }
        
        public static bool DoesPhoneNumberExsist(DataAccess dataAccess, string phoneNumber)
        {
            DataSet dataSet = LoadPhonenumbers();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if ((string)dataSet.Tables[0].Rows[i][0] == phoneNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CreatePhoneNumberInDatabase(DataAccess dataAccess, string phoneNumber)
        {
            if (DoesPhoneNumberExsist(dataAccess, phoneNumber))
                return false;

            SqlParameter[] parameters =
            {
                new SqlParameter("@Nummer", phoneNumber),
            };

            string commandText = "INSERT INTO Telefonnummer(Nummer) " + "values(@Nummer);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        public static DataSet LoadPersons(string searchWord, bool jobbKontakt, bool personligKontakt, bool övrigKontakt)
        {
            var dataAccess = new DataAccess();
            var commandText = "Select p.Id, p.Namn, p.Epost FROM Person p";
            if (jobbKontakt)
                commandText += " RIGHT JOIN JobbKontakt on p.Id = JobbKontakt.FK_Id";
            if (personligKontakt)
                commandText += " RIGHT JOIN PersonligKontakt on p.Id = PersonligKontakt.FK_Id";
            if (övrigKontakt)
                commandText += " RIGHT JOIN ÖvrigKontakt on p.Id = ÖvrigKontakt.FK_Id";
            commandText += " where p.Namn like('%" + searchWord + "%');";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);
        }
        
    }
}
