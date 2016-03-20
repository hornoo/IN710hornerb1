using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterFactory
{
    public partial class Form1 : Form
    {
        FairyFactory FairyFactoryWorker;
        FrankensteinFactory FrankFactoryWorker;

        public Form1()
        {
            InitializeComponent();
            FairyFactoryWorker = new FairyFactory();
            FrankFactoryWorker = new FrankensteinFactory();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
