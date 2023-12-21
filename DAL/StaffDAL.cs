using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;
using System.Data.Common;

namespace DAL
{
    public class StaffDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect(); 
        private static StaffDAL instance=new();
        public static StaffDAL Instance
        {
            get { return instance; }
            set { instance = value; }
        }
        public List<Staff> get()
        {
            List<Staff> list = new List<Staff>();
            conn.Open();
            using (var cmd = new SqlCommand("getStaffData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();           
                while (reader.Read())
                {
                    Staff staff = new Staff();
                    staff.ID =Convert.ToInt32(reader.GetString("staff_id"));
                    staff.Name= reader.GetString("staff_name");
                    staff.Username= reader.GetString("username");
                    staff.Password= reader.GetString("password");
                    staff.Role = Convert.ToInt32(reader.GetString("role"));
                    list.Add(staff);
                }
            }
            conn.Close();
            return list;
        }
        public void insert()
        {

        }
        public void update()
        {

        }
        public void delete()
        {

        }
        
    }
}
