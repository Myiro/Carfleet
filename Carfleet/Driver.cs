using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carfleet
{
    public class Driver
    {
        private string _name;
        private string _firstname;
        private string _city;
        private string _phoneNumber;
        private string _emailAddress;
        private string _language;

        public Driver(string name, string firstname, string city, string phoneNumber, string emailAddress, string language = "")
        {
            _name = name;
            _firstname = firstname;
            _city = city;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
            _language = language;
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
        }
    }
}
