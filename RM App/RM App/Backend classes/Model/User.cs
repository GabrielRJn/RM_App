using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_App.Backend_classes.Model
{
    internal abstract class User
    {
        // Parent class of Client and Relationship Manager

        private string firstName;
        private string lastName;
        private string email;
      

        public User(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public User()
        {

        }

 
    }
}
