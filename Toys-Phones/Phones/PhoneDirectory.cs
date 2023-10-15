using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys_Phones.Phones
{
    abstract class PhoneDirectory
    {
        protected string LastName;
        protected string Address;
        protected string PhoneNumber;

        public PhoneDirectory(string lastName, string address, string phoneNumber)
        {
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public abstract void DisplayInfo();

        public abstract bool MatchesSearchCriteria(string criteria);
    }
}
