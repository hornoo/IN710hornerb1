using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PetrolBot
{
   public class ShipEventArgs : EventArgs
    {
       //Custom Event handler, A point is passed when this custom event is instantiated and passed to the subscriber.

       public Point ShipLocation { get; set; }

       public ShipEventArgs(Point coordonate)
       {
           ShipLocation = coordonate;
       }

    }
}
