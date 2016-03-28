using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworkObserverPattern
{
    public class SocialSubject : ISubject
    {//Social subject inplements isubject interface;

        //Set references to required fields.
        List<ISocialObserver> observertList;
        String statusUpdate;
        String timeStamp;

        public SocialSubject()
        {
            //Allocate memory to class fields.
            observertList = new List<ISocialObserver>();
            statusUpdate = null;
            timeStamp = null;
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
            //update observes and pass in new data.
            foreach(ISocialObserver currentObserver in observertList)
            {
                currentObserver.Update(statusUpdate, timeStamp);
            }
        }

        public void InputTrigger(string statusUpdate)
        {
            //try capture input, create date and set to cirrect format.
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
