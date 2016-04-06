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



        public TrackbarObserver(SlowWorker Subject, TrackBar InputTrackBar):base(Subject)
        {

        }

        public override void UpdateProgress(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
