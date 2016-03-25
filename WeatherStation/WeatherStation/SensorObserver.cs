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
        protected double currentComputedTemp;


        protected int currentDatareadingHumid;
        protected double currentComputedHumid;


        protected int currentDatareadingBar;
        protected double currentComputedBar;



        protected ListBox dataDisplay;
        protected SensorSubject sensorSubject;

        public SensorObserver(ListBox outputDisplay, SensorSubject subject)
        {
            sensorSubject = subject;

            dataDisplay = outputDisplay;

            sensorSubject.addObserver(this);

            

            currentDatareadingBar = 0;
            currentDatareadingHumid = 0;
            currentDataReadingTemp = 0;


            currentComputedBar = 0;
            currentComputedHumid = 0;
            currentComputedTemp = 0;
        }

        

        public virtual void Display()
        {
            dataDisplay.Items.Clear();

            dataDisplay.Items.Add("Temperature:\t" + currentComputedTemp.ToString("F2"));
            dataDisplay.Items.Add("Humidity:\t\t" + currentComputedHumid.ToString("F2"));
            dataDisplay.Items.Add("Pressure:\t\t" + currentComputedBar.ToString("F2"));
        }

        public abstract void Update(int tempData, int HumidData, int barData);

       
  
    }
}
