using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_App_Backend
{
   

    internal class Connection
    {
        private static Connection conInstance;
        private static string conString;
        private SqlConnection conToDB;

        private Connection()
        {
            conString = RM_App.Properties.Settings.Default.RM_data;

        }

        public static Connection getDBConnection()
        {
            if(conInstance == null)
                conInstance = new Connection();
            return conInstance;
        }

        public DataSet getDataSet(string query)
        {
            DataSet dataSet = new DataSet();

            using (conToDB = new SqlConnection(conString))
            {
                conToDB.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, conToDB);
                adapter.Fill(dataSet);
                conToDB.Close();
            }
            return dataSet;

        }
    }
}
