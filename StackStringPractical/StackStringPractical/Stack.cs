using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackStringPractical
{
    public class Stack
    {
        StringNode headpointer = null;
        StringNode tailPointer = null;

        public Stack()
        {
            
        }

        public void push(StringNode newStringNode)
        {
            if(headpointer == null)
            {
                headpointer = newStringNode;
                tailPointer = newStringNode;
            }else
            {
                tailPointer.Next = newStringNode;
                tailPointer = newStringNode;
            }
        }

        public String Pop() 
        {
            return null;
        }

        public String Peak()
        {
            return null;
        }

        public int Count()
        {
            int count = 0;

            StringNode nodewalker = headpointer;

            while(nodewalker != null)
            {
                count++;

                nodewalker = nodewalker.Next;

            }

            return count;
        }

        public bool isEmpty() 
        {   

            return false;
        }

     
    }
}
