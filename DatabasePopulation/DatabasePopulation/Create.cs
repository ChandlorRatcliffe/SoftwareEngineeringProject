using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    public class Create
    {
        Account account;
        Project project;
        Organization organization;
        public Create(Account account, Project project, Organization organization)
        {
            this.account      = account;
            this.project      = project;
            this.organization = organization;
        }
        public string getAddTupleQuerryString()
        {
            return "(" + this.account.getPK() + "," + this.organization.getPK() + "," + this.project.getPK() + ")";
        }


    }
}
