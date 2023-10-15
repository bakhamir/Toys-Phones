using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys_Phones.Phones
{
    internal class Person : PhoneDirectory
    {
        public Person(string lastName, string address, string phoneNumber) : base(lastName, address, phoneNumber)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Person: Last Name: {LastName}, Address: {Address}, Phone Number: {PhoneNumber}");
        }

        public override bool MatchesSearchCriteria(string criteria)
        {
            return LastName.Contains(criteria);
        }
    }
}
