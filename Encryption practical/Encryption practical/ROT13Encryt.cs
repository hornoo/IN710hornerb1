using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_practical
{
    class ROT13Encryt : IEncryptMachine
    {



        public string EncryptDecrypt(string inputString)
        {
            char[] inPutStringInCharArray = inputString.ToCharArray();
            for (int i = 0; i < inPutStringInCharArray.Length; i++)
            {
                int number = (int)inPutStringInCharArray[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                inPutStringInCharArray[i] = (char)number;
            }

            String outPutString = inPutStringInCharArray.ToString(); 

            return outPutString;
        }

    }
}
