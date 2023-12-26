using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance = new();
        public static CustomerBUS Instance
        {
            get { return instance; }
            set { instance = value; }
        }
    }
}
