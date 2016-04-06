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

        public SpinBoxObserver(SlowWorker Subject, NumericUpDown InputSpinBox)
            : base(Subject)
        {
            inputSpinBox = InputSpinBox;
        }
        public override void UpdateProgress(object o, EventArgs e)
        {
            inputSpinBox.Value++;
        }
    }
}
