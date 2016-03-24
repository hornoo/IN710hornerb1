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
        int currentReading;

        public SensorSubject()
        {
            observerList = new List<ISensorObserver>();
            currentReading = 0;

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

                currentObserver.update(currentReading);
        }

        public void InputTrigger(string inputString)
        {
            try 
            {
                currentReading = Int32.Parse(inputString);
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }

            notifyObserver();

        }
    }
}
