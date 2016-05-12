using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABOPracticalDataViewer
{
    public partial class Form1 : Form
    {
        DatabaseWorker databaseWorker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//Instantiate worker
            databaseWorker = new DatabaseWorker();
            
        }

        //this method is run on the dataGridViewend Edit event
        public void SetInputDataFromDGV(object o, DataGridViewCellEventArgs e)
        {
            //Checks which column was edited, if it was mark, it works out which cell and the id of  the row in the data base, gets
            // the value from the cell and runs the updateMark method.
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "mark")
            {
                Console.WriteLine("made it into to if");
                try
                {
                    int cellValue = (int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    int assignmentid = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    databaseWorker.updateMark(assignmentid, cellValue);
                }
                catch
                {

                }
                
            }


            

        }

        //Runs connection method and if successful, enables query buttons, (need to fix up spelling of buttons).
        private void btdbConnect_Click(object sender, EventArgs e)
        {
            String username = tbUsername.Text.Trim().ToString();
            String password = tbPassword.Text.Trim().ToString();

            if(databaseWorker.SetUpDatebaseConnection(username,password))
            {
                lbConnectStatus.Text = "Connected";
                btdbConnect.Enabled = false;
                btAveMark.Enabled = true;
                atAsDue2week.Enabled = true;
                blListAllPTandE.Enabled = true;
                button1.Enabled = true;
            }else
            {
                lbConnectStatus.Text = "connection failed";

            }


   
        }

        //the following methods run the passed in query to the run query method..
        private void blListAllPTandE_Click(object sender, EventArgs e)
        {
            String queryString = @"SELECT tblPaper.paperCode, tblLecturer.firstName, tblLecturer.lastName, tblLecturer.email FROM tblPaper
                                  JOIN tblLecturer ON tblPaper.lecturerID = tblLecturer.lecturerID;";

            databaseWorker.RunQuery(dataGridView1,queryString);
        }

        private void atAsDue2week_Click(object sender, EventArgs e)
        {
            String queryString = @"SELECT tblPaper.paperCode, tblAssignment.assignmentname, tblAssignment.dueDate FROM tblAssignment
                                   JOIN tblPaper ON tblAssignment.paperID = tblPaper.paperID 
                                   WHERE tblAssignment.dueDate BETWEEN GETDATE() and DATEADD(week,2,GETDATE());";
            databaseWorker.RunQuery(dataGridView1, queryString);
        }

        private void btAveMark_Click(object sender, EventArgs e)
        {
            String queryString = @"SELECT tblPaper.paperCode, AVG(tblAssignment.mark)AS 'Average mark' FROM tblAssignment
                                  JOIN tblPaper ON tblAssignment.paperID = tblPaper.paperID 
                                  WHERE mark IS NOT NULL GROUP BY tblPaper.papercode;";

            databaseWorker.RunQuery(dataGridView1, queryString);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String queryString = @"SELECT tblAssignment.assignmentID, tblPaper.paperCode, tblAssignment.assignmentname, tblAssignment.assignDescription, mark , tblAssignment.dueDate FROM tblAssignment
                                   JOIN tblPaper ON tblAssignment.paperID = tblPaper.paperID";

            databaseWorker.RunQuery(dataGridView1, queryString);
        }


    }
}
