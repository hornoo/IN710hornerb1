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
        String username;
        String password;
        bool dbConnected;

        SqlConnection bitDevConnection;

        public DatabaseWorker()
        {
            dbConnected = false;
            username = "";
            password = "";
            bitDevConnection = new SqlConnection();
        }


        public void RunQuery(DataGridView outputGrid, String queryString)
        {
            if(!dbConnected)
            {
                SetUpDatebaseConnection(username, password);
            }

            SqlCommand dataRequest = new SqlCommand();
            dataRequest.Connection = bitDevConnection;
            dataRequest.CommandText = queryString;

            SqlDataReader returnedDataReader;
            returnedDataReader = dataRequest.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(returnedDataReader);

            outputGrid.DataSource = dt;
   
            bitDevConnection.Close();
            dbConnected = false;
        }

        public void updateMark(int assignmentID, int newMark)
        {
            if (!dbConnected)
            {
                SetUpDatebaseConnection(username, password);
            }

            SqlCommand updateData = new SqlCommand();
            updateData.Connection = bitDevConnection;
            String inputQuery = "UPDATE tblAssignment SET mark=" + newMark +
                                 "WHERE assignmentID=" + assignmentID +";";

            updateData.CommandText = inputQuery;

            try
            {
                updateData.ExecuteNonQuery();
            }catch
            {

            }

            bitDevConnection.Close();
            dbConnected = false;

        }

        public bool SetUpDatebaseConnection(String Username, String Password)
        {
            username = Username;
            password = Password;

            bitDevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN700001_201601_HORNERB1;" +
                                                "User ID = " + Username + ";" +
                                                "Password = " + Password + ";";
            try
            {
                bitDevConnection.Open();
            }catch
            {
                Console.WriteLine("connection failed");
            }

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
