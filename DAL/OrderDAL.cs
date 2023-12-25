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
    public class OrderDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect();
        private static OrderDAL instance = new();
        public static OrderDAL Instance
        {
            get { return instance; }
        }
        public void Open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public List<Order> get()
        {
            List<Order> list = new List<Order>();

            Open();
            using (var cmd = new SqlCommand("getOrder", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new Order();
                    order.Order_ID = reader.GetInt32("order_id");
                    order.Customer_ID = reader.GetInt32("customer_id");
                    order.Accountant_ID = reader.GetInt32("accountant_id");
                    order.Seller_ID= reader.GetInt32("seller_id");
                    order.Laptop_ID = reader.GetInt32("laptop_id");
                    order.DATE = reader.GetDateTime("order_date");
                    order.STATUS = reader.GetInt32("status");
                    order.Price = reader.GetDecimal("unit_price");
                    order.Quantity = reader.GetInt32("quantity");
                    list.Add(order);
                }
            }
            Close();
            return list;
        }
        public bool insert(Customer customer)
        {
            try
            {
                Open();
                using (var cmd = new SqlCommand("addKhachHang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = customer.Name;
                    cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = customer.Phone;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = customer.Address;
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool update(Customer customer)
        {
            try
            {
                Open();
                using (var cmd = new SqlCommand("updateKhachHang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer.ID;
                    cmd.Parameters.Add("@customer_name", SqlDbType.NVarChar).Value = customer.Name;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = customer.Phone;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = customer.Address;
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool delete(Customer customer)
        {
            try
            {
                Open();
                using (var cmd = new SqlCommand("deleteKhachHang", conn))
                {
                    cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer.ID;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool TimKiem(Customer customer)
        {
            try
            {
                Open();
                using (var cmd = new SqlCommand("timkiemKhachHang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = customer.ID;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = customer.Name;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = customer.Phone;
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}