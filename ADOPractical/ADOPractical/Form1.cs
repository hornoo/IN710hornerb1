﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPractical
{
    public partial class Form1 : Form
    {
        DatabaseWorker dbworker;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCreateTablesAddData_Click(object sender, EventArgs e)
        {
            //Run set up query and display about of rows modified.
            lbRowsFeedBack.Text = Convert.ToString(dbworker.SetUpDatabase(tbUserName.Text.Trim().ToString(), tbPassword.Text.Trim().ToString()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {//Instantiate database worker
            dbworker = new DatabaseWorker();
        }
    }
}
