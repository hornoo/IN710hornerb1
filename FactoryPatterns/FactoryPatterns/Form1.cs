using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPatterns
{
    public partial class Form1 : Form
    {   //set references to objects
        Graphics formCanvas; //to draw animals to 
        Random randomIntGenetator; // generating random animal picks
        NorthAmerica northAmericaCont; //Class to encapsulate sim of animals
        Australia australiaCont;// "" ""  ""
        UIOuput UIOutWorker;// class to handel output to the form

        public Form1()
        {
            //Instantiate required objects and assign memeory
            InitializeComponent();
            formCanvas = CreateGraphics();
            randomIntGenetator = new Random();
            northAmericaCont = new NorthAmerica(randomIntGenetator);
            australiaCont = new Australia(randomIntGenetator);
            UIOutWorker = new UIOuput(formCanvas, listBox1);
        }

        private void btAuz_Click(object sender, EventArgs e)
        {
            //Clear listbox befor printing to.
            UIOutWorker.clearListbox(listBox1);
            //Clear canvas befro drawing images on.
            UIOutWorker.clearCanvasImages(formCanvas);
            //Run animal sim, return a list of animal objects for the ui worker to draw to the form and print to the lsit box. 
            UIOutWorker.drawAndlistAnimal(australiaCont.runSim());
        }

        private void btUSA_Click(object sender, EventArgs e)
        {
            //Clear listbox befor printing to.
            UIOutWorker.clearListbox(listBox1);
            //Clear canvas befro drawing images on.
            UIOutWorker.clearCanvasImages(formCanvas);
            //Run animal sim, return a list of animal objects for the ui worker to draw to the form and print to the lsit box. 
            UIOutWorker.drawAndlistAnimal(northAmericaCont.runSim());
        }
    }
}
