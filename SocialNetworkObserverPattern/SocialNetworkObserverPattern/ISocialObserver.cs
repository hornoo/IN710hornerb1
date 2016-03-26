using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkObserverPattern
{
    public interface ISocialObserver
    {
        void Update(String statusUpdate);
        void Display();
    }
}
