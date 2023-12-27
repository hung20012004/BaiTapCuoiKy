using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
            connetionString = @"Data Source=LAPTOP-42KL1AQC;Initial Catalog=Laptop_Store;Integrated Security=True;Trust Server Certificate=True";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }
        public static DataSet getData()
        {
            DataSet dataLaptop = new DataSet();
            cnn.Open();
            using (var cmd = new SqlCommand("getDiemThi", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dataLaptop);
            }
            cnn.Close();
            return dataLaptop;
        }
        public static void addData(Laptop Lt)
        {
            cnn.Open();
            using (var cmd = new SqlCommand("addDiemThi", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@masinhvien", SqlDbType.VarChar).Value = sv.MaSV;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = sv.Ten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = sv.NgaySinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.Int).Value = sv.GioiTinhINT;
                cmd.Parameters.Add("@diemgiuaky", SqlDbType.Decimal).Value = sv.DiemGiuaKy;
                cmd.Parameters.Add("@diemcuoiky", SqlDbType.Decimal).Value = sv.DiemCuoiKy;
                cmd.Parameters.Add("@diemchuyencan", SqlDbType.Decimal).Value = sv.DiemChuyenCan;
                cmd.ExecuteNonQuery();

            }
            conn.Close();
        }
    }
}
