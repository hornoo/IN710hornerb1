using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BicycleDashBoard
{//Base class for classes that will observer bike rpmsubject. implements Iobserver interface. 
    public abstract class BicycleObserver : IObserver
    {
        //Giels to record current passed in data from subject
        protected int currentRPM;
        //value to return when diplay() is called
        protected double currentComputedValue;
        //Label to print date from eevent
        protected Label displayLabel;
        //Subject to call its add observer method and add to its posting list
        protected SubjectBicycle bikesubject;

        //Constructor, passed in display label and subject.
        public BicycleObserver(SubjectBicycle bikesubject, Label displayLabel)
        {
            //allocate space in memory
            currentRPM = 0;
            currentComputedValue = 0;
            this.bikesubject = bikesubject;
            this.displayLabel = displayLabel;

            // this addes itself to the subjects observerlist.
            bikesubject.AddObserver(this);

        }

        // Abstract method to be define in children, can in clude processin of passed in data.
        public abstract void Update(int data);
       
        //Print tdata to lable on form when called.
        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }
}
