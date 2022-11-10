using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace RM_App.Backend_classes.Model
{
    internal class RelationshipManager : User
    {
        private string email;
        private string firstName;
        private string lastName;
     

        //RM object will call the user parent class as a base constructor
        public RelationshipManager(string firstName, string lastName, string email)
                                    : base(firstName, lastName, email)
        {

          
        }

        public string Email { get => email; set => email = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
       
    }
}
