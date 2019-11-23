using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    public class Project
    {
        static int id = 0;
        int myId;
        DateTime deadline;
        string description;
        public Project()
        {
            myId = -1;
            deadline = DateTime.Today;
            description = "I don't know how this got here.";
        }
        public Project(DateTime deadline, string description)
        {
            myId = id++;
            this.deadline = deadline;
            this.description = description;
        }
        public string getAddTupleQuerryString()
        {
            return "(" +myId + ",\"" + deadline.ToString("yyyy-MM-dd HH:mm:ss") + "\",\"" + description+ "\")";
        }
        public string getPK()
        {
            return "\"" + this.myId + "\"";
        }
    }
}
