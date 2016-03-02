using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {

            //If head pointer == null there are no nodes in the list, set both the head and tail to point to the added node(by defaul it's next should already point to null)
            if(headPointer == null)
            {
                
                headPointer = newPellet;
                tailPointer = newPellet;

            }else //else  set the tail pointer.next to = the new pellet and the tail pointer to = the new pellet, this means the tail it pointing at the new pellet object and object
                //which is still the same thing is the new pellet and as it is new pellet its .next points at null.(as it was set to null when instantiated) - I dont understand this bit.
            {
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }

            //throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
               // set count to return
            int count = 0;

            //create a new node that is the same as the head(it actually the same piece of memory as the head and  this nodewalker just points to in in memory, eg another way to acces this object whyle you work with it. 
            Pellet nodeWalker = headPointer;

            //While the nodewalker does not = null( when it gets to the end of the list it is set to point to the same location as the last nodes next points to which should always be null in a link list.
            while(nodeWalker != null)
            {
                //add to the count
                count++;
                // set the node walkker to be its Next object. when is gets the the end link it will be set to null and break the while loop.
                nodeWalker = nodeWalker.Next;
            }

            // return the count.
            return count;
            //throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            //create a new node that is the same as the head(it actually the same piece of memory as the head and  this nodewalker just points to in in memory)
            Pellet nodeWalker = headPointer;

            while(nodeWalker != null)
            {
                //for each node in the list run its move method.
                nodeWalker.Move();

                // set the node walkker to be its Next object. when is gets the the end link it will be set to null and break the while loop.(finnished walking the list)
                nodeWalker = nodeWalker.Next;
            }

            //throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            // this is the same as the  move method except it checks to see if each node s out of bounds of the passed in rectangle and if it is it sets its alive propeerty to false.
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                if (nodeWalker.TestOutOfBounds(boundsRectangle))
                {
                    nodeWalker.IsAlive = false;
                }

                nodeWalker = nodeWalker.Next;
            }
            //throw new NotImplementedException();
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {

            // the node to delete is the same as the head pointer check how many nodes in the list, if it is the only node set the head and tail to both be null, in c# the garbage collector will get rid of it, thi smay not happen in other languages.
            if(pelletToDelete == headPointer)
            {
                if(Count() == 1)
                {
                    headPointer = null;
                    tailPointer = null;
                }
                else // else set the head pointer to point at the node to deletes.Next which heand the deah is now point at the first node and the previous one will get collected by garbage collection
                {
                    headPointer = pelletToDelete.Next;
                }

            }
            else // now if its no the the first pellet in the list, walk the list from the second node in the link list
            {
                // create a nodewalker that is the head pointer
                Pellet nodewalker = headPointer;

                while(nodewalker.Next != null)
                {
                    // set the node walkerbo net the second node int he lin list by setting it as its.next, this is usually done after a operation on the list but as we already know that the 
                    //first not is not the one to delete we start here.
                    nodewalker = nodewalker.Next;

                    //if the node walker.next is the node we want to delete, we know that the node is the link before the one we want to delete.
                    if(nodewalker.Next == pelletToDelete)
                    {
                        //we need to check if the node we want to delete is the last link in the list(or the tail, if we lost the tail the list loses intgerity)
                        // we check by seeing if the node walkers.next is the tail pointer, if it is set the tailpointer to node\point at the node and set the node.next to = null(so that it doesnt point to any other node now, which was the one we ewanted to delete) garabage collection should nowremove the pnotde we want to delete.
                        if(nodewalker.Next == tailPointer)
                        {

                        tailPointer = nodewalker;
                        nodewalker.Next = null;
                        }
                        else // we now know the node we want to delete is not the tail also, so we can just set the node walkers.next to be the node we want to deletes.next meaning there is now no refference to the node we want to delete in the linklist
                        {

                            nodewalker.Next = pelletToDelete.Next;
                        }

                    }
                    
                       //while loop gets to the end of list list and breaks out when the node walker is set to null.           
                }

            }
            //throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            //this is the same as the move() and outof bounds() methoed except it checks the nodes isalive property and if faluse runs this classes (link-list) delet method.
            Pellet nodeWalker = headPointer;

            while(nodeWalker != null)
            {
                if(nodeWalker.IsAlive == false)
                {
                    DeleteOne(nodeWalker);
                }

                nodeWalker = nodeWalker.Next;
                
            }
            //throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            // same as move()..... except it rinds the current nodes draw() method.
            Pellet nodeWalker = headPointer;

            while(nodeWalker != null)
            {
                nodeWalker.Draw();

                nodeWalker = nodeWalker.Next;
            }
        }
    }
}
