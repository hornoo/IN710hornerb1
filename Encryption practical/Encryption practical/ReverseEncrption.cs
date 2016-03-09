using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_practical
{
   public class ReverseEncrption : IEncryptMachine
    {



        public string EncryptDecrypt(string inputString)
        {
            

            char[] inPutStringInCharArray = inputString.ToCharArray();

            Array.Reverse(inPutStringInCharArray);

            String outputString = new String(inPutStringInCharArray);

            return outputString;

        }

 
    }
}
