using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM_App.Backend_classes.Model;

namespace RM_App_Backend
{
   

    internal class Connection
    {
        private static Connection conInstance;
        private static string conString;
        private static SqlConnection conToDB;

        private Connection()
        {
            conString = RM_App.Properties.Settings.Default.RM_data;

        }

        public static string ConString { get => conString; set => conString = value; }
        internal static Connection ConInstance { get => conInstance; set => conInstance = value; }
        public SqlConnection ConToDB { get => conToDB; set => conToDB = value; }

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

        /*we need a similar method that does not return any dataset for when
         * we are only saving or updating data in the database
         */
        public static void saveOrUpdateData( Client newClient)
        {
            using (conToDB = new SqlConnection(conString))
            {

                conToDB.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO clients" +
                 " (first_name, last_name, email) " +
                 "VALUES ('" + newClient.FirstName + "','" + newClient.LastName + "','" + newClient.Email + "')", conToDB);
                cmd.ExecuteNonQuery();
                conToDB.Close();
                MessageBox.Show("client added");

            }
        }
    }
}
