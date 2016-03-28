using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkObserverPattern
{
    public interface ISubject
    {// required subject methods defined here
        void addObserver(ISocialObserver o);
        void removeObserver (ISocialObserver o);
        void notifyObserver();
        void InputTrigger(String statusUpdate); 

    }
}
