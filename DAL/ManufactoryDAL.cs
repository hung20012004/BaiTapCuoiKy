using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ManufactoryDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect();
        private static ManufactoryDAL instance = new();
        public static ManufactoryDAL Instance
        {
            get { return instance; }
        }
        public List<Manufactory> get()
        {
            List<Manufactory> list = new List<Manufactory>();
            conn.Open();
            using (var cmd = new SqlCommand("GetManufactory", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Manufactory manufactory = new Manufactory();
                    manufactory.ID = reader.GetInt32("manufactory_id");
                    manufactory.Name = reader.GetString("manufactory_name");
                    manufactory.Website = reader.GetString("website");
                    manufactory.Address = reader.GetString("address");
                }
            }
            conn.Close();
            return list;
        }
    }
}
