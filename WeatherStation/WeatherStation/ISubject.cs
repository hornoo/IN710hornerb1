using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{// Interfave to set the required methods for a weather sensor subject
    public interface ISubject
    {
        void addObserver(ISensorObserver o);
        void removeObserver(ISensorObserver o);
        void notifyObserver();
        void InputTrigger(String tempString, String humidString, String barString);

    }
}
