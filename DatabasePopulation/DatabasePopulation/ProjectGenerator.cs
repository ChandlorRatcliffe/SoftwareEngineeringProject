using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class ProjectGenerator
    {
        Random rand = new Random();
        WordListManager words;
        public ProjectGenerator()
        {
            words = new WordListManager();
        }
        public ProjectGenerator(WordListManager words)
        {
            this.words = words;
        }
        private Project generateProject()
        {
            DateTime deadline = DateTime.Today.AddDays(rand.Next(1200));
            string description = words.getRandomWords(500);
            return new Project(deadline, description);
        }
        public List<Project> generateProjects(int number)
        {
            List<Project> projects = new List<Project>();
            for(int i = 0; i < number; i++)
            {
                projects.Add(generateProject());
            }
            return projects;
        }
    }
}
