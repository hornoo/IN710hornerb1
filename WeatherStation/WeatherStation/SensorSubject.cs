using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    class SensorSubject : ISubject
    {
        private List<ISensorObserver> observerList;
        int tempReading;
        int humidReading;
        int barReaiding;

        public SensorSubject()
        {
            observerList = new List<ISensorObserver>();
            tempReading = 0;

        }

        public void addObserver(ISensorObserver o)
        {
            observerList.Add(o);
        }

        public void removeObserver(ISensorObserver o)
        {
            observerList.Remove(o);
        }

        public void notifyObserver()
        {
            foreach (ISensorObserver currentObserver in observerList)

                currentObserver.Update(tempReading, humidReading, barReaiding);
        }

        public void InputTrigger(String tempString,String humidString,String barString )
        {
            tempReading = readdata(tempString);
            humidReading = readdata(humidString);
            barReaiding = readdata(barString);


            notifyObserver();

        }


        private int readdata(String inputString)
        {
            
            int returnValue = 0;

             try 
            {
               returnValue = Int32.Parse(inputString);
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }

            return returnValue;
        }
    }
}
