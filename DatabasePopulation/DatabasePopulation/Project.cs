using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class Project
    {
        static int id = 0;
        DateTime deadline;
        string description;
        public Project()
        {
            id = -1;
            deadline = DateTime.Today;
            description = "I don't know how this got here.";
        }
        public Project(DateTime deadline, string description)
        {
            id++;
            this.deadline = deadline;
            this.description = description;
        }
        public string getAddTupleQuerryString()
        {
            return "(" +id + "\"" + deadline.ToString("yyyy-MM-dd HH:mm:ss") + "\",\"" + description+ "\")";
        }
    }
}
