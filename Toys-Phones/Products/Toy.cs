using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys_Phones.Products
{
    internal class Toy : Product
    {
        private string Manufacturer;
        private string Material;

        public Toy(string name, double price, string manufacturer, string material, int age) : base(name, price, age)
        {
            Manufacturer = manufacturer;
            Material = material;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Toy: {Name}, Price: {Price}, Manufacturer: {Manufacturer}, Material: {Material}, Age: {Age}");
        }

        public override bool IsOfType(string type)
        {
            return type.ToLower() == "toy";
        }
    }
}
