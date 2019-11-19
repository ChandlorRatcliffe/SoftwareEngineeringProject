using System;
using System.Collections.Generic;

namespace DatabasePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLInterface sql = new SQLInterface();
            sql.reset();
            sql.generateCreateSets(125);
        }
    }
}
