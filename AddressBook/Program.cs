using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book program");

            AddressBookDict.addAddressBook();
            AddressBookDict.PersonSearch();
        }
    }
}