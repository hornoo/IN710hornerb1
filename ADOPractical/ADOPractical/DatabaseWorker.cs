using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPractical
{
    public class DatabaseWorker
    {
        SqlConnection bitDevConnection;


        public DatabaseWorker()
        {
            bitDevConnection = new SqlConnection();
        }

        public int SetUpDatabase(String Username, String Password)
        {
            SetUpdatebaseConnection(Username, Password);

            SqlCommand setUpTables = new SqlCommand();

            setUpTables.Connection = bitDevConnection;


            String inputQuery = @"IF OBJECT_ID('tblAssignment') IS NOT NULL DROP TABLE tblAssignment
                                IF OBJECT_ID('tblPaper') IS NOT NULL DROP TABLE tblPaper  
                                IF OBJECT_ID('tblLecturer') IS NOT NULL DROP TABLE tblLecturer
                                CREATE TABLE tblLecturer
                                (
                                lecturerID   int     IDENTITY,
                                firstName    varchar(20) NOT NULL,
                                lastName     varchar(20) NOT NULL,
                                email        varchar(64) NOT NULL,
                                CONSTRAINT PK_tblLecturer PRIMARY KEY(lecturerID)
                                )
                                CREATE TABLE tblPaper
                                (
                                paperID				int			IDENTITY,
                                lecturerID			int			NOT NULL,
                                paperCode			varchar(20)	NOT NULL,
                                CONSTRAINT PK_paperID PRIMARY KEY(paperID),
                                CONSTRAINT FP_paper_lecturer FOREIGN KEY(lecturerID) REFERENCES tblLecturer(lecturerID)
                                )
                                CREATE TABLE tblAssignment
                                (
                                assignmentID		int			IDENTITY,
                                paperID				int			NOT NULL,
                                assignmentname		varchar(20) NOT NULL,
                                assignDescription	varchar(100) NOT NULL,
                                mark			    int			 NULL,
                                dueDate				date	NOT NULL,
                                CONSTRAINT PK_assignmentID PRIMARY KEY(assignmentID),
                                CONSTRAINT FK_assignmentPaper FOREIGN KEY(paperID) REFERENCES tblPaper(paperID) 
                                )
                                INSERT INTO tblLecturer VALUES
                                ('Patricia','Haden','phaden@op.ac.nz'),
                                ('Christopher','Frantz','cfrantz@op.ac.nz'),
                                ('Tom','Clark','tclark@op.ac.nz'),
                                ('David','Rozado','david.razdo@op.ac.nz')
                                INSERT INTO tblPaper VALUES
                                (1,'OOSD'),
                                (1,'Mobile'),
                                (2,'Systems Admin'),
                                (3,'Project 1'),
                                (4,'Web 3')
                                INSERT INTO tblAssignment VALUES
                                (1,'Diffusion Simulator','Demonstrate Architecture Knowledge',100,'2016-05-02')
                                (1,'DB and Multi-thread','Demonstrate DB and MultiThread Knowledge','2016-05-18')
                                (2,'Portfolio','Show work from first semester','2016-3105-31');


            setUpTables.CommandText = inputQuery;

            int RowsCreated = setUpTables.ExecuteNonQuery();

            bitDevConnection.Close();

            return RowsCreated;

        }

        private void SetUpdatebaseConnection(String Username, String Password)
        {
            bitDevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;"+
                                                "Initial Catalog = IN700001_201601_HORNERB1;" + 
                                                "User ID = " + Username+ ";" +
                                                "Password = " + Password + ";";

            bitDevConnection.Open();
        }
    }
}
