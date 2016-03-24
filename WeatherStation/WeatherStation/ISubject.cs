using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface ISubject
    {
        void addObserver(ISensorObserver o);
        void removeObserver(ISensorObserver o);
        void notifyObserver();
        void InputTrigger(String inputString);

    }
}
