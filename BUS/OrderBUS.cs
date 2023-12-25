using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class OrderBUS
    {
        private static OrderBUS instance = new();
        public static OrderBUS Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public List<Order> get()
        {
            return OrderDAL.Instance.get();
        }
    }
}