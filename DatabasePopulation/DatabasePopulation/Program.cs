using System;

namespace DatabasePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLInterface sql = new SQLInterface();
            sql.reset();
            sql.generateAccounts(500);
            sql.generateOrganizations(500);
            sql.generateProjects(500);
        }
    }
}
