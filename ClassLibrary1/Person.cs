using System;

namespace ClassLibrary1
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public Address Address { get; set; }
        public Sex Sex { get; set; }

        public Person(string name, DateTime dob, Address address)
        {
            Name = name;
            DOB = dob;
            Address = address;
        }

        public Person()
        {
        }

        public void ChangeAddress(Address newAddress)
        {
            Address = newAddress;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
