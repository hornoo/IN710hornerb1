using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WeatherStation
{
   public class AverageReadingObserver : SensorObserver
    {

       protected int runCount;
        // Average reading observer, revieves data from sunject , performas aver age calculation and displays to list box.
       public AverageReadingObserver(ListBox outputDisplay, SensorSubject subject)
        : base(outputDisplay, subject)
        {
            runCount = 0;

        }


        public override void Update(int tempData, int HumidData, int barData)
        {
            //Set current reading data
            currentDatareadingBar = barData;
            currentDatareadingHumid = HumidData;
            currentDataReadingTemp = tempData;

            //if count = 0, display data as it has not other data values to work out and average with.
            if (runCount == 0 )
            {
                //Increase count, set computeddata values.
                runCount++;
                currentComputedHumid = currentDatareadingHumid;

                currentComputedBar = currentDatareadingBar;

                currentComputedTemp = currentDataReadingTemp;

                

            }else
            {// else run average method on each data value and pass result back to computed value.
                runCount++;

                currentComputedBar = AverageData(runCount,currentDatareadingBar, currentComputedBar);
                currentComputedHumid = AverageData(runCount, currentDatareadingHumid, currentComputedHumid);
                currentComputedTemp = AverageData(runCount, currentDataReadingTemp, currentComputedTemp);
                
                
            }

            //Run display method to show new data on form.
            Display();


        }

       //Work out average from current data
        public double AverageData(int dataruns,int newData, double runningTotal)
        {
            double returnValue = 0;
            // returnvalue = the running total times the number of times data has been updated, add on the new data and devide but the new count to give the running average over all inputs.
            returnValue = ((runningTotal * (dataruns - 1)) + newData) / dataruns;
          
                //retuen the result.
            return returnValue;
        }

    }
}
