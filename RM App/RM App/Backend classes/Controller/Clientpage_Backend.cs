using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using RM_App.Backend_classes.Repository;
using RM_App_Backend;

namespace RM_App.Backend_classes.Controller
{
    internal class Clientpage_Backend
    {

        public static DataTable getAllClients()
        {

            DataSet ds = Connection.getDBConnection().getDataSet("SELECT * FROM clients");
            return ds.Tables[0]; 
            
           
            
        }
    }
}
