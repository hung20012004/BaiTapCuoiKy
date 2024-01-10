using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportInvoice
    {
        private List<Laptop> laptops = new List<Laptop>();
        public List<Laptop> Laptops
        {
            get { return laptops; }
            set { laptops = value; }
        }
        private Staff warehouseKeeper = new Staff();
        public Staff WarehouseKeeper
        {
            get { return warehouseKeeper; }
            set { warehouseKeeper = value; }
        }
        private Staff accountant = new Staff();
        public Staff Accountant
        {
            get { return accountant; }
            set { accountant = value; }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private Provider provider = new Provider();
        public Provider Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        private DateTime updateTime;
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        private DateTime importDate;
        public DateTime ImportDate
        {
            get { return importDate; }
            set { importDate = value; }
        }
        private string note;
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        private string statusString;
        public string StatusString
        {
            get { return statusString; }
            set { statusString = value; setStatusInt(); }
        }
        private int statusInt;
        public int StatusInt
        {
            get { return statusInt; }
            set { statusInt = value; setStatusString(); }
        }
        private void setStatusString()
        {
            switch (statusInt)
            {
                case 1:
                    statusString = "Đang xử lý";
                    break;
                case 2:
                    statusString = "Đã thanh toán";
                    break;
                case 0:
                    statusString = "Đã hủy";
                    break;
            }
        }
        private void setStatusInt()
        {
            switch (statusString)
            {
                case "Đang xử lý":
                    statusInt = 1;
                    break;
                case "Đã thanh toán":
                    statusInt = 2;
                    break;
                case "Hủy":
                    statusInt = 0;
                    break;
            }
        }
        public decimal getSUM()
        {
            decimal sum = 0;
            foreach (var item in laptops)
            {
                sum += item.QuantityImport * item.ImportPrice;
            }
            return sum;
        }
    }
}
