using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamTreeAddressBookGUI
{
    public class Contact
    {
        //vars
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string address { get; private set; }
        public string postalCode { get; private set; }
        public string city { get; private set; }
        public string country { get; private set; }
        public string province { get; private set; }
        public string email { get; private set; }
        //probably need different datatype
        public string relationship { get; private set; }
        public string phoneNumber { get; private set; }

        public Contact()
        {

        }

        public Contact(string firstName, string lastName, string address, string postalCode, string city, string country, string province, string email, string relationship, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
            this.province = province;
            this.email = email;
            this.relationship = relationship;
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + ", " +relationship;
        }
    }
}
