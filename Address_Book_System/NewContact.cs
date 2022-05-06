using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    public class NewContact
    {

        public List<NewContact> ContactBook = new List<NewContact>();
        private string FirstName;
        private string LastName;
        private string City;
        private string State;
        private string ZipCode;
        private string PhoneNumber;
        private string E_Mail;

        public void createContactMethod()
        {
            NewContact obj = new NewContact();
            obj.FirstName = "Ankush";
            obj.LastName = "Rawat";
            obj.City = "Delhi";
            obj.State = "Delhi";
            obj.ZipCode = "110096";
            obj.PhoneNumber = "9876554321";
            obj.E_Mail = "ankushrwt344@gmail.com";
            ContactBook.Add(obj);
            Console.WriteLine("\nADDRESS BOOK Is Created ");
        }

        //Printing ContactBook
        public void printContact()
        {
            Console.WriteLine("\nPrinting Contact information ..................................\n");
            foreach (var obje in ContactBook)
            {
                Console.WriteLine("FirstName is " + obje.FirstName);
                Console.WriteLine("LastName is " + obje.LastName);
                Console.WriteLine("City is " + obje.City);
                Console.WriteLine("State is " + obje.State);
                Console.WriteLine("ZipCode is " + obje.ZipCode);
                Console.WriteLine("PhoneNumber is " + obje.PhoneNumber);
                Console.WriteLine("E_Mail is " + obje.E_Mail);
            }
        }
    }
}
