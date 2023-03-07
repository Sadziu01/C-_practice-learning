using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>(); 

        public void AddContact(Contact contact)
        {
            if(contact.Number == null || contact.Name == null)
            {
                Console.WriteLine("Contact adding failed.");
            }
            else
            {
                Contacts.Add(contact);
            }
        }


        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }



        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(x => x.Number == number);

            if (contact != null)
            {
                DisplayContactDetails(contact);
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }


        public void DeleteContactByNumber(string number)
        {
            var deleteContact = Contacts.FirstOrDefault(c => c.Number == number);

            Contacts.Remove(deleteContact);
        }


        public void DisplayAllContacts()
        {
            DisplayContactsDetails(Contacts);
        }


        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);

        }
    }
}
