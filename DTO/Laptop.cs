using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Laptop
    {
        private int laptop_id;
        private string laptop_name;
        private int category_id;
        private int manufactory_id;
        private string cpu;
        private string ram;
        private string hard_drive;
        private string vga;
        private string display;
        private string battery;
        private float weight;
        private string materials;
        private string ports;
        private string network_and_connection;
        private string security;
        private string keyboard;
        private string audio;
        private string size;
        private string os;
        private string warranty_period;
        private decimal price;
        private int quantity;
        public int Laptop_ID
        {
            get { return laptop_id; }
            set { laptop_id = value; }
        }
        public string Laptop_Name
        {
            get { return laptop_name; }
            set { laptop_name = value; }
        }
        public int Category_ID
        {
            get { return category_id; }
            set { category_id = value; }
        }
        public int Manufactory_ID
        {
            get { return manufactory_id; }
            set { manufactory_id = value; }
        }
        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }
        public string RAM
        {
            get { return ram; }
            set { ram = value; }
        }
        public string Hard_Drive
        {
            get { return hard_drive; }
            set { hard_drive = value; }
        }
        public string VGA
        {
            get { return vga; }
            set { vga = value; }
        }
        public string Display
        {
            get { return display; }
            set { display = value; }
        }
        public string Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Materials
        {
            get { return materials; }
            set { materials = value; }
        }
        public string Ports
        {
            get { return ports; }
            set { ports = value; }
        }
        public string Network_And_Connection
        {
            get { return network_and_connection; }
            set { network_and_connection = value; }
        }
        public string Security
        {
            get { return security; }
            set { security = value; }
        }
        public string Keyboard
        {
            get { return keyboard; }
            set { keyboard = value; }
        }
        public string Audio
        {
            get { return audio; }
            set { audio = value; }
        }
        public string Size
        {
            get { return size; }
            set { size  = value; }
        }
        public string OS
        {
            get { return os; }
            set { os = value; }
        }
        public string Warranty_Period
        {
            get { return warranty_period; }
            set { warranty_period = value; }
        }
        public decimal  Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity   = value; }
        }
    }
}