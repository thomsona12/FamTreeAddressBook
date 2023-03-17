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
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string address { get; set; }
        private string postalCode { get; set; }
        private string city { get; set; }
        private string country { get; set; }
        private string province { get; set; }
        private string email { get; set; }
        //probably need different datatype
        private string relationship { get; set; }
        private string phoneNumber { get; set; }

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
    }
}
