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
       
        Random rgen;
        Graphics shipCanvas;
        Color shipColour;
        int shipSize;
        EShipState sipState;
        int shipVelocity;




        int Petrol { get; set; }
        Point ShipLocation {get; set;}


        public delegate void outOfFuelEventHandler(object o, ShipEventArgs e);

        public event outOfFuelEventHandler OutOfFuelEvent;

        public event EventHandler FullOfFuelEvent;


        public Ship(Graphics ShipCanvas, int ShipSize)
        {
            shipCanvas = ShipCanvas;
            shipSize = ShipSize;
        }

        public void drawShip()
        {

        }

        public void moveShip()
        {

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

        public void refuel()
        {

        }

        public void ShipCycle()
        {

        }

        public void usePetrol()
        {

        }

    }
}
