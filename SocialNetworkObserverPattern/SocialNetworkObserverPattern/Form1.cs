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

        SocialSubject MainSubject;
        FriendObserver friend1;
        FriendObserver friend2;
        FriendObserver friend3;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainSubject = new SocialSubject();

            friend1 = new FriendObserver(lbf1, MainSubject);
            friend2 = new FriendObserver(lbf2, MainSubject);
            friend3 = new FriendObserver(lbf3, MainSubject);

        }

        private void btInput_Click(object sender, EventArgs e)
        {

        }
    }
}
