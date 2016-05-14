using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;



namespace metronome
{
    public partial class Form1 : Form
    {
        private Metronome mainMetronome;
        private Beeper mainBeeper;
        private Counter mainCounter;
        private TimeDisplay mainTimeDisplay;
        //Define Thread so it can be accessed by all form buttons 
        Thread t1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainMetronome = new Metronome(1000, this);
            mainBeeper = new Beeper(mainMetronome, "blip1.wav");
            mainCounter = new Counter(mainMetronome, numericUpDown1);
            mainTimeDisplay = new TimeDisplay(mainMetronome, listBox1);    
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int currInterval = Convert.ToInt16(textBox1.Text);
           mainMetronome.Interval = currInterval;
            //Instantiate thread and pass in method to run on thread.
           t1 = new Thread(mainMetronome.start);
            //Run the method.
           t1.Start();
        }

        public void clearBuffer()
        {
            Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abort the separate thread.
            t1.Abort();   
        }

    }
}
