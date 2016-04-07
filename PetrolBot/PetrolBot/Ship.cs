using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public enum EShipState { wandering, refueling};
    public class Ship
    {

        const int MAX_SHIP_VELOCITY = 20;
        const int MIN_SHIP_VELOCITY = -20;


        Random rgen;
        Graphics shipCanvas;
        Color shipColour;
        int shipSize;
        EShipState sipState;
        int shipXVelocity;
        int shipYVelocity;
        Rectangle boundsRectangle;
        Point shipLocation;



        int Petrol { get; set; }
        Point ShipLocation {get; set;}


        public delegate void outOfFuelEventHandler(object o, ShipEventArgs e);

        public event outOfFuelEventHandler OutOfFuelEvent;

        public event EventHandler FullOfFuelEvent;


        public Ship(Graphics ShipCanvas, int ShipSize, Rectangle Rectangle, Random Rand)
        {
            rgen = Rand;
            boundsRectangle = Rectangle;
            shipCanvas = ShipCanvas;
            shipSize = ShipSize;
            shipColour = Color.Red;
            shipXVelocity = rgen.Next(MAX_SHIP_VELOCITY) + MIN_SHIP_VELOCITY;
            shipYVelocity = rgen.Next(MAX_SHIP_VELOCITY) + MIN_SHIP_VELOCITY;

            shipLocation = new Point(rgen.Next(boundsRectangle.Width), rgen.Next(boundsRectangle.Height));

            if( shipLocation.X + shipSize > boundsRectangle.Right)
            {
                shipLocation.X -= shipSize;
            }
            else if (shipLocation.X < boundsRectangle.Left)
            {
                shipLocation.X += shipSize;
            }
            else if (shipLocation.Y + shipSize > boundsRectangle.Bottom)
            {
                shipLocation.Y -= shipSize;
            }
            else if (shipLocation.Y < boundsRectangle.Top)
            {
                shipLocation.Y += shipSize;
            }

        }




        void drawShip()
        {
            SolidBrush shipBrush = new SolidBrush(shipColour);
            shipCanvas.FillRectangle(shipBrush, shipLocation.X, shipLocation.Y, shipSize, shipSize);
        }

         void moveShip()
        {
            shipLocation.X += shipXVelocity;
            shipLocation.Y += shipYVelocity;

          if ((shipLocation.X < boundsRectangle.Left) || (shipLocation.X + shipSize > boundsRectangle.Right))
              {
              shipXVelocity *= -1;
              }
          else if((shipLocation.Y < boundsRectangle.Top) || (shipLocation.Y + shipSize > boundsRectangle.Bottom))
          {
              shipYVelocity *= -1;
          }

            
           

        }

        public void OnFullOfFuelEvent()
        {
            EventArgs se = new EventArgs();
            if(FullOfFuelEvent != null)
            {
                FullOfFuelEvent(this, se);
            }

        }

        public void OnOutOfFuelEvent(Point ShipCurrentlocation)
        {
            ShipEventArgs se = new ShipEventArgs(ShipCurrentlocation);

            if (OutOfFuelEvent != null)
            {
                OutOfFuelEvent(this, se);
            }
        }

         void refuel()
        {

        }

        public void ShipCycle()
        {
            moveShip();
            drawShip();
        }

         void usePetrol()
        {

        }

    }
}
