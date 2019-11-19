using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class CreatesGenerator
    {
        WordListManager words;
        Random rand;
        public CreatesGenerator()
        {
            this.words = new WordListManager();
            this.rand = new Random();
        }
        public CreatesGenerator(WordListManager words)
        {
            this.words = words;
            this.rand = new Random();
        }
        public List<Create> generateCreateSet(SQLInterface sql)
        {
            Organization  o = sql.generateOrganizations(1)[0];
            List<Account> a = sql.generateAccounts(rand.Next(3, 20));
            List<Project> p = sql.generateProjects(rand.Next(2, 7));
            List<Create>  c = new List<Create>();
            foreach(Project project in p)
            {
                c.Add(new Create(a[rand.Next(a.Count)], project, o));
            }
            return c;

        }
    }
}
