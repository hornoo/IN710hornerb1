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
        
       public AverageReadingObserver(ListBox outputDisplay, SensorSubject subject)
        : base(outputDisplay, subject)
        {
            runCount = 0;

        }


        public override void Update(int tempData, int HumidData, int barData)
        {
            currentDatareadingBar = barData;
            currentDatareadingHumid = HumidData;
            currentDataReadingTemp = tempData;


            if (runCount == 0 )
            {
                runCount++;
                currentComputedHumid = currentDatareadingHumid;

                currentComputedBar = currentDatareadingBar;

                currentComputedTemp = currentDataReadingTemp;

                

            }else
            {
                runCount++;

                currentComputedBar = AverageData(runCount,currentDatareadingBar, currentComputedBar);
                currentComputedHumid = AverageData(runCount, currentDatareadingHumid, currentComputedHumid);
                currentComputedTemp = AverageData(runCount, currentDataReadingTemp, currentComputedTemp);
                
                
            }


            Display();


        }


        public double AverageData(int dataruns,int newData, double runningTotal)
        {
            double returnValue = 0;

            returnValue = ((runningTotal * (dataruns - 1)) + newData) / dataruns;
          
            return returnValue;
        }

    }
}
