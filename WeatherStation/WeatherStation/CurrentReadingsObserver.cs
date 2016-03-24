using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public class CurrentReadingsObserver : SensorObserver
    {
        public CurrentReadingsObserver(ListBox outputDisplay, SensorSubject subject)
            : base(outputDisplay, subject)
        {

        }




        public override void Update(int tempData, int HumidData, int barData)
        {
            currentDatareadingBar = barData;
            currentDatareadingHumid = HumidData;
            currentDataReadingTemp = tempData;

            currentComputedValueHumid = currentDatareadingHumid;

            currentComputedBar = currentDatareadingBar;

            currentComputerValueTemp = currentDataReadingTemp;

            Display();
        }
    }
}
