using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys_Phones.Phones
{
    internal class Organization : PhoneDirectory
    {
        private string Name;
        private string Fax;
        private string ContactPerson;

        public Organization(string name, string address, string phoneNumber, string fax, string contactPerson) : base("", address, phoneNumber)
        {
            Name = name;
            Fax = fax;
            ContactPerson = contactPerson;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Organization: Name: {Name}, Address: {Address}, Phone Number: {PhoneNumber}, Fax: {Fax}, Contact Person: {ContactPerson}");
        }

        public override bool MatchesSearchCriteria(string criteria)
        {
            return Name.Contains(criteria);
        }
    }
}
