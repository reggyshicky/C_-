using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_console_application
{
    public class Contact
    {
        //this is like def __init__() in python, the constructor in the Contact class is used to 
        //initialize instances of the class by setting the initial values of the Name and Number properties.
        //It provides a convenient way to create and initialize Contact objects, encapsulating the
        //initialization logic within the class.
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;

        }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
