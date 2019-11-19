using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class OrganizationGenerator
    {
        WordListManager words;
        public OrganizationGenerator()
        {
            this.words = new WordListManager();
        }
        public OrganizationGenerator(WordListManager words)
        {
            this.words = words;
        }
        private string genLicense(int length)
        {
            string s = "";
            bool upper = false;
            bool isLetter = false;
            char letter;
            Random rand = new Random();
            for(int i = 0; i < length; i++)
            {
                upper = rand.Next(1) == 1;
                isLetter = rand.Next(20) % 2 == 0;
                if (isLetter)
                {
                    if (upper)
                    {
                        letter = Convert.ToChar(Convert.ToInt32('A') + rand.Next(25));
                    }
                    else
                    {
                        letter = Convert.ToChar(Convert.ToInt32('a') + rand.Next(25));
                    }
                    s += letter;
                }
                else
                {
                    s += rand.Next(9);
                }
            }

            return s;
        }
        private string generateName()
        {
            return words.getRandomWords(2) + "Corporation";
        }
        private Organization newOrganization()
        {
            return new Organization(generateName(), genLicense(12));
        }
        public List<Organization> generateOrganizations(int number)
        {
            List<Organization> orgs = new List<Organization>();
            for(int i = 0; i < number; i++)
            {
                orgs.Add(newOrganization());
            }
            return orgs;
        }
    }
}
