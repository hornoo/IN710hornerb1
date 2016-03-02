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

            if(headPointer == null)
            {
                
                headPointer = newPellet;
                tailPointer = newPellet;

            }else
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
            int count = 0;

            Pellet nodeWalker = headPointer;

            while(nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
            //throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            Pellet nodeWalker = headPointer;
            while(nodeWalker != null)
            {
                nodeWalker.Move();
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
            if(pelletToDelete == headPointer)
            {
                if(Count() == 1)
                {
                    headPointer = null;
                    tailPointer = null;
                }
                else
                {
                    headPointer = pelletToDelete.Next;
                }

            }
            else
            {
                Pellet nodewalker = headPointer;

                while(nodewalker.Next != pelletToDelete)
                {

                    nodewalker = nodewalker.Next;

                    if(nodewalker.Next == pelletToDelete)
                    {

                        nodewalker.Next = pelletToDelete.Next;

                        if (tailPointer == pelletToDelete)
                        {
                            tailPointer = nodewalker;
                        }
                    }
                    
                                  
                }

            }
            //throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
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
            Pellet nodeWalker = headPointer;

            while(nodeWalker != null)
            {
                nodeWalker.Draw();

                nodeWalker = nodeWalker.Next;
            }
        }
    }
}
