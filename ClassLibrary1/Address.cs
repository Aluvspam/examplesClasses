using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Address
    {
        public string City;
        public string Street;
        public string ExtraInfo;

        public Address(string city, string street, string extraInfo)
        {
            City = city;
            Street = street;
            ExtraInfo = extraInfo; 
        }
    }
}
