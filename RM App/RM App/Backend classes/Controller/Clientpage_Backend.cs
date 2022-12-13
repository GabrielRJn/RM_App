using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using RM_App.Backend_classes.Model;
using RM_App.Backend_classes.Repository;
using RM_App.Backend_classes.Service;
using RM_App_Backend;
using RM_App_FrontEnd;
using Label = System.Windows.Forms.Label;

namespace RM_App.Backend_classes.Controller
{
    internal class Clientpage_Backend
    {
        static Boolean validEmail = false;


        /*
         * Data from the front end is saved to a client object and this client object will transfer
         * data into an SQL query. Only one client object is required for the entire application to have
         * this functionality, using many objects may impact performance - GJ
         */

        public static void loadProfile(LinkLabel fullName, Label email )
        {
            fullName.Text = Loginpage_Backend.fetchedFullName;
            email.Text = Loginpage_Backend.fetchedEmailAddress;
        }
        public static void saveClient(string firstName, string lastName, string email)
        {
            if (validEmail)
            {

                
                Client savedClient = new Client(firstName, lastName, email);
                ClientService.insertClientData(savedClient);
            }
            else
            {
                MessageBox.Show("Some fields are incorrect");
            }
            
        }

        /*
         * This regex can be used to make the application more user friendly. If the user (the RM)
         * does not enter a email when registering a new client to the system, the application can issue
         * an error message. -GJ 
         */
       
        public static void checkEnteredEmail(string email, Label label)
        {
            //checks if a valid email is entered

            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = emailRegex.Match(email);
            if (!match.Success)
            {
                validEmail = false;
                label.Text = "You have not entered an email";
            }
            else
            {
                label.Hide();
                validEmail = true;
            }
        }

    }
}
