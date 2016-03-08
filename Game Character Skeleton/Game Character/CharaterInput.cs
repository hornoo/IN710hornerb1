using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class CharaterInput
    {
        public CharaterInput()
        {

        }

        public int CheckStringInput(String inputText)
        {

            int maxStringLength = 15;

            Console.WriteLine(inputText.Length);

            //check stink is not empty and pass back appropriate erro code.
            if (inputText.Length > maxStringLength)
            {
                return 3;
            }
            if (inputText.Length < 1)
            {

                return 4;
            }
            else
            {
                return 0;
            }

        }
    }
}
