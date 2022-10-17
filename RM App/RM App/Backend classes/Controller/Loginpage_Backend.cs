using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM_App_Backend;
using System.Windows.Forms;
using RM_App_FrontEnd;

namespace RM_App.Backend_classes.Controller
{
    internal class Loginpage_Backend
    {
        public static void findUser(Login_page instance, String email, String password)
            //passing in the current instance of the loginpage (instance) textbox text to manipulate
        {
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

            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
            {

            }
        }
    }
}
