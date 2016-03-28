using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface ISensorObserver
    {//Ser required methods for a  Sensor observer.
        void Update(int tempData, int HumidData, int barData);
        void Display();

    }
}
