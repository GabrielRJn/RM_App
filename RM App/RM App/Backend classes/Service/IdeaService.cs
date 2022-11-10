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
