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
        //Set References for objects 
        MonsterBuilder monsterbuilderWorker;
        HeadFactory headWorker;
        BodyFactory bodyWorker;
        Legfactory legsWorker;
        MonsterPrinter UIworker;

        List<String> comboBoxList;
        List<PictureBox> outputImageBoxeList;

        public Form1()
        {
            InitializeComponent();

            //instatiate required workers
            UIworker = new MonsterPrinter();

            //List of picture boxs to print to
            outputImageBoxeList = new List<PictureBox>() { pbhead, pbbody, pbLegs };

            //list of avaliable monsters to choose parts from
            comboBoxList = new List<string>() { "Fairy", "Frankenstein","Skeleton","Vampire","Werewolf","Witch" };
            
            //Populate combo boxes
            populateComboBox(cbhead, comboBoxList);
            populateComboBox(cbbody, comboBoxList);
            populateComboBox(cblegs, comboBoxList);


            headWorker = new HeadFactory();
            bodyWorker = new BodyFactory();
            legsWorker = new Legfactory();

            //Set initial monster on form
            monsterbuilderWorker = new MonsterBuilder(headWorker.requiredpart(cbhead.SelectedIndex),bodyWorker.requiredpart(cbbody.SelectedIndex),legsWorker.requiredpart(cblegs.SelectedIndex));

            UIworker.printMonster(outputImageBoxeList, monsterbuilderWorker);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on button click get idex of xombo box seleted pass to worker whr then returns required part to make full monster
            monsterbuilderWorker.monsterHead = headWorker.requiredpart(cbhead.SelectedIndex);
            monsterbuilderWorker.monsterBody = bodyWorker.requiredpart(cbbody.SelectedIndex);
            monsterbuilderWorker.monsterLegs = legsWorker.requiredpart(cblegs.SelectedIndex);

            // pass full monster and list of picture boxes to prin to
            UIworker.printMonster(outputImageBoxeList, monsterbuilderWorker);


        }

        //populate combobox and set initally selected item
        public void populateComboBox(ComboBox combobox, List<String> stringList)
        {
            foreach(String currentStrin in stringList)
            {
                combobox.Items.Add(currentStrin);
            }
            combobox.SelectedIndex = 1;
        }


    }
}
