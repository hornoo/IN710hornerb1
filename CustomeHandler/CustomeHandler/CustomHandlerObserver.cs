using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomeHandler
{
    class CustomHandlerObserver
    {

        int randomNumber;
        Button subject;

        public CustomHandlerObserver(Button Subject, int Randomnumber)
        {

            EventHandler messageEvent = new EventHandler(ShowMessage);

            subject = Subject;
            randomNumber = Randomnumber;

            subject.Click += messageEvent;

        }


     public void ShowMessage(object o, EventArgs e)
     {
         String messageOutput = "This is a Custom Handler \n";

         messageOutput += "My code is " + randomNumber + "\n";
         messageOutput += "My Type is " + this.GetType() + "\n";
         messageOutput += "I am Responding to button "  + subject.Name;


         MessageBox.Show(messageOutput);
     }

    }
}
