﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            var commandText = "Select Postnummer, Gatuadress, Postort FROM Adress;";

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

    }
}