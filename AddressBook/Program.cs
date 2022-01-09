using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book program");

            AddressBookDict.addAddressBook();
            Console.WriteLine("\n");
            AddressBookDict.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBookDict.EditContact();
            Console.WriteLine("\n");
            AddressBookDict.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBookDict.ContactsDisplay();
            AddressBookDict.ContactsDisplay();
            AddressBookDict.ContactsDisplay();
            AddressBookDict.ContactsDisplay();
        }
    }
}