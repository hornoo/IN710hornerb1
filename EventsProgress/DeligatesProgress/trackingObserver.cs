using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProgress
{
    public abstract class TrackingObserver
    {
        protected SlowWorker subject;


        public TrackingObserver(SlowWorker Subject)
        {
            subject = Subject;

            EventHandler OnUpdateEvent = new EventHandler(UpdateProgress);

            subject.progressEvent += OnUpdateEvent;

        }

        public abstract void UpdateProgress(object o,EventArgs e);

    }
}
