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


       //Reverse encryption
        public string EncryptDecrypt(string inputString)
        {
            
            //convert input string into and array of chars.
            char[] inPutStringInCharArray = inputString.ToCharArray();

            //reverse the array of chars
            Array.Reverse(inPutStringInCharArray);

            //convert the array back to a string
            String outputString = new String(inPutStringInCharArray);

            // returnt the "encrypted\decrypted"string
            return outputString;

        }

 
    }
}
