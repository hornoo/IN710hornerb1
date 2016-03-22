using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BicycleDashBoard
{
    // Subject class implements ISubect. This class stores reffernce to all observers in a List, when trigged  the update() method for
    //each observer instance in the observer list is triggered and passe dint he new data value.
    public class SubjectBicycle : ISubject
    {
        //List to store referneces to observer classes
        private List<IObserver> observerList;
        //Current rpn storred as int, this is passed to observerclasses via their update method.
        private int currentRPM;

        //Constructor
        public SubjectBicycle()
        {   //Allocating memorey
            observerList = new List<IObserver>();
            currentRPM = 0;
        }

        //called by observer to add itself to subject list
        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        //Called to remove and observer refernce(not used in this project)
        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        //This notifies each obesrver by calling there update method and pass in the value stored in currentRPM(which is updated when inputtriggger() is call on an instantiation of this subject.
        public void NotifyObserver()
        {
            foreach(IObserver currentObserver in observerList)
            {
                currentObserver.Update(currentRPM);
            }
        }

        //Takes a input string, trys to convert to and in and store in current rpm. if successful calls own NotifyObserver() method what then passes new value to all observers. 
        public void InputTrigger(string inputstring)
        {

            try
            {
                currentRPM = Int32.Parse(inputstring);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
            }


            NotifyObserver();

        }
    }
}
