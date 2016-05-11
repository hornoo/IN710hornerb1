using System;
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
            dbworker.SetUpDatabase(tbUserName.Text.Trim().ToString(), tbPassword.Text.Trim().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbworker = new DatabaseWorker();
        }
    }
}
