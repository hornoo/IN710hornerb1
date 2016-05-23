using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = "i";
            

            Console.WriteLine(CountWords(inputString));
            Console.ReadLine();

        }

        static int CountWords(string input)
        {
           int returnCount = 0;
           char searchChar = ' ';
           string inputString = input.Trim();
           int indexOfLastSpace = 0;

           if (inputString.Length > 0)
           {
               do
               {
                   indexOfLastSpace = inputString.IndexOf(searchChar, indexOfLastSpace + 1);

                   returnCount++;
               } while (indexOfLastSpace > 0);
           }


           return returnCount;
        }

        


    }
}
