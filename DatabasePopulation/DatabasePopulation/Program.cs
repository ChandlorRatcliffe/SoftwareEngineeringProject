using System;
using System.Collections.Generic;

namespace DatabasePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make an interface.
            //SQLInterface sql = new SQLInterface();
            //Clear the Database.
            //sql.reset();
            //Populate the Database.
            //sql.generateCreateSets(125);
            List<TaskTree> test = new List<TaskTree>();
            for(int i = 0; i< 20; i++)
                test.Add(new TaskTree(new WordListManager(), DateTime.Today, "Hogwash"));
            foreach(TaskTree tree in test)
                Console.WriteLine(tree.printTree());
        }
    }
}
