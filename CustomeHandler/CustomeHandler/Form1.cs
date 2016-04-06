using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomeHandler
{
    public partial class Form1 : Form
    {
        Random rand;
        CustomHandlerObserver ob1;
        CustomHandlerObserver ob2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();

            ob1 = new CustomHandlerObserver(btTestHandler, rand.Next(100));
            ob2 = new CustomHandlerObserver(btTestHandler, rand.Next(100));

        }


        private void btTestHandler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is the forms handler");
        }




    }
}
