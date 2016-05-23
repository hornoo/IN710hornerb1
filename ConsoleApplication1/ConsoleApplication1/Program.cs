using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

           // int sum = 0;
           // int arraySize = 0;

           //Console.WriteLine("Please input how many numbers you would like to add");
           //String consoleInput = Console.ReadLine();

           //arraySize = Convert.ToInt32(consoleInput);
         

           //for(int arrayIndex = 0; arrayIndex < arraySize; arrayIndex ++)
           //{
           //    sum += Convert.ToInt32(Console.ReadLine());
           //}

           //Console.WriteLine(sum);
           //Console.ReadLine();

           testP(5);

           Console.ReadLine();

            
        }

        static void testP(int n)
        {
            for(int i = 0; i < n; i ++)
            {
                string outPutString = "";

                for(int spaceindex = 0; spaceindex < (n - i); spaceindex ++)
                {
                    outPutString += " ";
                }

                for(int hashIndex = 0; hashIndex < (i + 1) ; hashIndex ++)
                {
                    outPutString += "#";
                }

                Console.WriteLine(outPutString);
            }
        }


    }
}
