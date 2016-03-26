using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworkObserverPattern
{
    public class FriendObserver : ISocialObserver

    {
        String currentStatus;
        ISubject subject;
        ListBox displayOutputBox;

        public FriendObserver(ListBox DisplayOutPutBox, ISubject Subject)
        {
            currentStatus = null;
            subject = Subject;
            displayOutputBox = DisplayOutPutBox;

            subject.addObserver(this);
        }


        public void Update(string statusUpdate)
        {
            currentStatus = statusUpdate;
            
            Display();
        }

        public void Display()
        {
            displayOutputBox.Items.Add(DateTime.Now.ToString("ddd d MMM, yyyy HH:mm"));
            displayOutputBox.Items.Add(currentStatus);
        }
    }
}
