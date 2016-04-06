using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProgress
{
    public class SlowWorker
    {
        
        public event EventHandler progressEvent;

        public void OnUpdateEvent()
        {
            EventArgs pe = new EventArgs();

            if (progressEvent != null)
            {
                progressEvent(this, pe);
            }
        }


        public void SlowMetthod()
        {
            for(int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent();
            }
        }
    }
}
