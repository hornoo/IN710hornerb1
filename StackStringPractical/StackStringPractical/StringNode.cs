using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackStringPractical
{
   public class StringNode
    {
        public String stringObject { get; set; }

        public StringNode Next { get; set; }

        public StringNode(string inString)
        {
            stringObject = inString;
            Next = null;
        }

    }
}
