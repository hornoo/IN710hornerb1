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
        // base sensor observer class, implements I sensor Observer
        
        // Set References to Current input data nd Computed data
        protected int currentDataReadingTemp;
        protected double currentComputedTemp;


        protected int currentDatareadingHumid;
        protected double currentComputedHumid;


        protected int currentDatareadingBar;
        protected double currentComputedBar;


        //Set reference to Subject and listbox.
        protected ListBox dataDisplay;
        protected SensorSubject sensorSubject;

        public SensorObserver(ListBox outputDisplay, SensorSubject subject)
        {//Set reffentce to subject, display and then add this object to the subjects observer list.
            sensorSubject = subject;

            dataDisplay = outputDisplay;

            sensorSubject.addObserver(this);

            
            //Allocate memory for computer and data readings.
            currentDatareadingBar = 0;
            currentDatareadingHumid = 0;
            currentDataReadingTemp = 0;


            currentComputedBar = 0;
            currentComputedHumid = 0;
            currentComputedTemp = 0;
        }

        

        public virtual void Display()
        {// Clear list boc and then display computed data values.
            dataDisplay.Items.Clear();

            dataDisplay.Items.Add("Temperature:\t" + currentComputedTemp.ToString("F2"));
            dataDisplay.Items.Add("Humidity:\t\t" + currentComputedHumid.ToString("F2"));
            dataDisplay.Items.Add("Pressure:\t\t" + currentComputedBar.ToString("F2"));
        }


        //Abstracmethod to be degined in child classes.
        public abstract void Update(int tempData, int HumidData, int barData);

       
  
    }
}
