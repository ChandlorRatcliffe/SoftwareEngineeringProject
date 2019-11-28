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
                test.Add(new TaskTree(new WordListManager(), DateTime.Today, "Hogwash", "\"1\""));
            string s = "";
            string b = "";
            string t = "";
            foreach (TaskTree tree in test)
            {
                Console.WriteLine(tree.printTree());
                s += tree.getParentAddTupleString();
                b += tree.getBuiltOnTupleString() + ",";
                t += tree.getTaskAddTupleString() + ",";
            }
            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine(t);
        }
    }
}
