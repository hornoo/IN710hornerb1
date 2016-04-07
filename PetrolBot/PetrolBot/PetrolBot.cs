using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PetrolBot
{
   public class PetrolBot
    {

       Graphics botCanvas;
       Color botColour;
       Point botCurrentlocation;
       Ship botShip;
       Point botStartingLocation;
       Point shipLocation;


       public PetrolBot(Ship BotShip, Graphics BotCanvas)
       {
           botShip = BotShip;
           botCanvas = BotCanvas;

       }

       public void drawBot()
       {

       }

       public void FullOfFuelEventhandler()
       {

       }

       public void OutOfFuelEventHandler()
       {

       }

       
       
    }
}
