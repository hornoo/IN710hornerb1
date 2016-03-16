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
    {
        Graphics formCanvas;
        Random randomIntGenetator;
        NorthAmerica northAmericaCont;
        Australia australiaCont;
        UIOuput UIOutWorker;

        public Form1()
        {
            InitializeComponent();
            formCanvas = CreateGraphics();
            randomIntGenetator = new Random();
            northAmericaCont = new NorthAmerica(4, randomIntGenetator);
            australiaCont = new Australia(4, randomIntGenetator);
            UIOutWorker = new UIOuput(formCanvas, listBox1);
        }

        private void btAuz_Click(object sender, EventArgs e)
        {
            UIOutWorker.clearListbox(listBox1);
            UIOutWorker.clearCanvasImages(formCanvas);
            UIOutWorker.drawAndlistAnimal(australiaCont.runSim());
        }

        private void btUSA_Click(object sender, EventArgs e)
        {
            UIOutWorker.clearListbox(listBox1);
            UIOutWorker.clearCanvasImages(formCanvas);
            UIOutWorker.drawAndlistAnimal(northAmericaCont.runSim());
        }
    }
}
