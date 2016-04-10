using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsProgress
{
    class SpinBoxObserver : TrackingObserver
    {

        NumericUpDown inputSpinBox;
        Form inputForm;

        public SpinBoxObserver(SlowWorker Subject, NumericUpDown InputSpinBox, Form InputForm)
            : base(Subject)
        {
            // subject is passed in, and subscribed to in the parent class.
            inputSpinBox = InputSpinBox;
            inputForm = InputForm;
        }
        public override void UpdateProgress(object o, EventArgs e)
        {
            inputSpinBox.Value++;
            inputForm.Refresh();
        }
    }
}
