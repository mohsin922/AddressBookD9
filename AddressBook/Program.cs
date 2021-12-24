using System;
using System.Collections.Generic;

namespace AddressBook
{
    class AddressBook
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book!");
            PersonalDetails.InputDetails();
        }
    }
    class PersonalDetails
    {
        public static void InputDetails()
        {
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            var Address = Console.ReadLine();

            Console.Write("Enter City : ");
            string city = Console.ReadLine();

            Console.Write("Enter State : ");
            string state = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            string zipCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter EmailId: ");
            string Email = Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            List<string> PersonAdressBook = new List<string>();

            PersonAdressBook.Add(firstname);
            PersonAdressBook.Add(lastName);
            PersonAdressBook.Add(Address);
            PersonAdressBook.Add(city);
            PersonAdressBook.Add(state);
            PersonAdressBook.Add(zipCode);
            PersonAdressBook.Add(phoneNumber);
            PersonAdressBook.Add(Email);

            foreach (string s in PersonAdressBook)
            {
                Console.WriteLine(s);
            }


        }
    }
}