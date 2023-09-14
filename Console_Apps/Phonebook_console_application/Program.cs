using System;
using System.ComponentModel.DataAnnotations;

namespace Phonebook_console_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Reggy's Console Phonebook App");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 Search for contacts for a given name");
            Console.WriteLine("5 Delete contact for a given number");
            Console.WriteLine("Press 'x' to exit");

            var userOperation = Console.ReadLine();

            //create a phonebook object
            PhoneBook phonebook = new PhoneBook();
            while (true)
            {
                switch (userOperation)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Contact number");
                        string number = Console.ReadLine();

                        Contact newContact = new Contact(name, number);
                        phonebook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Please enter contact number to search");
                        string searchnum = Console.ReadLine();
                        phonebook.DisplayContact(searchnum);

                        break;

                    case "3":
                        phonebook.DisplayallContacts();
                        break;

                    case "4":
                        Console.WriteLine("Please enter the name search phrase");
                        string searchphrase = Console.ReadLine();
                        phonebook.DisplayMatchingContact(searchphrase);
                        break;

                    case "5":
                        Console.WriteLine("Please enter the number to delete");
                        string numTodelete = Console.ReadLine();
                        phonebook.DeleteContact(numTodelete);
                        break;

                    case "x":
                        Console.WriteLine("Thank you for using Reggy's application");
                        return;

                    default: //whenever a user enters a wrong operation
                        Console.WriteLine("Select valid operation");
                        break;

                }
                Console.WriteLine("Selection operation");
                userOperation = Console.ReadLine();
            
            }

        }
    }
}