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

            DataSet ds = Connection.getDBConnection().getDataSet("SELECT * FROM clients");
            return ds.Tables[0];

        }

        public static void insertClientData(Client newClient)
        {
                
            string cmd = "INSERT INTO clients" +
                " (first_name, last_name, email) " +
                "VALUES ('"+newClient.FirstName+"','"+newClient.LastName+"','"+newClient.Email+"')";


            Connection.saveOrUpdateData(cmd);
            MessageBox.Show("Client added");

        }
   
            

        }
            
}
