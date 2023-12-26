using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        private int order_id;
        private int customer_id;
        private int accountant_id;
        private int seller_id;
        private int laptop_id;
        private decimal price;
        private int quantity;
        private DateTime date;
        private int status;

        private DateTime order_date;
        public int Order_ID
        {
            get { return order_id ; }
            set { order_id = value; }
        }
        public int Laptop_ID
        {
            get { return laptop_id; }
            set { laptop_id = value; }
        }
        public int Accountant_ID
        {
            get { return accountant_id; }
            set { accountant_id = value; }
        }
        public int Customer_ID
        {
            get { return customer_id; }
            set { customer_id = value; }
        }
        public int Seller_ID
        {
            get { return seller_id; }
            set { seller_id = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public DateTime DATE
        {
            get { return date; }
            set { date = value; }
        }
        public int STATUS
        {
            get { return status; }
            set { status = value; }
        }
    }
}
