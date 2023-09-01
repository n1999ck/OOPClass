using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Product : IProduct
    {
        public String Name { get; }
        public int Value { get; }
        public String Description { get { return Name + ", " + Value; } }

        public Product(string name, int value)
        {
            Name = name;
            Value = value;
        }

        override
        public String ToString()
        {
            return Description;
        }
    }
}
