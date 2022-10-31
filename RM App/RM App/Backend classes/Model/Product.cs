using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_App.Backend_classes.Model
{
    internal class Product
    {
        private int id;
        private string name;
        private string description;
        private int tagID;

    
        public Product (int id, string name, string description, int tagID)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.tagID = tagID;

        }

    }
}
