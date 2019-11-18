using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class WordListManager
    {
        string[] words;
        public WordListManager()
        {
            words = System.IO.File.ReadAllLines("C:\\Users\\Shenzao\\source\\repos\\DatabasePopulation\\DatabasePopulation\\wordlist.txt");
        }

        public string getName()
        {
            string word1 = getRandomWord();
            string word2 = getRandomWord();
            word1 = word1.ToUpper()[0] + word1.Substring(1,word1.Length-1);
            word2 = word2.ToUpper()[0] + word2.Substring(1, word2.Length - 1);
            return word1 + word2;
        }
        private string getRandomWord()
        {
            Random rand = new Random();
            return words[rand.Next(words.Length)];
        }
        public string getRandomWords(int howMany)
        {
            Random rand = new Random();
            string nonsense = "";
            for (int i = 0; i < howMany; i++)
            {
                nonsense += words[rand.Next(words.Length)] + " ";
            }
            return nonsense;
        }
    }
}
