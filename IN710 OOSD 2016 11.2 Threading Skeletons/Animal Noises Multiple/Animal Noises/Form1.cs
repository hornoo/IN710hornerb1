using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Animal> animalList;
        private List<Thread> threadList;

        //Shared object to lock on
        string sharedString;
      

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Set value of locking object
            sharedString = "value not used for anything";
            animalList = new List<Animal>();
            threadList = new List<Thread>();

            //Pass shared object into each instance that will be run by a separate thread.
            animalList.Add(new Animal("bss.wav", sharedString));
            animalList.Add(new Animal("frog.wav",sharedString));
            animalList.Add(new Animal("duck.wav",sharedString));
            animalList.Add(new Animal("meow.wav",sharedString));
            

            for (int i = 0; i < animalList.Count; i++)
                threadList.Add(new Thread(animalList[i].speak)); 
            
            for (int i = 0; i < animalList.Count; i++)
                threadList[i].Start();

            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < animalList.Count; i++)
                threadList[i].Abort();
        }


    }
}
