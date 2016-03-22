using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDashBoard
{//Interface setting required methods for observer classes
    public interface ISubject
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
        void InputTrigger(String inputstring);
    }
}
