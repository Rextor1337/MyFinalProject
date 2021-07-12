using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactManager contactManager = new ContactManager(new EfContactDal());

            
            foreach (var contact in contactManager.GetAll())
            {
                Console.WriteLine(contact.ContactNick);
                Console.WriteLine(contact.ContactName);

            }


        }
    }
}
