using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateScorer
{
    public partial class Form1 : Form
    {
        public delegate int ScoreDelegate(int correct, int incorrect);

        ScoreDelegate ScoreComputer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btScore_Click(object sender, EventArgs e)
        {
            if(rbadult.Checked)
            {
                ScoreComputer = new ScoreDelegate(Scorer.AdultScore);
            }
            else
            {
                ScoreComputer = new ScoreDelegate(Scorer.ChildScore);
            }

            

            lbScore.Text = ScoreComputer(Convert.ToInt32(tbcorrect.Text.Trim()), Convert.ToInt32(tbincorrect.Text.Trim())).ToString();
        }



    }
}
