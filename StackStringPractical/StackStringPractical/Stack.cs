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
            string returnString;

            if(headpointer == null)
            {
                throw new NullReferenceException("Cannot pop an EmptyStack, no string to return");
            }
            else if(headpointer == tailPointer)
            {
                returnString = tailPointer.stringObject;

                headpointer = null;
                tailPointer = null;
            }else
            {
                returnString = tailPointer.stringObject;

                if (headpointer.Next == tailPointer)
                {
                    tailPointer = headpointer;
                    tailPointer.Next = null;
                }
                else
                {

                    StringNode nodeWalker = headpointer;

                    while (nodeWalker.Next != null)
                    {
                        nodeWalker = nodeWalker.Next;

                        if (nodeWalker.Next == tailPointer)
                        {
                            tailPointer = nodeWalker;
                            nodeWalker.Next = null;
                        }

                    }
                }
            }

            return returnString;
        }

        public String Peek()
        {

            if (tailPointer == null)
            {
                throw new NullReferenceException("Cannot peek at EmptyStack, no string to return");
            }
            else
            {
                return tailPointer.stringObject;
            }
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
            if (headpointer == null)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public override string ToString()
        {
            StringNode nodeWalker = headpointer;
            int count = 0;
            string returnString = "";

            if(headpointer == null)
            {
                return "Stack is empty.";

            }else if(headpointer == tailPointer)
            {

                return count.ToString() + " " + nodeWalker.stringObject + " ";
            }
            else{

                while(nodeWalker != null)
                {
                    returnString += count.ToString() + " " + nodeWalker.stringObject + ", ";
                
                    count++;

                    nodeWalker = nodeWalker.Next;
                }
            }

            return returnString;
        }

     
    }
}
