using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RM_App.Backend_classes.Model
{
    internal class Client : User
    {

        /*
         * A singleton pattern will be used so that one client object absorbs form data entered on the front end and passes it to the
         * services class that will save the client data
         */
        private static Client clientInstance;

        //client fields
        private int clientID;
        private string firstName;
        private string lastName;
        private string email;
        private int rmID;
        private List<string> preferredTags;
        private List<string> products;

        public Client(int clientID, string firstName, string lastName, string email, int rmID,
            List<string> preferredTags, List<string> products) : base(firstName, lastName, email)
        {
            this.clientID = clientID;
            this.rmID = rmID;
            this.preferredTags = preferredTags;
            this.products = products;
        }

      public Client() : base()
        {

        }

        public Client(string firstName, string lastName, string email) :base(firstName, lastName, email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        

        //client singleton
        public static Client getClientInstance() { 
            if(clientInstance == null)
            {
                clientInstance = new Client();
            }
            return clientInstance;
        }

        public int ClientID { get => clientID; set => clientID = value; }
        
        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int RmID { get => rmID; set => rmID = value; }
        public List<string> PrefferedTags { get => preferredTags; set => preferredTags = value; }
        public List<string> Products { get => products; set => products = value; }
    }
}
