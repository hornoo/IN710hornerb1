using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsProgress
{
    public class UpdateFormObserver : TrackingObserver
    {

        
        public UpdateFormObserver(SlowWorker Subject) : base(Subject)
        {

        }

        public override void UpdateProgress(object o, EventArgs e)
        {
            Application.DoEvents();
        }
    }
}
