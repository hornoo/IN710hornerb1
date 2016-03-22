using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{//Child of BicycleObserver class, subject calls this classes updateMethod and passes in data.
    class RPMObserver : BicycleObserver
    {
        //Constructor
        public RPMObserver(SubjectBicycle bikeSubject, Label displayLabel )
            : base(bikeSubject, displayLabel)
        {

        }

        //passed in data is processed and stored in the currentComputedValue and then the Display() method is called
        public override void Update(int data)
        {
            currentRPM = data;

            currentComputedValue = currentRPM;

            Display();
        }
    }
}
