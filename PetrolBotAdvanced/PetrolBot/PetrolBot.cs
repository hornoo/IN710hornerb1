using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PetrolBot
{

    public enum BotState {SailingtoShip, waiting};

   public class PetrolBot
    {

       Graphics botCanvas;
       Color botColour;
       Point botCurrentlocation;
       Ship botShip;
       Point botStartingLocation;
       Point shipLocation;
       Random rand;
       int botVelovity;

       BotState botState;

       double radiansToship;

       public event EventHandler AtShipLocation;


       public PetrolBot(Ship BotShip, Graphics BotCanvas, Random Rand, Point InitalLocation)
       {
           rand = Rand;
           botShip = BotShip;
           botCanvas = BotCanvas;
           botColour = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
           botStartingLocation = InitalLocation;
           botCurrentlocation = InitalLocation;
           double radiansToship = 0;
           botVelovity = 3;

           botState = BotState.waiting;

           EventHandler shipfull = new EventHandler(FullOfFuelEventhandler);
           Ship.outOfFuelEventHandler shipempty = new Ship.outOfFuelEventHandler(OutOfFuelEventHandler);
           

           botShip.FullOfFuelEvent += shipfull;
           botShip.OutOfFuelEvent += shipempty;


          


       }

       public void isBotAtShip()
       {
           if (((botCurrentlocation.X > shipLocation.X) && (botCurrentlocation.X < shipLocation.X + 50))
               && ((botCurrentlocation.Y > shipLocation.Y) && (botCurrentlocation.Y < shipLocation.Y + 50)))
           {
               OnAtShipLocation();
               botCurrentlocation = shipLocation;
               botState = BotState.waiting;
           }
       }

        public void drawBot()
       {
           isBotAtShip();

           if (botState == BotState.SailingtoShip)
            {
                calculateNextStepToShip();


            }
           
          
           SolidBrush botBrush = new SolidBrush(botColour);

           botCanvas.FillEllipse(botBrush, botCurrentlocation.X, botCurrentlocation.Y, 20, 20);

       }

       public void FullOfFuelEventhandler(object o, EventArgs e)
       {
           botCurrentlocation = botStartingLocation;
           botState = BotState.waiting;
       }

       public void OutOfFuelEventHandler(object o, ShipEventArgs e)
       {
           shipLocation = e.ShipLocation;
           botState = BotState.SailingtoShip;
           //botCurrentlocation = e.ShipLocation;

           calculateAngletoship();
       }

       public void calculateAngletoship()
       {
           double tanX = shipLocation.X - botStartingLocation.X;
           double tanY = shipLocation.Y - botStartingLocation.Y;

           radiansToship = Math.Atan2(tanY + 25, tanX + 25);

           Console.WriteLine(radiansToship);

       }

       public void calculateNextStepToShip()
       {
           double xAxis = botVelovity * Math.Cos(radiansToship);
           double yAxis = botVelovity * Math.Sin(radiansToship);

           botCurrentlocation.X += (int)xAxis;
           botCurrentlocation.Y += (int)yAxis;

       }

       public void OnAtShipLocation()
       {
           EventArgs atS = new EventArgs();
           if (AtShipLocation != null)
           {
               AtShipLocation(this, atS);
           }
       }

       
       
    }
}
