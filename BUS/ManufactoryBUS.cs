using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ManufactoryBUS
    {
        private static ManufactoryBUS instance = new();
        public static ManufactoryBUS Instance
        {
            get { return instance; }
        }

        public List<Manufactory> get()
        {
            return ManufactoryDAL.Instance.get();
        }
    }
}
