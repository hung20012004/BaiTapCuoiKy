using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class LaptopBUS
    {
        private static LaptopBUS instance = new();
        public static LaptopBUS Instance
        {
            get { return instance; }
            set { instance = value; }
        }
        public bool checkLogInfo(Staff staff)
        {
            foreach (Staff item in StaffDAL.Instance.get())
            {
                if (staff.Username == item.Username && staff.Password == item.Password)
                {
                    staff = item;
                    return true;
                }
            }
            return false;
        }
        public void get(List<Laptop> list)
        {
            list = LaptopDAL.Instance.get();
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