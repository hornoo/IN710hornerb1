using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace metronome
{
    //Define Delegate signature to pass into invoke method to update form controls. I made this delegate generic so I didn't have to create 2 different delegates 
    //one for the spin box(no data required, and one for the list box where a DateTime is required.)
    delegate void UpdateFormControlDelegate(metronomeEventArgs e);

    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        

        private NumericUpDown spinBox;

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        //Method to update spinBox, method signature matches Delegate that will be invoked by spinBox thread.
        private void updateSpinbox(metronomeEventArgs e)
        {
            spinBox.Value++;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            //Compare if the calling thread is the same as the creating thread of the spinBox. if different, returns true.
            if (spinBox.InvokeRequired)
            {
                //Create delegate and pass in method to run from delegate.
                UpdateFormControlDelegate updateSpinBoxDelegate = new UpdateFormControlDelegate(updateSpinbox);
                //Get the spinbox(original Creating thread) to invoke\call\run the delegate and pass in the arguments as an array. 
                spinBox.Invoke(updateSpinBoxDelegate, new object[] { e });//spinbox updates on form, 

            }
            else
            {
                spinBox.Value++;
            }
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        //Define delegate 
        delegate void UpdateListBoxDateTime(DateTime InputDateTime);

        private ListBox listBox;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        //Method to print DateTime to listBox, method signature matches Delegate that will be invoked by listBox thread.
        public void updateDateTimeListBox(metronomeEventArgs e)
        {
            //Create date time from passed in object.
            DateTime currDateTime = e.currentTime;
            listBox.Items.Add(currDateTime.ToString());
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if(listBox.InvokeRequired)
            {
                //Create delegate and pass in method to run from delegate.
                UpdateFormControlDelegate updateListBoxDateTimeDelegate = new UpdateFormControlDelegate(updateDateTimeListBox);
                //Get the listBox(original Creating thread) to invoke\call\run the delegate and pass in the arguments as an array.
                listBox.Invoke(updateListBoxDateTimeDelegate, new object[]{e});   //update list box from passed in array of arguments.  

            }
            else{

                updateDateTimeListBox(e);
 
            }
        }
    }






            
}
