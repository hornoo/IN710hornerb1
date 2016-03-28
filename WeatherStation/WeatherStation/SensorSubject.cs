using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{// Jubject class, implements ISubject, Takes input readings and passes to other observer classes
   public class SensorSubject : ISubject
    {

       //List to store observers
        private List<ISensorObserver> observerList;

       // int to record input readings.
        int tempReading;
        int humidReading;
        int barReaiding;

        public SensorSubject()
        {//Allocating memory
            observerList = new List<ISensorObserver>();
            tempReading = 0;
            humidReading = 0;
            barReaiding = 0;

        }

       //Addes and observer to  the observer list.
        public void addObserver(ISensorObserver o)
        {
            observerList.Add(o);
        }

       //Remove an observer front he list.
        public void removeObserver(ISensorObserver o)
        {
            observerList.Remove(o);
        }


       //Foreach observer run their update methof and pass in new data/readings.
        public void notifyObserver()
        {
            foreach (ISensorObserver currentObserver in observerList)

                currentObserver.Update(tempReading, humidReading, barReaiding);
        }


       //Trigger method, collects passed in data stores in class variables then runs the notifyobserver method to signal observers on new data.
        public void InputTrigger(String tempString,String humidString,String barString )
        {
            tempReading = readdata(tempString);
            humidReading = readdata(humidString);
            barReaiding = readdata(barString);


            notifyObserver();

        }

       // method to parse input data to int. will through an exception if it cannot be parsed to int.
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
