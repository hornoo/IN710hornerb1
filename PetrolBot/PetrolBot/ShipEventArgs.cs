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


       public Point ShipLocation { get; set; }

       public ShipEventArgs(Point coordonate)
       {
           ShipLocation = coordonate;
       }

    }
}
