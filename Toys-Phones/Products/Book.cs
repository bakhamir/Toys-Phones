using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys_Phones.Products
{
    internal class Book : Product
    {
        private string Author;
        private string Publisher;

        public Book(string name, double price, string author, string publisher, int age) : base(name, price, age)
        {
            Author = author;
            Publisher = publisher;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Name}, Price: {Price}, Author: {Author}, Publisher: {Publisher}, Age: {Age}");
        }

        public override bool IsOfType(string type)
        {
            return type.ToLower() == "book";
        }
    }
}
