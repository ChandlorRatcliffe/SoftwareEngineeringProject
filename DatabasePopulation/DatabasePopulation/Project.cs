using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    public class Project
    {
        //We'll use a static id as a counter. Each new instance's myID will be defined by the current id,
        //and then the id will be incremented again. 
        //TODO: Replace this system with an alphanumeric id system with the same concept in place. 
        static int id = 0;
        int myId;
        DateTime deadline; //"yyyy-MM-dd HH:mm:ss" required for ToString for mySQL compatibility
        string description;
        public Project()
        {
            myId = -1;
            deadline = DateTime.Today;
            description = "I don't know how this got here.";
        }
        //A project minimally requires a deadline and a description. 
        public Project(DateTime deadline, string description)
        {
            myId = id++;
            this.deadline = deadline;
            this.description = description;
        }
        //This generates the tuple required for the insert query string. 
        public string getAddTupleQuerryString()
        {
            return "(" +myId + ",\"" + deadline.ToString("yyyy-MM-dd HH:mm:ss") + "\",\"" + description+ "\")";
        }
        //This provides the primary key for use in generating relation records. 
        public string getPK()
        {
            return "\"" + this.myId + "\"";
        }
    }
}
