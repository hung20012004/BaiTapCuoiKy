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
            set { instance = value; }
        }
        public List<Laptop> get()
        {
            List<Laptop> list = new List<Laptop>();
            conn.Open();
            using (var cmd = new SqlCommand("getLaptopData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Laptop laptop = new Laptop();
                    laptop.Laptop_ID = Convert.ToInt32(reader.GetString("laptop_id"));
                    laptop.Laptop_Name = reader.GetString("laptop_name");
                    laptop.Category_ID = Convert.ToInt32("category_id");
                    laptop.Manufactory_ID = Convert.ToInt32("manufactory");
                    laptop.CPU = reader.GetString("cpu");
                    laptop.RAM = reader.GetString("ram");
                    laptop.Hard_Drive = reader.GetString("hard_drive");
                    laptop.VGA = reader.GetString("vga");
                    laptop.Display = reader.GetString("display");
                    laptop.Battery = reader.GetString("battery");
                    laptop.Weight = Convert.ToInt32("weight");
                    laptop.Materials = reader.GetString("materials");
                    laptop.Ports = reader.GetString("ports");
                    laptop.Network_And_Connection = reader.GetString("network_and_connection");
                    laptop.Security = reader.GetString("security");
                    laptop.Keyboard = reader.GetString("keyboard");
                    laptop.Audio = reader.GetString("audio");
                    laptop.Size = reader.GetString("size");
                    laptop.OS = reader.GetString("os");
                    laptop.Warranty_Period = reader.GetString("warranty_period");
                    laptop.Price = Convert.ToDecimal("price");
                    laptop.Quantity = Convert.ToInt32("quantity");
                    list.Add(laptop);   
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
