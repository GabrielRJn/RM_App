using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM_App.Backend_classes.Model;
using RM_App_Backend;

namespace RM_App.Backend_classes.Service
{
    internal class IdeaService
    {
        /*
         * All queries to manipulate (retrieve, update, delete) data in the ideas table will be in 
         * this class to pass to the SQL connection.
         * [The purpose of this class is to improve structure and further isolate model specific methods.
         *  
         *  More information on MVC service classes can be found here:
         *  https://nbarbettini.gitbooks.io/little-asp-net-core-book/content/chapters/mvc-basics/add-service-class.html  ]
         */

        public static void insertIdea(Idea idea)
        {
            string cmd = "INSERT INTO ideas" +
             " (Name, Description, Risk_level) " +
             "VALUES ('" + idea.Name + "','" + idea.Description + "','" + idea.RiskLevel+ "')";
            Connection.saveOrUpdateData(cmd);
            MessageBox.Show("Idea added");

        }
        
    }
}
