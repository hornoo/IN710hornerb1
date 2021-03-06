﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsFireAlarm
{
    public partial class Form1 : Form
    {
        AlarmSubject subject;
        AlarmMessageAlertObserver messageAlert;
        AlarmBeepObserver beepAlert;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new AlarmSubject();

            //instantiate observers and pass in subject.
            messageAlert = new AlarmMessageAlertObserver(subject);
            beepAlert = new AlarmBeepObserver(subject);
        }

        private void btAlarm_Click(object sender, EventArgs e)
        {
            if(rbMinor.Checked)
            {
                subject.OnFireEvent(FireCatEnum.Minor);
            }else if(rbSerious.Checked)
            {
                subject.OnFireEvent(FireCatEnum.Serious);
            }
            else
            {
                subject.OnFireEvent(FireCatEnum.Inferno);
            }
        }



    }
}
