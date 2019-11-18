using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class Organization
    {
        string name, license;
        int activation;
        DateTime expiration;
        public Organization(string name, string license)
        {
            this.name = name;
            this.license = license;
            Random rand = new Random();
            this.activation = rand.Next(20)%2 == 0 ? 1 : 0;

            DateTime temp = new DateTime(1993, 11, 16);
            int limit = (DateTime.Today - temp).Days;
            this.expiration = temp.AddDays(rand.Next(limit));
        }

        public string getAddTupleQuerryString()
        {
            return "(\"" + this.name + "\",\"" +  this.license + "\",\"" + this.activation + "\",\"" +  this.expiration.ToString("yyyy-MM-dd HH:mm:ss") + "\")";
        }
    }
}
