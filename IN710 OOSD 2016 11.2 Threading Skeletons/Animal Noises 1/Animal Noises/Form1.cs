using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Animal mainAnimal;
        //Allocate a memory address for the thread and open the scope so other buttons on the form can access it.
        Thread workerThread1;

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();
            
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            //Create new thread and pass in method to run. The start the thread;
            workerThread1 = new Thread(mainAnimal.speak);
            workerThread1.Start();
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            //Abort the thread.
            workerThread1.Abort();
        }


    }
}
