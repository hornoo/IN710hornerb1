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

       //THis event is raised when the bot reashes the ship and dells the ship to start refueling.
       public event EventHandler AtShipLocation;


       public PetrolBot(Ship BotShip, Graphics BotCanvas, Random Rand, Point InitalLocation)
       {
           rand = Rand;

           //passed in ship\subject
           botShip = BotShip;

           botCanvas = BotCanvas;
           botColour = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
           botStartingLocation = InitalLocation;
           botCurrentlocation = InitalLocation;
           double radiansToship = 0;
           botVelovity = 10;

           botState = BotState.waiting;

           //Create delegate to assign a method we want to run when the assigned ship (to this petrol bot) rasies an event. Then Assign a 
           //method to this delegate.(this event uses a system provided event handler.)
           EventHandler shipfull = new EventHandler(FullOfFuelEventhandler);

           //Create  delegate for our custom event handler that can pass a data bucket, when run the assigned ship event (to this petrol bot) rasies an event. Then Assign 
           //method to this delegate.(this event uses a system provided event handler.)
           Ship.outOfFuelEventHandler shipempty = new Ship.outOfFuelEventHandler(OutOfFuelEventHandler);

           //Assigning delegate to event
           botShip.FullOfFuelEvent += shipfull;
           //Assigning delegate to event
           botShip.OutOfFuelEvent += shipempty;


          


       }

       public void isBotAtShip()
       {
           if (((botCurrentlocation.X > shipLocation.X) && (botCurrentlocation.X < shipLocation.X + 50))
               && ((botCurrentlocation.Y > shipLocation.Y) && (botCurrentlocation.Y < shipLocation.Y + 50)))
           {
               //event is raised here when the box is at the ships location.
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

       // This method is run when the  assigned\subject ship signals it is full of fuel.
       public void FullOfFuelEventhandler(object o, EventArgs e)
       {

           botCurrentlocation = botStartingLocation;
           botState = BotState.waiting;
       }

       // This method is run when the  assigned\subject ship signals it is out of fuel
       public void OutOfFuelEventHandler(object o, ShipEventArgs e)
       {
           //The local ship location variable is updated with the jubject slocation from the passed in data bucket.
           shipLocation = e.ShipLocation;
           //and the bot starts sailing.
           botState = BotState.SailingtoShip;

         
       }

       public void calculateAngletoship()
       {
           double tanX = shipLocation.X - botCurrentlocation.X;
           double tanY = shipLocation.Y - botCurrentlocation.Y;

           radiansToship = Math.Atan2(tanY + 25, tanX + 25);

       }

       public void calculateNextStepToShip()
       {
           calculateAngletoship();

           double xAxis = botVelovity * Math.Cos(radiansToship);
           double yAxis = botVelovity * Math.Sin(radiansToship);

           botCurrentlocation.X += (int)xAxis;
           botCurrentlocation.Y += (int)yAxis;

       }

       //Event method call to signal event of when bot is at ship
       public void OnAtShipLocation()
       {
           //Creates new a instance of EventArgs to pass in via the event.(no data bucked is passed)
           EventArgs atS = new EventArgs();
           if (AtShipLocation != null)
           {
               AtShipLocation(this, atS);
           }
       }

       
       
    }
}
