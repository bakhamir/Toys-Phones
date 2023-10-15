using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys_Phones.Products
{
    abstract class Product
    {
        protected string Name;
        protected double Price;
        protected int Age;

        public Product(string name, double price, int age)
        {
            Name = name;
            Price = price;
            Age = age;
        }

        public abstract void DisplayInfo();

        public abstract bool IsOfType(string type);
    }
}
