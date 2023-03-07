using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class Contact
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                if(value.Length < 3)
                {
                    Console.WriteLine("Invalid contact name");
                }
                else
                {
                    _name = value;
                }
            }
        }

        private string _number;
        public string Number
        {
            get { return _number; }
            set 
            {
                if(value.Length == 9)
                {
                    _number = value;
                }
                else
                {
                    Console.WriteLine("Invalid contact number");
                }
            }
        }

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}
