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

        List<String> comboBoxList;

        public Form1()
        {
            InitializeComponent();
   
            comboBoxList = new List<string>() { "Fairy", "Frankenstein" };
            populateComboBox(cbhead, comboBoxList);
            populateComboBox(cbbody, comboBoxList);
            populateComboBox(cblegs, comboBoxList);
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }


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
