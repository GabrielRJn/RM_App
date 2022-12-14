using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM_App.Backend_classes.Model;
using RM_App_Backend;

namespace RM_App.Backend_classes.Service
{
    internal class ClientService
    {
     

        public static DataTable getAllClients()
        {
            
            DataSet clientResults = Connection.getDBConnection().getDataSet("SELECT * FROM clients");
            return clientResults.Tables[0];

        }

        public static DataTable alphabeticalgetAllClients()
        {

            DataSet clientAlphabetResults = Connection.getDBConnection().getDataSet("SELECT * FROM clients ORDER BY first_name ASC");
            return clientAlphabetResults.Tables[0]; 

        }

        public static DataTable findClientName(String searchQuery)
        {
            DataSet clientNameResults = Connection.getDBConnection().getDataSet("SELECT * FROM clients WHERE first_name LIKE '%" + searchQuery + "%'" + "ORDER BY first_name DESC");
            return clientNameResults.Tables[0];
        }


        public static void insertClientData(Client newClient)
        {
            /*Responsible for passing client specific queries to the SQL connection after retrieving
            / a client object
            */
            string cmd = "INSERT INTO clients" +
                " (first_name, last_name, email) " +
                "VALUES ('"+newClient.FirstName+"','"+newClient.LastName+"','"+newClient.Email+"')";


            Connection.saveOrUpdateData(cmd);
            MessageBox.Show("Client added");

        }
   
            

        }
            
}
