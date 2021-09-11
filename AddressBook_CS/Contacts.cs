using System;

namespace AddressBook_CS
{/// <summary>
/// Template for Address Book Program
/// </summary>
    class Contacts
    {   //Uc1 to create contact in an address book
        //Declaring instance variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string email;
        public int phoneNumber;

        //Parameterized constructor
        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, int phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Address Book");
            Console.ReadLine();
        }
    }
}
