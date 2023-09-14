using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_console_application
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        //Method to add a contact to the contact list
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        //Method to display contacts by the number
        public void DisplayContact(string number)
        {
            Contact contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Oops! Contact not found");
                
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        //Method to display all contacts
        public void DisplayallContacts()
        {
            DisplayContactsDetails(_contacts);

        }
        //searching for a contacts for a given name
        public void DisplayMatchingContact(string searchPhrase)
        {
            //'matchingContacts' is of type IEnumerable<Contact>
            //var is used to declare a variable without explicitly
            //specifying its data type, and the compiler infers the
            //d ata type based on the assigned value or expression.
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
        public void DeleteContact(string number)
        {
            Contact contactToDelete = _contacts.FirstOrDefault(c => c.Number == number);
            if (contactToDelete == null)
            {
                Console.WriteLine("Oops! Contact not found");
            }
            else
            {
                _contacts.Remove(contactToDelete);
                Console.WriteLine("Contacts deleted succesfully.");

            }
        }
    }
}
