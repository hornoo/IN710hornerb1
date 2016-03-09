using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_practical
{
    class ReverseEncrption : IEncryptMachine
    {

        public string EncryptDecrypt(string inputString)
        {
            String outputString ="";

            char[] inPutStringInCharArray = inputString.ToCharArray();

            for (int i = inPutStringInCharArray.Length; i > 0; i-- )
            {
                outputString += inPutStringInCharArray[i];
            }

                return outputString;

        }

 
    }
}
