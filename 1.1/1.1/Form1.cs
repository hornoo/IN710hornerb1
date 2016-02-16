using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TwoToOne();

        }


         public void TwoToOne()
            {
            const int columnCount = 4;
            const int rowCount = 2;

	        Char[] oneDimensional = new Char[columnCount * rowCount];
            Char[,] twoDimensional = new Char[columnCount, rowCount] 
                    { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };

            // convert to one dimension
            for (int c = 0; c < columnCount; c++)
                for (int r = 0; r < rowCount; r++)
                {
                    //Add code here. DO NOT declare any new variables

                    oneDimensional[ c * 2 + r] = twoDimensional[c,r]; 
                }

            //printing one dimensional array
            for (int i = 0; i < columnCount * rowCount; i++)
                listBox1.Items.Add(oneDimensional[i]);
        }

        
    }
}
