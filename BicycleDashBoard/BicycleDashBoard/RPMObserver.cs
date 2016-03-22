using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{
    class RPMObserver : BicycleObserver
    {

        public RPMObserver(SubjectBicycle bikeSubject, Label displayLabel )
            : base(bikeSubject, displayLabel)
        {

        }




        public override void Update(int data)
        {
            displayLabel.Text = data.ToString();
        }
    }
}
