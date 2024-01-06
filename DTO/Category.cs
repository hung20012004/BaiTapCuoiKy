using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Category
    {
        private int id= 0;
        public int ID { 
            get { return id; } 
            set { if (value != null) id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
