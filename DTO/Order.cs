﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DTO
{
    public class Order
    {
        private List<Laptop> laptop;
        public List<Laptop> Laptop
        {
            get { return laptop; }
            set { laptop = value; }
        }
        public Order()
        {
            laptop = new List<Laptop>(); 
        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private Staff accountant;
        public Staff Accountant
        {
            get { return accountant; }
            set { accountant = value; }
        }

        private Staff seller;
        public Staff Seller
        {
            get { return seller; }
            set { seller = value; }
        }

        private DateTime order_date;
        public DateTime Order_date
        {
            get { return order_date; }
            set { order_date = value; }
        }

        private int statusInt = 0;
        public int StatusInt
        {
            get { return statusInt; }
            set { statusInt = value; setStatusString(); }
        }

        private string statusString = "Chưa thanh toán";
        public string StatusString
        {
            get { return statusString; }
            set { statusString = value; setPaymentInt(); }
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
                    statusString = "Hủy";
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

        private DateTime update_status_time;
        public DateTime UpdateStatusTime
        {
            get { return update_status_time; }
            set { update_status_time = value; }
        }

        private int paymentInt = 0;
        public int PaymentInt
        {
            get { return paymentInt; }
            set { paymentInt = value; setPaymentString(); }
        }

        private string paymentString = "Tiền mặt";
        public string PaymentString
        {
            get { return paymentString; }
            set { paymentString = value; setPaymentInt(); }
        }

        private void setPaymentString()
        {
            switch (paymentInt)
            {
                case 0:
                    paymentString = "Tiền mặt";
                    break;
                case 1:
                    paymentString = "Chuyển khoản";
                    break;
            }
        }
        private void setPaymentInt()
        {
            switch (paymentString)
            {
                case "Tiền mặt":
                    paymentInt = 0;
                    break;
                case "Chuyển khoản":
                    paymentInt = 1;
                    break;
            }
        }
        
    }
}
