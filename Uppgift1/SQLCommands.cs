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

        public static bool CreateAdressInRegister(DataAccess dataAccess, string postalCode, string adress, 
            string city, int id)
        {
            if (!DoesPersonExist(dataAccess, id))
                return false;

            CreateAdressInDatabase(dataAccess, postalCode, adress, city);

            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", id),
                new SqlParameter("@FK_Postnummer", postalCode),
                new SqlParameter("@FK_Gatuadress", adress),
            };

            var commandText = "delete from Adressregister where " +
                "FK_id = @FK_Id and FK_Postnummer = @FK_Postnummer " +
                "and FK_Gatuadress = @FK_Gatuadress;";
            commandText += " insert into Adressregister(FK_Id, FK_Postnummer, FK_Gatuadress) " +
                           "values(@FK_id, @FK_Postnummer, @FK_Gatuadress);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
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

        public static bool UpdatePostort(DataAccess dataAccess, string postalCode, string adress, string city)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Postnummer", postalCode),
                new SqlParameter("@Gatuadress", adress),
                new SqlParameter("@Postort", city),
            };

            var commandText = "UPDATE Adress set Postort = @Postort " +
                              "Where Postnummer = @Postnummer and Gatuadress = @Gatuadress;";

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

        public static bool DoesPersonExist(DataAccess dataAccess, int id)
        {
            DataSet dataSet = LoadPersons(id, "", "");

            return dataSet.Tables[0].Rows.Count > 0;
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

        public static bool AddPhonenumberToPhonelist(DataAccess dataAccess, string phoneNumber, int Id)
        {
            if(!DoesPersonExist(dataAccess, Id))
                return false;

            /* Add to phonelist */
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Nummer", phoneNumber),
                new SqlParameter("@FK_Id", Id),
            };

            var commandText = "INSERT INTO Telefonlista(FK_Nummer, FK_Id) " + "values(@FK_Nummer, @FK_Id);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
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

        //public static bool DeletePerson(DataAccess dataAccess, int id, string jobb)
        //{
        //    SqlParameter[] parameters =
        //    {
        //        new SqlParameter("@Id", id),
        //    };

        //    var command = "DELETE From ÖvrigKontakt WHERE FK_Id = @Id;";
        //    command += "DELETE From JobbKontakt WHERE FK_Id = @Id;";
        //    command += "DELETE From PersonligKontakt WHERE FK_Id = @Id;";
        //    command += "DELETE FROM Person where Id = @Id;";

        //    return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);
        //}

        public static bool UpdatePhonenumber(DataAccess dataAccess, int id, string oldPhoneumber, string newPhonenumber)
        {
            //Try to create phonnumber in database
            CreatePhoneNumberInDatabase(dataAccess, newPhonenumber);

            if (!string.IsNullOrEmpty(oldPhoneumber) && DoesPersonHavePhone(dataAccess, id, oldPhoneumber))
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Nummer", newPhonenumber),
                    new SqlParameter("@Id", id),
                };

                string commandText = "UPDATE Telefonlista Set FK_Nummer = @Nummer where FK_Id = @Id;";

                return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
            }
            else
            {
                return AddPhonenumberToPhonelist(dataAccess, newPhonenumber, id);
            }
        }

        public static bool DoesPersonHavePhone(DataAccess dataAccess, int id, string phoneNumber)
        {
            var commandText = "Select count(FK_ID) from Telefonlista " +
                              "where FK_Id = " + id + " and FK_Nummer = " + phoneNumber + ";";

            return (int)dataAccess.ExecuteSelectCommand(commandText, CommandType.Text).Tables[0].Rows[0][0] > 0;
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

        public static DataSet LoadPersons(int Id, string postalCode, string street)
        {
            var dataAccess = new DataAccess();
            var commandText =
                "SELECT p.Id, p.Namn, p.Epost, Telefonnummer.Nummer, Postnummer, Gatuadress, Postort FROM Person p " +
                "LEFT JOIN Telefonlista ON p.Id = Telefonlista.FK_Id " +
                "LEFT JOIN Telefonnummer ON Telefonlista.FK_Nummer = Telefonnummer.Nummer " +
                "LEFT JOIN Adressregister ON p.Id = Adressregister.FK_Id " +
                "LEFT JOIN Adress ON Adressregister.FK_Postnummer = Adress.Postnummer AND " +
                "Adressregister.FK_Gatuadress = Adress.Gatuadress ";

            if (Id > 0)
            {
                commandText += "where p.ID = " + Id;
                if (postalCode.Length > 0)
                {
                    commandText += " and Adress.Postnummer = '" + postalCode + "'";
                    commandText += " and Adress.Gatuadress = '" + street + "'";
                }
            }
            else
            {
                if (postalCode.Length > 0)
                {
                    commandText += " where Adress.Postnummer = '" + postalCode + "'";
                    commandText += " and Adress.Gatuadress = '" + street + "'";
                }
            }

            commandText += ";";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);
        }

        public static DataSet LoadPersonsWithAdress(string searchWordNamn, string searchWordOrt
            , bool jobbKontakt, bool personligKontakt, bool övrigKontakt)
        {
            var dataAccess = new DataAccess();
            var commandText = "SELECT p.Id, p.Namn, Postnummer, Gatuadress, Postort " +
                              "FROM Person p " +
                              "LEFT JOIN Adressregister ON p.Id = Adressregister.FK_Id " +
                              "LEFT JOIN Adress ON Adressregister.FK_Postnummer = Adress.Postnummer AND " +
                              "Adressregister.FK_Gatuadress = Adress.Gatuadress ";
            if (jobbKontakt)
                commandText += "RIGHT JOIN JobbKontakt on p.Id = JobbKontakt.FK_Id ";
            if (personligKontakt)
                commandText += "RIGHT JOIN PersonligKontakt on p.Id = PersonligKontakt.FK_Id ";
            if (övrigKontakt)
                commandText += "RIGHT JOIN ÖvrigKontakt on p.Id = ÖvrigKontakt.FK_Id ";

            commandText += "where p.Namn like('%" + searchWordNamn + "%') and " +
                           "Postort like('%" + searchWordOrt + "%');";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);
        }

        public static DataSet LoadAdress(string searchWord)
        {
            var dataAccess = new DataAccess();
            var commandText = "Select a.Postnummer, a.Gatuadress, a.Postort From Adress a";

            commandText += " where a.Postort like('%" + searchWord + "%');";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);
        }

        
        
        public static bool UpdateEpost(DataAccess dataAccess, int id, string Epost)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id), 
                new SqlParameter("@Epost", Epost),
            };

            string commandText = "UPDATE Person Set Epost = @Epost where Id = @id";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        public static bool UpdateNamn(DataAccess dataAccess, int id, string name)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@Namn", name),
            };

            string commandText = "UPDATE Person Set Namn = @Namn where Id = @id";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

    }
}
