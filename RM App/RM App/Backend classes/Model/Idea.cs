using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_App.Backend_classes.Model
{
    internal class Idea
    {
        //data to be created/updated/deleted from database
        private string name;
        private string description;
        private decimal riskLevel;
        private List<String> tags;
        private DateTime timeCreated;

        public Idea(string name, string description, decimal riskLevel, 
                    List<string> tags, DateTime timeCreated)
        {
            this.Name = name;
            this.Description = description;
            this.RiskLevel = riskLevel;
            this.Tags = tags;
            this.TimeCreated = timeCreated;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal RiskLevel { get => riskLevel; set => riskLevel = value; }
        public List<string> Tags { get => tags; set => tags = value; }
        public DateTime TimeCreated { get => timeCreated; set => timeCreated = value; }
    }
}
