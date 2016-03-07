using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
	
	Name: Richard Horne
	Title: String stack
	Date: 07/03/2016
	Description: This is my mplementation of a stack (Last in, first out). Using a type of link list ADO
        
*/

namespace StackStringPractical
{
    public class Stack
    {
        //Set head and tail pointer
        StringNode headpointer = null;
        StringNode tailPointer = null;

        //Constructor
        public Stack()
        {
            
        }

        //Method to push StringNode into stack
        public void push(StringNode newStringNode)
        {
            //Check stack is empty ,if so point the head and tail at new string node
            if(headpointer == null)
            {
                headpointer = newStringNode;
                tailPointer = newStringNode;
                
            //Set the current tail pointers .net to point at the new node and set the new node to be the tail pointer.
            }else
            {
                tailPointer.Next = newStringNode;
                tailPointer = newStringNode;
            }
        }

        //return the last added string node and remove it frok the stack
        public String Pop() 
        {
            string returnString;
            //if the header == null the stack is empty, throw an exception.
            if(headpointer == null)
            {
                throw new NullReferenceException("Cannot pop an EmptyStack, no string to return");
            }
            //else if the head and tail are the same thing there is only 1 node in the stack, return this and clear the stack.
            else if(headpointer == tailPointer)
            {
                returnString = tailPointer.stringObject;

                headpointer = null;
                tailPointer = null;
            //else there is multiple nodes in the stack, set the return string as the tail node as we aways remove this on in a stack(LIFO). 
            }else
            {
                returnString = tailPointer.stringObject;

                 //first check if there is 2 nodes
                if (headpointer.Next == tailPointer)
                {
                    //set the tail pointer to now point at the head, nd the tails .next to null as it no longer point at the node we just removed
                    tailPointer = headpointer;
                    tailPointer.Next = null;
                }
                else
                {
                    //else if there are more than 2 nodes, walk the stack untill you get to the node that's .next is the tail pointer, set the node walker as the tail and set its .next to null
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
            //return the string
            return returnString;
        }

        //return the last entered item but leave it in the stack
        public String Peek()
        {
            //if the tail pointer == null there i nothing in the stack, throw and exception
            if (tailPointer == null)
            {
                throw new NullReferenceException("Cannot peek at EmptyStack, no string to return");
            }
            //else return the tail node's string
            else
            {
                return tailPointer.stringObject;
            }
        }

        //return a count of how many nodes are in the stack
        public int Count()
        {
            //set the count to zero
            int count = 0;

            StringNode nodewalker = headpointer;

            // while the node walker does not = null, add to the count
            while(nodewalker != null)
            {
                count++;

                nodewalker = nodewalker.Next;

            }

            //at the end of the stack return the count
            return count;
        }

        //return a bool on whether the stack is empty or not.
        public bool isEmpty() 
        {
            //if the headpointer is null there ar no items in the stack, return true other wise return false
            if (headpointer == null)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        //loop through stack and print out nodes string and count.
        public override string ToString()
        {
            StringNode nodeWalker = headpointer;
            int count = 0;
            string returnString = "";

            //if nothing in the stack, return that the stack is empty
            if(headpointer == null)
            {
                return "Stack is empty.";
            }
            //Else walk the list and build up a sting of each string node's string  and postion in the stack then return this.
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
