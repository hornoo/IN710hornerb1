using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsProgress
{
    public class TrackbarObserver : TrackingObserver
    {
        TrackBar inputTrackBar;


        public TrackbarObserver(SlowWorker Subject, TrackBar InputTrackBar)
            :base(Subject)
        {
            // subject is passed in, and subscribed to in the parent class.
            inputTrackBar = InputTrackBar;
        }

        public override void UpdateProgress(object o, EventArgs e)
        {
            inputTrackBar.Value++;
        }
    }
}
