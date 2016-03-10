using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_practical
{
   public class TextParser
    {

       public IEncryptMachine encryptionmachine { get; set; }

       public TextParser()
       {
           
       }

       public String EncryptDecrypt(String inputString)
       {
           return encryptionmachine.EncryptDecrypt(inputString);
       }

    }
}
