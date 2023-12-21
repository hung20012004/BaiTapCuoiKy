using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        private int id;
        private string name;
        private string username;
        private string password;
        private int role;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        { 
            get { return name; } 
            set {  name = value; } 
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
