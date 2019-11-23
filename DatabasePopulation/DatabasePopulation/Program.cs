using System;
using System.Collections.Generic;

namespace DatabasePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make an interface.
            SQLInterface sql = new SQLInterface();
            //Clear the Database.
            sql.reset();
            //Populate the Database.
            sql.generateCreateSets(125);
        }
    }
}
