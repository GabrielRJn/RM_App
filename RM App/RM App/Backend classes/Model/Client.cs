using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_App.Backend_classes.Model
{
    internal class Client
    {
        //data to be created/updated/deleted from database
        private string firstName;
        private string lastName;
        private string email;
        private List<string> prefferedTags;
        private List<string> products;

        public Client(string firstName, string lastName, string email,
                        List<string> prefferedTags, List<string> products)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.prefferedTags = prefferedTags;
            this.products = products;
        }

        public Client (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
