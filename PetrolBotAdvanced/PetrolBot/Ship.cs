﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public enum EShipState { wandering, refueling, waiting};
    public class Ship
    {

        const int MAX_SHIP_VELOCITY = 3;
        const int MIN_SHIP_VELOCITY = -3;


        Random rgen;
        Graphics shipCanvas;
        Color shipColour;
        int shipSize;
        EShipState shipState;
        int shipXVelocity;
        int shipYVelocity;
        Rectangle boundsRectangle;
        Point shipLocation;
        PetrolBot petrolBot;



        int Petrol { get; set; }
        

        //Delegate  eventhandler fot custom event data bucket.
        public delegate void outOfFuelEventHandler(object o, ShipEventArgs e);

        //Event that uses a custome eventhandler to pass data.
        public event outOfFuelEventHandler OutOfFuelEvent;

        //Full of fuel event, does not pass any data.
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

            Petrol = 100;

            shipState = EShipState.wandering;

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


        //Custom method to add petrolbot to ship propeties, so that the bot can rases an  event and the hsi knows when t start refueling.
        public void addPetrolbot(PetrolBot ReferenceToBot)
        {
            petrolBot = ReferenceToBot;

            //creting new event handler delegate , to run ships method "waitingFor Ship" when the pertorl bot arrives
            EventHandler petBotAtShipDeledate = new EventHandler(WaitingForShip);

            //subscribe methof to runn when petrolbot raises event.
            petrolBot.AtShipLocation += petBotAtShipDeledate;
        }

        //Method that is run when petrol bot arrives
       public void WaitingForShip(object o, EventArgs e)
       {
           shipState = EShipState.refueling;
       }


        void drawShip()
        {

            double petrolRatio = Petrol / 100.0;
            double redValue = 255 * petrolRatio;
            shipColour = Color.FromArgb((int)redValue, 0, 0);

            SolidBrush shipBrush = new SolidBrush(shipColour);
            shipCanvas.FillRectangle(shipBrush, shipLocation.X, shipLocation.Y, shipSize, shipSize);
        }

         void moveShip()
        {

            if (shipState == EShipState.wandering)
            {

                shipLocation.X += shipXVelocity;
                shipLocation.Y += shipYVelocity;

                if ((shipLocation.X < boundsRectangle.Left) || (shipLocation.X + shipSize > boundsRectangle.Right))
                {
                    shipXVelocity *= -1;
                }
                else if ((shipLocation.Y < boundsRectangle.Top) || (shipLocation.Y + shipSize > boundsRectangle.Bottom))
                {
                    shipYVelocity *= -1;
                }

            }
           

        }

        //Method to run when ship is full, no data is passed.
        public void OnFullOfFuelEvent()
        {
            EventArgs se = new EventArgs();
            if(FullOfFuelEvent != null)
            {
                FullOfFuelEvent(this, se);
            }

        }

        //Custom event that is run when the ship is out of fuel, the current location of the ship is passed via custom eventargs when this event is run.
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
            Petrol += 5;

             if(Petrol == 100)
             {
                 OnFullOfFuelEvent();
                 shipState = EShipState.wandering;
             }
        }

        public void ShipCycle()
        {
            if (shipState == EShipState.wandering)
            {
                usePetrol();
                moveShip();
            }else if(shipState == EShipState.refueling)
            {
                refuel();
            }

            moveShip();
            drawShip();
        }

         void usePetrol()
        {

             int usePetrolRate = 0;
             
             if(shipXVelocity < 0)
             {
                 usePetrolRate = shipXVelocity * -1;
             }else{
                 usePetrolRate =  shipXVelocity;
             }

            Petrol -= usePetrolRate;

             if(Petrol < 0)
             {
                 Petrol = 0;
                 OnOutOfFuelEvent(shipLocation);
                 shipState = EShipState.waiting;
             }
        }

    }
}
