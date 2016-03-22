using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BicycleDashBoard
{
    public abstract class BicycleObserver : IObserver
    {
        protected int currentRPM;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected SubjectBicycle bikesubject;


        public BicycleObserver(SubjectBicycle bikesubject, Label displayLabel)
        {
            currentRPM = 0;
            currentComputedValue = 0;
            this.bikesubject = bikesubject;
            this.displayLabel = displayLabel;

            bikesubject.AddObserver(this);

        }


        public abstract void Update(int data);
       

        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }
}
