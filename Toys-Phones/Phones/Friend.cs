using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys_Phones.Phones
{
    internal class Friend : PhoneDirectory
    {
        private string BirthDate;

        public Friend(string lastName, string address, string phoneNumber, string birthDate) : base(lastName, address, phoneNumber)
        {
            BirthDate = birthDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Friend: Last Name: {LastName}, Address: {Address}, Phone Number: {PhoneNumber}, Birth Date: {BirthDate}");
        }

        public override bool MatchesSearchCriteria(string criteria)
        {
            return LastName.Contains(criteria);
        }
    }
}
