using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConfig
    {
        private static DBConfig instance = new();   
        public static DBConfig Instance {  
            get { return instance; } 
        }
        public SqlConnection SQLConnect()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=LAPTOP-42KL1AQC;Initial Catalog=Laptop_Store;User ID=ha;Password=***********;Trust Server Certificate=True";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }

    }
}
