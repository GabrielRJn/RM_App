using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using RM_App.Backend_classes.Model;
using RM_App.Backend_classes.Repository;
using RM_App.Backend_classes.Service;
using RM_App_Backend;
using RM_App_FrontEnd;

namespace RM_App.Backend_classes.Controller
{
    internal class Clientpage_Backend
    {

      

        
        public static void saveClient(string firstName, string lastName, string email)
        {
            Client savedClient = new Client(firstName, lastName, email);
            Connection.saveOrUpdateData(savedClient);
            
        }
        public static void checkEnteredEmail(string email, Clients_page label)
        {//checks if a valid email is entered
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = emailRegex.Match(email);
            if (!match.Success)
            {
                label.Text = "*You have not entered an email";
            }
        }

    }
}
