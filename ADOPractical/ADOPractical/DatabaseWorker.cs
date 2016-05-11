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

        public void SetUpDatabase(String Username, String Password)
        {
            SetUpdatebaseConnection(Username, Password);



        }

        private void SetUpdatebaseConnection(String Username, String Password)
        {
            bitDevConnection.ConnectionString = "Data Source = bitdev.ivt.op.ac.nz;"+
                                                "Initial Catalog = IN700001_201601_HORNERB1;" + 
                                                "User ID = " + Username+ ";" +
                                                "Password = " + Password + ";";

            bitDevConnection.Open();
        }
    }
}
