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

            var result = contactManager.GetAll();

            if (result.Success == true)
            {
                foreach (var contact in result.Data)
                {
                    Console.WriteLine(contact.ContactNick + "/" + contact.ContactName);

                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}
