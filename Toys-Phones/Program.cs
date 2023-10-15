using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toys_Phones.Phones;
using Toys_Phones.Products;

namespace Toys_Phones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneListTest();
        }
        static void ProductTest()
        {
            Product[] products = new Product[]
        {
            new Toy("Teddy", 19.99, "Toys", "Plush", 3),
            new Book("Navis Nigra", 14.99, "Alexander Tinyakov", "Gryph", 12),
            new SportsEquipment("Gi", 49.99, "As.Brothers", 10)
        };

            Console.WriteLine("All Products:");
            foreach (Product product in products)
            {
                product.DisplayInfo();
            }

            Console.WriteLine("\nSearch Results (Type: Toy):");
            foreach (Product product in products)
            {
                if (product.IsOfType("toy"))
                {
                    product.DisplayInfo();
                }
            }
        }
        static void PhoneListTest()
        {
            PhoneDirectory[] entries = new PhoneDirectory[]
        {
            new Person("Smith", "SomeWhere", "333-333"),
            new Organization("YobaCorp", "Bitardstan", "555-5678", "555-9876", "John Doe"),
            new Friend("Johnson", "777 east alley", "555-4321", "09/09/1990"),
        };

            Console.WriteLine("All Entries:");
            foreach (PhoneDirectory entry in entries)
            {
                entry.DisplayInfo();
            }

            Console.WriteLine("\nSearch Results (Last Name: Smith):");
            foreach (PhoneDirectory entry in entries)
            {
                if (entry.MatchesSearchCriteria("Smith"))
                {
                    entry.DisplayInfo();
                }
            }
        }
    }
}
