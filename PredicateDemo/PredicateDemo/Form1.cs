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
            Predicate<int> isEvenPred = new Predicate<int>(isAnEvenNumber);

            List<int> returnList = new List<int>();

            returnList = numbersList.FindAll(isEvenPred);

            printList(returnList, lbOutPut);

        }

        private void btLessThan_Click(object sender, EventArgs e)
        {
            Predicate<int> isLeesThanTenPred = new Predicate<int>(isLessThanTen);

            List<int> returnList = new List<int>();

            returnList = numbersList.FindAll(isLeesThanTenPred);

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

        private bool isAnEvenNumber(int inputInt)
        {
            bool returnValue = ((inputInt % 2) == 0);
            return returnValue;
        }

        private bool isLessThanTen(int inputInt)
        {
            bool returnValue = (inputInt < 10);
            return returnValue;
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
