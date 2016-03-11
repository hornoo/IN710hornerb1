using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_practical
{
    public class ROT13Encryt : IEncryptMachine
    {

        public ROT13Encryt()
        {
        }

        //ROT encryption
        public string EncryptDecrypt(string inputString)
        {
            //sourced from http://www.dotnetperls.com/rot13

            //convert inout string into and array of chars
            char[] inPutStringInCharArray = inputString.ToCharArray();

            //loop for array of chars
            for (int i = 0; i < inPutStringInCharArray.Length; i++)
            {
                //convert char to it's asci number and stor in and int
                int number = (int)inPutStringInCharArray[i];

                //check case of letter and not a number or charater
                if (number >= 'a' && number <= 'z')
                {
                    //if greater than half way through alpabet - 13 from number else add 13
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }//check case of letter and not a number or charater
                else if (number >= 'A' && number <= 'Z')
                {
                    //if greater than half way through alpabet - 13 from number else add 13
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                //cast number back to a charter at index and store back in array
                inPutStringInCharArray[i] = (char)number;
            }

            //create new string out of char array
            String outPutString = new String(inPutStringInCharArray); 

            //return string
            return outPutString;
        }

    }
}
