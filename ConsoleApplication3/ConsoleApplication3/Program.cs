using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string teststring = "input string string two one";
            GetMostFrequentWord(teststring);
            Console.ReadLine();
        }


        static string GetMostFrequentWord(string input)
        {
            string returnString = "";
            string[] tokenToSplitOnArray = new string[]{" "};


            string[] arrayOfSlipStrings = input.Split(tokenToSplitOnArray, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();



            foreach(string cs in arrayOfSlipStrings)
            {
                
                int count = 1;
                foreach(String word in arrayOfSlipStrings)
                {
                    if(word.ToLower().Equals(cs.ToLower()))
                    {
                        count++;
                    }
                }

                wordCount.Add(cs.ToLower(), count);
            }


            var freqWords = from word in wordCount
                            where word.Value > 1
                            orderby word.Value
                            select word;

            foreach(var w in freqWords)
            {
                returnString += w.Key + ",";
            }


            return returnString;
        }
    }
}
