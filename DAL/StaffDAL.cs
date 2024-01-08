using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;
using System.Data.Common;
using System.Collections;

namespace DAL
{
    public class StaffDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect(); 
        private static StaffDAL instance=new();
        public static StaffDAL Instance
        {
            get { return instance; }
        }
        public List<Staff> get()
        {
            List<Staff> list = new List<Staff>();
            conn.Open();
            using (var cmd = new SqlCommand("GetStaffData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();           
                while (reader.Read())
                {
                    Staff staff = new Staff();
                    staff.ID =reader.GetInt32("staff_id");
                    staff.Name= reader.GetString("staff_name");
                    staff.Username= reader.GetString("username");
                    staff.Password= reader.GetString("password");
                    staff.RoleInt = reader.GetInt32("role");
                    staff.Password = MD5Security.Decrypt(staff.Password, "20012004", true);
                    list.Add(staff);
                }
            }
            conn.Close();
            return list;
        }
    }
}
