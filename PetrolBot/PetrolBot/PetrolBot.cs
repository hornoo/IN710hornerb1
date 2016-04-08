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
       Random rand;


       public PetrolBot(Ship BotShip, Graphics BotCanvas, Random Rand, Point InitalLocation)
       {
           rand = Rand;
           botShip = BotShip;
           botCanvas = BotCanvas;
           botColour = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
           botStartingLocation = InitalLocation;
           botCurrentlocation = InitalLocation;

       }

        public void drawBot()
       {

           SolidBrush botBrush = new SolidBrush(botColour);

           botCanvas.FillEllipse(botBrush, botCurrentlocation.X, botCurrentlocation.Y, 10, 10);

       }

       public void FullOfFuelEventhandler()
       {

       }

       public void OutOfFuelEventHandler()
       {

       }

       
       
    }
}
