using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM_App_Backend;
using System.Windows.Forms;
using RM_App_FrontEnd;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.CodeDom;
using RM_App.Backend_classes.Model;
using System.Drawing;

namespace RM_App.Backend_classes.Controller
{

   
    internal class Loginpage_Backend
    {
        static Boolean loggedIn = false;

        //used to load profile details when logged in
        public static string fetchedFullName;
        public static string fetchedFirstName;
        public static string fetchedEmailAddress;

        public static void findUser( Login_page instance, String email, String password)
        //passing in the current instance of the loginpage (instance) textbox text to manipulate
        {    
            fetchedFullName = null;
            Connection con = Connection.getDBConnection();
            

            /*Count the number of results found for the text entered into the textbox. 
             *If the user enters the correct username and password, there will be an exact match from the
             *query, resulting in the if statement being true.
             */

            DataSet result = con.getDataSet("SELECT Count(*) FROM rm_data WHERE email='" + email + "'AND password = '" + password + "'");
            if (result.Tables[0].Rows[0][0].Equals(1))
            {
               
                
             


                instance.Hide();
                MessageBox.Show("Login page is working");
                //for testing purposes
                // DataSet user = con.getDataSet("SELECT * FROM rm_data WHERE email'" + email + "'");

                //get the first name and last name of the user where entered email text is equal to email

                DataSet details = con.getDataSet("SELECT rm_data.first_name, rm_data.last_name FROM rm_data");
                fetchedFullName = details.Tables[0].Rows[0][0].ToString() + " " + details.Tables[0].Rows[0][1].ToString();
                fetchedEmailAddress = email;
                loggedIn = true;
                
                Clients_page clientPage = new Clients_page();
                clientPage.Show();


                /*
                 * Until the homepage is made/functioning, it will directly load to the 
                 * 'All Clients page' -GJ
                 */


            } else
            {
                MessageBox.Show("email or password is incorrect");
                result = null;
            }
            {

            }
        }



       

        public static void showText(TextBox textBox2)
        {
            textBox2.PasswordChar = (char) 0;
        }
    }

}
