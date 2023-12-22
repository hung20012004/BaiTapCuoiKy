using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class StaffBUS
    {
        private static StaffBUS instance = new();
        public static StaffBUS Instance
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
        public void get(List<Staff> list)
        {
            list = StaffDAL.Instance.get();
        }
        public void insert(Staff staff)
        {
            StaffDAL.Instance.insert(staff);
        }
        public void update(Staff staff) {
            StaffDAL.Instance.update(staff);
        }
        public void delete(Staff staff)
        {
            StaffDAL.Instance.delete(staff);
        }
    }
}
