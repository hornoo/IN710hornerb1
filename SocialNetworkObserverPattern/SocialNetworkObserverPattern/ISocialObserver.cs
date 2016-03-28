using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkObserverPattern
{
    public interface ISocialObserver
    {// Set required methods for and observer.
        void Update(String statusUpdate, String timeStamp);
        void Display();
    }
}
