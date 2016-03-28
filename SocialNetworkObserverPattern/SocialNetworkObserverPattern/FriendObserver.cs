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
        //set field referneces
        String currentStatus;
        String currentTimeStamp;
        ISubject subject;
        ListBox displayOutputBox;

        public FriendObserver(ListBox DisplayOutPutBox, ISubject Subject)
        {
             //allocate memory to references.
            currentStatus = null;
            currentTimeStamp = null;
            subject = Subject;
            displayOutputBox = DisplayOutPutBox;

            //add this object to subject observer list
            subject.addObserver(this);
        }


        //update fields with new data and run display mehtod.
        public void Update(string statusUpdate, String timeStamp)
        {
            currentStatus = statusUpdate;
            currentTimeStamp = timeStamp;
            
            Display();
        }

        public void Display()
        {
            displayOutputBox.Items.Add(currentTimeStamp);
            displayOutputBox.Items.Add(currentStatus);
        }
    }
}
