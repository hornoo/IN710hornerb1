using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworkObserverPattern
{
    public class SocialSubject : ISubject
    {

        List<ISocialObserver> observertList;
        String statusUpdate;
        String timeStamp;

        public SocialSubject()
        {
            observertList = new List<ISocialObserver>();
            statusUpdate = null;
        }

        public void addObserver(ISocialObserver o)
        {
            observertList.Add(o);
        }

        public void removeObserver(ISocialObserver o)
        {
            observertList.Remove(o);
        }

        public void notifyObserver()
        {
            foreach(ISocialObserver currentObserver in observertList)
            {
                currentObserver.Update(statusUpdate, timeStamp);
            }
        }

        public void InputTrigger(string statusUpdate)
        {
            try
            {
                this.statusUpdate = statusUpdate;
                timeStamp = DateTime.Now.ToString("ddd d MMM, yyyy HH:mm");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            notifyObserver();
        }
    }
}
