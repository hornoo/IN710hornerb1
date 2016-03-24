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
        protected int currentDataReadingTemp;
        protected double currentComputerValueTemp;


        protected int currentDatareadingHumid;
        protected double currentComputedValueHumid;


        protected int currentDatareadingBar;
        protected double currentComputedBar;



        protected ListBox dataDisplay;

        protected SensorSubject sensorSubject;

        public SensorObserver(ListBox outputDisplay, SensorSubject subject )
        {
            sensorSubject = subject;

            dataDisplay = outputDisplay;

            sensorSubject.addObserver(this);

            currentDatareadingBar = 0;
            currentDatareadingHumid = 0;
            currentDataReadingTemp = 0;


            currentComputedBar = 0;
            currentComputedValueHumid = 0;
            currentComputerValueTemp = 0;

        }

        public virtual void Display()
        {
            dataDisplay.Items.Add("Temperature:/t " + currentComputerValueTemp);
            dataDisplay.Items.Add("Humidity:/t " + currentComputedValueHumid);
            dataDisplay.Items.Add("Pressure:/t" + currentDatareadingBar);
        }

        public abstract void Update(int tempData, int HumidData, int barData);
  
    }
}
