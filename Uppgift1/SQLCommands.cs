﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Uppgift1.DAL;

namespace Uppgift1
{
    static class SQLCommands
    {

        /* ------------------------ Metoder för person ------------------------------------------------*/

        public static bool CreatePerson(DataAccess dataAccess, string namn, string epost)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            string insertCommand = "INSERT INTO Person(Namn";
            string valueCommand = "VALUES(@Namn";

            parameters.Add(new SqlParameter("@Namn", namn));

            if (!string.IsNullOrEmpty(epost))
            {
                insertCommand += ", Epost";
                valueCommand += ", @Epost";
                parameters.Add(new SqlParameter("@Epost", epost));
            }

            insertCommand += ") ";
            valueCommand += ");";

            var command = insertCommand + valueCommand;

            return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters.ToArray());
        }

        public static bool DoesPersonExist(DataAccess dataAccess, int id)
        {
            DataSet dataSet = LoadPersons(id, "", "");

            return dataSet.Tables[0].Rows.Count > 0;
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
            if (name.Length < 1)
                return false;

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@Namn", name),
            };

            string commandText = "UPDATE Person Set Namn = @Namn where Id = @id";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        public static bool PersonIsJobbKontakt(DataAccess dataAccess, int id)
        {
            var commandText = "Select * from JobbKontakt where FK_Id = " + id + ";";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text).Tables[0].Rows.Count > 0;
        }

        public static bool PersonIsPersonligKontakt(DataAccess dataAccess, int id)
        {
            var commandText = "Select * from PersonligKontakt where FK_Id = " + id + ";";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text).Tables[0].Rows.Count > 0;
        }

        public static bool PersonIsÖvrigKontakt(DataAccess dataAccess, int id)
        {
            var commandText = "Select * from ÖvrigKontakt where FK_Id = " + id + ";";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text).Tables[0].Rows.Count > 0;
        }

        public static bool ChangeKontakt(DataAccess dataAccess, int id, bool isJobb, bool isPersonlig, bool isÖvrig)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", id),
            };

            var commandText = "DELETE FROM ÖvrigKontakt where FK_Id = @FK_id; ";
            commandText += "DELETE FROM PersonligKontakt where FK_Id = @FK_id; ";
            commandText += "DELETE FROM JobbKontakt where FK_Id = @FK_id; ";
            //dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
            if (isÖvrig)
                commandText += " INSERT INTO ÖvrigKontakt(FK_Id) VALUES(@FK_Id);";
            if(isPersonlig)
                commandText += " INSERT INTO PersonligKontakt(FK_Id) VALUES(@FK_Id);";
            if(isJobb)
                commandText += " INSERT INTO JobbKontakt(FK_Id) VALUES(@FK_Id);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        /* ----------------------- Metoder för att ändra adress och adressregister ---------------------*/
        public static DataSet LoadAdresses()
        {
            var dataAccess = new DataAccess();
            var commandText = "Select Postnummer, Gatuadress, Postort FROM Adress " +
                              "ORDER BY Postnummer;";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);
        }

        public static DataSet LoadAdress(string searchWord)
        {
            var dataAccess = new DataAccess();
            var commandText = "Select a.Postnummer, a.Gatuadress, a.Postort From Adress a";

            commandText += " where a.Postort like('%" + searchWord + "%');";

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

        public static bool CreateAdressInRegister(DataAccess dataAccess, string postalCode, string adress,
            string city, int id)
        {
            if (!DoesPersonExist(dataAccess, id))
                return false;

            if (!CreateAdressInDatabase(dataAccess, postalCode, adress, city))
            {
                //Man kan behöva uppdatera postort i databas
                UpdatePostort(dataAccess, postalCode, adress, city);
            }

            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", id),
                new SqlParameter("@FK_Postnummer", postalCode),
                new SqlParameter("@FK_Gatuadress", adress),
            };

            DeleteAdressInRegister(dataAccess, postalCode, adress, id);
            var commandText = "insert into Adressregister(FK_Id, FK_Postnummer, FK_Gatuadress) " +
                           "values(@FK_id, @FK_Postnummer, @FK_Gatuadress);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        public static bool DeleteAdressInRegister(DataAccess dataAccess, string postalCode,
            string adress, int id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Id", id),
                new SqlParameter("@FK_Postnummer", postalCode),
                new SqlParameter("@FK_Gatuadress", adress),
            };

            var commandText = "delete from Adressregister where " +
                              "FK_id = @FK_Id and FK_Postnummer = @FK_Postnummer " +
                              "and FK_Gatuadress = @FK_Gatuadress;";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }

        /*
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
        }*/

        public static bool ChangePersonAdress(DataAccess dataAccess, string oldPostalCode, string oldAdress, string oldCity,
            string newPostalCode, string newAdress, string newCity, int id)
        {
            DeleteAdressInRegister(dataAccess, oldPostalCode, oldAdress, id);

           // return AddAdressToAdressregister(dataAccess, newPostalCode, newAdress, newCity, id);
           return CreateAdressInRegister(dataAccess, newPostalCode, newAdress, newCity, id);
        }

        public static bool UpdatePostort(DataAccess dataAccess, string postalCode, string adress, string city)
        {
            if (city.Length < 1)
                return false;

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

        /* ---------------------- Metoder för ändra telefonnummer och telefonlista -------------- */

        public static DataSet LoadPhonenumbers()
        {
            var dataAccess = new DataAccess();
            var commandText = "Select Nummer as varchar FROM Telefonnummer;";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);
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

        public static bool DeletePhonenumber(DataAccess dataAccess, string phonenumber)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nummer", phonenumber),
            };

            var command = "DELETE FROM Telefonnummer where Nummer = @Nummer;";

            return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);
        }

        public static bool DoesPersonHavePhone(DataAccess dataAccess, int id, string phoneNumber)
        {
            var commandText = "Select * from Telefonlista " +
                              "where FK_Id = " + id + " and FK_Nummer = " + phoneNumber + ";";

            return dataAccess.ExecuteSelectCommand(commandText, CommandType.Text)
                .Tables[0].Rows.Count > 0;
        }

        public static bool AddPhonenumberToPhonelist(DataAccess dataAccess, string phoneNumber, int Id)
        {
            if(!DoesPersonExist(dataAccess, Id))
                return false;

            if (phoneNumber.Length == 0)
            {
                DeletePhonenumberFromList(dataAccess, phoneNumber, Id);
                return true;
            }


            /* Add to phonelist */
            SqlParameter[] parameters =
            {
                new SqlParameter("@FK_Nummer", phoneNumber),
                new SqlParameter("@FK_Id", Id),
            };
            
            //TODO Det kraschar när telefonnummer är tomt, måste ta bort nummer eller uppdatera
            //DeletePhonenumberFromList(dataAccess, phoneNumber, Id);
            var commandText = "INSERT INTO Telefonlista(FK_Nummer, FK_Id) " + "values(@FK_Nummer, @FK_Id);";

            return dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);

        }

        public static bool DeletePhonenumberFromList(DataAccess dataAccess, string phonenumber, int id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nummer", phonenumber),
                new SqlParameter("@Id", id), 
            };

            var command = "DELETE FROM Telefonlista where FK_Nummer = @Nummer " +
                          "and FK_Id = @Id;";

            return dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);
        }

        public static bool UpdatePhonenumber(DataAccess dataAccess, int id, string oldPhoneumber, string newPhonenumber)
        {
            if (newPhonenumber.Length < 1)
            {
                return DeletePhonenumberFromList(dataAccess, oldPhoneumber, id);
            }

            //Try to create phonnumber in database
            CreatePhoneNumberInDatabase(dataAccess, newPhonenumber);
            
            /*Borde vara kolla om nummer finns och isåfall köra update */
            /*Har ej fått detta att fungera */
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nummer", newPhonenumber),
                new SqlParameter("@Id", id),
                new SqlParameter("@OldNummer", oldPhoneumber),
            };

            //string commandText = "DELETE FROM Telefonlista where FK_Nummer = @OldNummer; " +
            //                     "DELETE FROM Telefonlista where FK_Nummer = @Nummer; " +
            //                     "INSERT INTO Telefonlista(FK_Nummer, FK_Id) VALUES(@Nummer, @Id);";

            string commandText = "DELETE FROM Telefonlista where FK_Nummer = @OldNummer;";

            dataAccess.ExecuteNonQuery(commandText, CommandType.Text, parameters);

            return AddPhonenumberToPhonelist(dataAccess, newPhonenumber, id);
        }

    }
}
