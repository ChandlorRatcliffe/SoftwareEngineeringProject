using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class TaskTree
    {
        static Random rand = new Random();
        WordListManager words;
        List<TaskTree> subTasks;
        Task task;
        //Time to make a new Task Tree!
        public TaskTree(WordListManager words, DateTime deadline, string description)
        {
            this.words = words;
            this.task  = new Task(description, deadline);
            subTasks   = new List<TaskTree>();
            //Decide if this is the end of the tree.
            int decider = rand.Next(100);
            bool needSubTasks = decider % 10 == 3 || decider % 5 == 2 ;
            if (needSubTasks)
            {
                //If it's not for whatever reason, time to add 1 to 3 more children.
                int howMany = rand.Next(1, 5);
                for(int i = 0; i < howMany; i++)
                {
                    //Every child is another tree. 
                    this.subTasks.Add(new TaskTree(this.words, deadline.AddDays(rand.Next(7, 365)), words.getRandomWords(500)));
                }
            }

        }
        //TODO: Recursively collapse the tree into a set of parent records to be added to the Database.
        //TODO: Recursively collapse the tree into a set of task tuples to be added to the Database.
        public string printTree()
        {
            string outstring = "(root: " + this.task.getPK() + "children:\n";
            foreach (TaskTree tasks in this.subTasks)
                outstring += "\t" + tasks.printTree() + ",\n";
            outstring += ")";


            return outstring;
        }
    }
}
