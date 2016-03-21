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

            UIworker = new MonsterPrinter();

            outputImageBoxeList = new List<PictureBox>() { pbhead, pbbody, pbLegs };

   
            comboBoxList = new List<string>() { "Fairy", "Frankenstein" };
            populateComboBox(cbhead, comboBoxList);
            populateComboBox(cbbody, comboBoxList);
            populateComboBox(cblegs, comboBoxList);


            headWorker = new HeadFactory();
            bodyWorker = new BodyFactory();
            legsWorker = new Legfactory();


            monsterbuilderWorker = new MonsterBuilder(headWorker.requiredpart(cbhead.SelectedIndex),bodyWorker.requiredpart(cbbody.SelectedIndex),legsWorker.requiredpart(cblegs.SelectedIndex));

            UIworker.printMonster(outputImageBoxeList, monsterbuilderWorker);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monsterbuilderWorker.monsterHead = headWorker.requiredpart(cbhead.SelectedIndex);
            monsterbuilderWorker.monsterBody = bodyWorker.requiredpart(cbbody.SelectedIndex);
            monsterbuilderWorker.monsterLegs = legsWorker.requiredpart(cblegs.SelectedIndex);

            UIworker.printMonster(outputImageBoxeList, monsterbuilderWorker);


        }


        public void populateComboBox(ComboBox combobox, List<String> stringList)
        {
            foreach(String currentStrin in stringList)
            {
                combobox.Items.Add(currentStrin);
            }
            combobox.SelectedIndex = 1;
        }

        private void pbLegs_Click(object sender, EventArgs e)
        {

        }
    }
}
