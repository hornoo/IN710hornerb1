using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsProgress
{
    public class ProgressBarObserver : TrackingObserver
    {
        ProgressBar inputProgressBar;


        public ProgressBarObserver(SlowWorker Subject, ProgressBar InputProgressBar)
            :base(Subject)
        {
            // subject is passed in, and subscribed to in the parent class.
            inputProgressBar = InputProgressBar;
        }

        public override void UpdateProgress(object o, EventArgs e)
        {
            inputProgressBar.PerformStep();
        }
    }
}
