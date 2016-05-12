using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABOPracticalDataViewer
{
    class DatabaseWorker
    {
        //Fields to store user name and password that are passed in.
        String username;
        String password;
        //Bool to keep track of if there is a connection to the data base.
        bool dbConnected;

        SqlConnection bitDevConnection;

        public DatabaseWorker()
        {//Instantiate 
            dbConnected = false;
            username = "";
            password = "";
            bitDevConnection = new SqlConnection();
        }


        public void RunQuery(DataGridView outputGrid, String queryString)
        {
            //Check if there is a data base connection, if not run connection method with stored credentials.
            if(!dbConnected)
            {
                SetUpDatebaseConnection(username, password);
            }

            //Set up query
            SqlCommand dataRequest = new SqlCommand();
            //ADD Connection and passed in Query String
            dataRequest.Connection = bitDevConnection;
            dataRequest.CommandText = queryString;
            //Create reader and run query.
            SqlDataReader returnedDataReader;
            returnedDataReader = dataRequest.ExecuteReader();

            //Convert returned data into a data table 
            DataTable dt = new DataTable();
            dt.Load(returnedDataReader);

            //Set the data grid views data source to the data table(this also updates the screen).
            outputGrid.DataSource = dt;
            
            //Close the connection, change dbconnected to false.(don't really need te dbConnected variable could just check the state of the connection)
            bitDevConnection.Close();
            dbConnected = false;
        }

        public void updateMark(int assignmentID, int newMark)
        {
            //Check if the data base is connected or not
            if (!dbConnected)
            {
                SetUpDatebaseConnection(username, password);
            }

            //Added Create sql query, then create the query string with the passed in mark and row id to be modified, really needs to erro checking and data validation here.
            SqlCommand updateData = new SqlCommand();
            updateData.Connection = bitDevConnection;
            String inputQuery = "UPDATE tblAssignment SET mark=" + newMark +
                                 "WHERE assignmentID=" + assignmentID +";";

            updateData.CommandText = inputQuery;
            // try run the query
            try
            {
                updateData.ExecuteNonQuery();
            }catch
            {

            }
//close the connection.
            bitDevConnection.Close();
            dbConnected = false;

        }

        public bool SetUpDatebaseConnection(String Username, String Password)
        {   //store passed in credentials
            username = Username;
            password = Password;
            //Build connection string
            bitDevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN700001_201601_HORNERB1;" +
                                                "User ID = " + Username + ";" +
                                                "Password = " + Password + ";";

            //try open the connection
            try
            {
                bitDevConnection.Open();
            }catch
            {
                Console.WriteLine("connection failed");
            }
            //check if the connection is open and retrun tru other was return false.
           if(bitDevConnection.State == System.Data.ConnectionState.Open)
           {
               dbConnected = true;
               return true;
           }else
           {
               return false;
           }

           

        }
    }
}
