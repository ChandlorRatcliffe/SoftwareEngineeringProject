using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class Organization
    {
        string name, license;
        DateTime activation;
        DateTime expiration;
        public Organization(string name, string license)
        {
            this.name = name;
            this.license = license;
            Random rand = new Random();
            

            DateTime temp = new DateTime(1993, 11, 16);
            int limit = (DateTime.Today - temp).Days;
            this.activation = temp.AddDays(rand.Next(limit));
            this.expiration = temp.AddDays(rand.Next(365, 365 * 5 + 1));
        }

        public string getAddTupleQuerryString()
        {
            return "(\"" + this.name + "\",\"" +  this.license + "\",\"" + this.activation + "\",\"" +  this.expiration.ToString("yyyy-MM-dd HH:mm:ss") + "\")";
        }
    }
}
