using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworkObserverPattern
{
    public partial class Form1 : Form
    {

        SocialSubject mainSubject;
        FriendObserver friend1;
        FriendObserver friend2;
        FriendObserver friend3;
        FriendObserver friend4;
        FriendObserver mainSubjectObserver;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainSubject = new SocialSubject();

            mainSubjectObserver = new FriendObserver(lbMain, mainSubject);
            friend1 = new FriendObserver(lbf1, mainSubject);
            friend2 = new FriendObserver(lbf2, mainSubject);
            friend3 = new FriendObserver(lbf3, mainSubject);
            friend4 = new FriendObserver(lbf4, mainSubject);

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            mainSubject.InputTrigger(tbInput.Text.ToString().Trim());
        }
    }
}
