using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateDemo
{
    public partial class Form1 : Form
    {
        List<int> numbersList;
        Random rand;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numbersList = new List<int>();
            rand = new Random();
        }

        private void btGenNum_Click(object sender, EventArgs e)
        {
            GenerateNumbers();
        }

        private void btEven_Click(object sender, EventArgs e)
        {

            List<int> returnList = new List<int>();

            //lambada expreccsing used to test if each int in the list it less than 10, if it is it is added to the return list.
            returnList = numbersList.FindAll(x => (x < 10));

            printList(returnList, lbOutPut);

        }

        private void btLessThan_Click(object sender, EventArgs e)
        {

            List<int> returnList = new List<int>();

            //lambada expreccsing used to test if each int in the list is a even number, if it is it is added to the return list.
            returnList = numbersList.FindAll(x => (x % 2) == 0);

            printList(returnList, lbOutPut);
        }

        private void GenerateNumbers()
        {
            numbersList.Clear();

            for(int i = 0; i < 100; i++)
            {
                numbersList.Add(rand.Next(100));
            }

            printList(numbersList, lbGen);
        }


        private void printList(List<int> inputList, ListBox outputBox)
        {
            outputBox.Items.Clear();

            foreach(int currentInt in inputList)
            {
                outputBox.Items.Add(currentInt);
            }
        }





    }
}
