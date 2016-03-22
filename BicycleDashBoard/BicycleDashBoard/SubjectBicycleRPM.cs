using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BicycleDashBoard
{

    public class SubjectBicycle : ISubject
    {
        private List<IObserver> observerList;
        private int currentRPM;


        public SubjectBicycle()
        {
            observerList = new List<IObserver>();
            currentRPM = 0;
        }

        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        public void NofityObserver()
        {
            foreach(IObserver currentObserver in observerList)
            {
                currentObserver.Update(currentRPM);
            }
        }


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


            NofityObserver();

        }
    }
}
