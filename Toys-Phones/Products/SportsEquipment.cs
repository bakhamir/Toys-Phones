using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys_Phones.Products
{
    internal class SportsEquipment : Product
    {
        private string Manufacturer;

        public SportsEquipment(string name, double price, string manufacturer, int age) : base(name, price, age)
        {
            Manufacturer = manufacturer;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Sports Equipment: {Name}, Price: {Price}, Manufacturer: {Manufacturer}, Age: {Age}");
        }

        public override bool IsOfType(string type)
        {
            return type.ToLower() == "sports equipment";
        }
    }
}
