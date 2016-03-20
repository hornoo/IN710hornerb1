using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IComputerfactory FactoryWorker;

        private void btPritnSpeck_Click(object sender, EventArgs e)
        {
            if (rbGame.Checked)
            {
                FactoryWorker = new GameCompFactory();
            }else if(rbBus.Checked)
            {
                FactoryWorker = new BusCompFactory();
            }else if(rbMultilM.Checked)
            {
                FactoryWorker = new MultimediaCompFactory();
            } else
            {
                FactoryWorker = new LaptopFactory();
            }

            

            CPU curCPU = FactoryWorker.makeCpu();
            GPU curGPU = FactoryWorker.makeGPU();
            RAM curRAM = FactoryWorker.makeRAM();
            PowerSupply curPSU = FactoryWorker.makePSU();

            int totalPrice = curCPU.ComponentPrice + curGPU.ComponentPrice + curRAM.ComponentPrice + curPSU.ComponentPrice;

            listBox1.Items.Clear();

            listBox1.Items.Add("Prices\tComponent");
            listBox1.Items.Add("=====================================");

            listBox1.Items.Add(curCPU.ToString());
            listBox1.Items.Add(curGPU.ToString());
            listBox1.Items.Add(curRAM.ToString());
            listBox1.Items.Add(curPSU.ToString());

            listBox1.Items.Add("=====================================");

            listBox1.Items.Add("Total Price: $" + totalPrice);


        }
    }
}
