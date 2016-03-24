using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public abstract class SensorObserver : ISensorObserver
    {
        protected int currentDataReading;

        protected double currentComputerValue;



        public abstract void Update(int data);
    

        public void Display()
        {
            
        }
    }
}
