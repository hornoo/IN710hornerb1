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
       protected int humidRunningTotal;
       protected int tempRunningTotal;
       protected int barRunningTotal;
        
       public AverageReadingObserver(ListBox outputDisplay, SensorSubject subject)
        : base(outputDisplay, subject)
        {
            runCount = 0;
            humidRunningTotal = 0;
            tempRunningTotal = 0;
            barRunningTotal = 0;
        }


        public override void Update(int tempData, int HumidData, int barData)
        {
            currentDatareadingBar = barData;
            currentDatareadingHumid = HumidData;
            currentDataReadingTemp = tempData;


            barRunningTotal += currentDatareadingBar;
            tempRunningTotal += currentDataReadingTemp;
            humidRunningTotal += currentDatareadingHumid;

            if (runCount == 0 )
            {
                runCount++;
                currentComputedHumid = currentDatareadingHumid;

                currentComputedBar = currentDatareadingBar;

                currentComputedTemp = currentDataReadingTemp;

                

            }else
            {
                runCount++;

                currentComputedBar = AverageData(runCount,currentDatareadingBar, barRunningTotal);
                currentComputedHumid = AverageData(runCount, currentDatareadingHumid, humidRunningTotal);
                currentComputedTemp = AverageData(runCount, currentDataReadingTemp, tempRunningTotal);
                
                
            }


            Display();


        }


        public double AverageData(int dataruns,int newData, int runningTotal)
        {
            double returnValue = 0;

            returnValue = (double)runningTotal / dataruns;
          
            return returnValue;
        }

    }
}
