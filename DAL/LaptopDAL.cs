using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL

{
    public class LaptopDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect();
        private static LaptopDAL instance = new();
        public static LaptopDAL Instance
        {
            get { return instance; }
        }
        public List<Laptop> get()
        {
            List<Laptop> list = new List<Laptop>();
            conn.Open();
            using (var cmd = new SqlCommand("GetStaff", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Laptop laptop = new Laptop();
                    laptop.ID = Convert.ToInt32(reader.GetString("ID"));
                    laptop.Name = reader.GetString("name");
                    laptop.Category.ID = Convert.ToInt32("categoryID");
                    laptop.Manufactory.ID = Convert.ToInt32("manufactoryID");
                    laptop.CPU = reader.GetString("cpu");
                    laptop.Ram = reader.GetString("ram");
                    laptop.HardDriver = reader.GetString("hardDriver");
                    laptop.VGA = reader.GetString("vga");
                    laptop.Display = reader.GetString("display");
                    laptop.Battery = reader.GetString("battery");
                    laptop.Weight = Convert.ToInt32("weight");
                    laptop.Material = reader.GetString("material");
                    laptop.Port = reader.GetString("port");
                    laptop.Connection = reader.GetString("connection");
                    laptop.Security = reader.GetString("security");
                    laptop.Keyboard = reader.GetString("keyboard");
                    laptop.Audio = reader.GetString("audio");
                    laptop.Size = reader.GetString("size");
                    laptop.OS = reader.GetString("os");
                    laptop.WarrantyPeriod = reader.GetString("warrantyPeriod");
                    laptop.Price = reader.GetString("price");
                    laptop.QuantityInStock = Convert.ToInt32("quantityInStock");
                    list.Add(laptop);
                }
            }
            conn.Close();
            return list;
        }
        public bool insert(Laptop laptop)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("InsertLaptop", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = laptop.Name;
                    cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = laptop.Category.ID;
                    cmd.Parameters.Add("@manufactoryID", SqlDbType.Int).Value = laptop.Manufactory.ID;
                    cmd.Parameters.Add("@cpu", SqlDbType.NVarChar).Value = laptop.CPU;
                    cmd.Parameters.Add("@ram", SqlDbType.NVarChar).Value = laptop.Ram;
                    cmd.Parameters.Add("@hardDriver", SqlDbType.NVarChar).Value = laptop.HardDriver;
                    cmd.Parameters.Add("@vga", SqlDbType.NVarChar).Value = laptop.VGA;
                    cmd.Parameters.Add("@display", SqlDbType.NVarChar).Value = laptop.Display;
                    cmd.Parameters.Add("@battery", SqlDbType.NVarChar).Value = laptop.Battery;
                    cmd.Parameters.Add("@weight", SqlDbType.Float).Value = laptop.Weight;
                    cmd.Parameters.Add("@material", SqlDbType.NVarChar).Value = laptop.Material;
                    cmd.Parameters.Add("@port", SqlDbType.NVarChar).Value = laptop.Port;
                    cmd.Parameters.Add("@connection", SqlDbType.NVarChar).Value = laptop.Connection;
                    cmd.Parameters.Add("@security", SqlDbType.NVarChar).Value = laptop.Security;
                    cmd.Parameters.Add("@keyboard", SqlDbType.NVarChar).Value = laptop.Keyboard;
                    cmd.Parameters.Add("@audio", SqlDbType.NVarChar).Value = laptop.Audio;
                    cmd.Parameters.Add("@size", SqlDbType.NVarChar).Value = laptop.Size;
                    cmd.Parameters.Add("@os", SqlDbType.NVarChar).Value = laptop.OS;
                    cmd.Parameters.Add("@warrantyPeriod", SqlDbType.NVarChar).Value = laptop.WarrantyPeriod;
                    cmd.Parameters.Add("@price", SqlDbType.NVarChar).Value = laptop.Price;
                    cmd.Parameters.Add("@quantityInStock", SqlDbType.Int).Value = laptop.QuantityInStock;

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool update(Laptop laptop)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("UpdateLaptop", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = laptop.ID;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = laptop.Name;
                    cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = laptop.Category.ID;
                    cmd.Parameters.Add("@manufactoryID", SqlDbType.Int).Value = laptop.Manufactory.ID;
                    cmd.Parameters.Add("@cpu", SqlDbType.NVarChar).Value = laptop.CPU;
                    cmd.Parameters.Add("@ram", SqlDbType.NVarChar).Value = laptop.Ram;
                    cmd.Parameters.Add("@hardDriver", SqlDbType.NVarChar).Value = laptop.HardDriver;
                    cmd.Parameters.Add("@vga", SqlDbType.NVarChar).Value = laptop.VGA;
                    cmd.Parameters.Add("@display", SqlDbType.NVarChar).Value = laptop.Display;
                    cmd.Parameters.Add("@battery", SqlDbType.NVarChar).Value = laptop.Battery;
                    cmd.Parameters.Add("@weight", SqlDbType.Float).Value = laptop.Weight;
                    cmd.Parameters.Add("@material", SqlDbType.NVarChar).Value = laptop.Material;
                    cmd.Parameters.Add("@port", SqlDbType.NVarChar).Value = laptop.Port;
                    cmd.Parameters.Add("@connection", SqlDbType.NVarChar).Value = laptop.Connection;
                    cmd.Parameters.Add("@security", SqlDbType.NVarChar).Value = laptop.Security;
                    cmd.Parameters.Add("@keyboard", SqlDbType.NVarChar).Value = laptop.Keyboard;
                    cmd.Parameters.Add("@audio", SqlDbType.NVarChar).Value = laptop.Audio;
                    cmd.Parameters.Add("@size", SqlDbType.NVarChar).Value = laptop.Size;
                    cmd.Parameters.Add("@os", SqlDbType.NVarChar).Value = laptop.OS;
                    cmd.Parameters.Add("@warrantyPeriod", SqlDbType.NVarChar).Value = laptop.WarrantyPeriod;
                    cmd.Parameters.Add("@price", SqlDbType.NVarChar).Value = laptop.Price;
                    cmd.Parameters.Add("@quantityInStock", SqlDbType.Int).Value = laptop.QuantityInStock;

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool delete(Laptop laptop)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("Deletelaptop", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = laptop.ID;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
