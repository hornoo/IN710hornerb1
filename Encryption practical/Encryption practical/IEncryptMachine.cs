using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_practical
{
   public interface IEncryptMachine
    {
       //Required methods for a encryption machine
        String EncryptDecrypt(String inputString);

    }
}
