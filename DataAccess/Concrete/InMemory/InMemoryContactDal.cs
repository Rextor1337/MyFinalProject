using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryContactDal : IContactDal
    {
        List<Contact> _contacts;
        public InMemoryContactDal()
        {
            _contacts = new List<Contact>
            {
                //new Contact{ContactId=1,ContactNick="Rseat",ContactName="Resat123",ContactSurname="Onur",ContactNumber="12312311",ContactRelation="is",ContactMail="onur@",ContactAdress="erenkoy",ContactAdditionalNotes="galerici"},
                //new Contact{ContactId=2,ContactNick="Ruslan",ContactName="Roslan",ContactSurname="turkmenovic",ContactNumber="2131421435",ContactRelation="developer",ContactMail="rosr@",ContactAdress="esenler",ContactAdditionalNotes="yazilim"},

                //new Contact{ContactId=3,ContactNick="Musti1",ContactName="Musti",ContactSurname="Onur",ContactNumber="2314124131",ContactRelation="is",ContactMail="onur2321@",ContactAdress="erenkoy2",ContactAdditionalNotes="galerici2"},

            };
        }
        public void Add(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void Delete(Contact contact)
        {
            

            Contact contactToDelete = _contacts.SingleOrDefault(p=>p.ContactId == contact.ContactId);

            _contacts.Remove(contact);
        }

        public List<Contact> GelAll()
        {
            return _contacts;
        }

        public List<Contact> GelAll(Expression<Func<Contact, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Contact Get(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            Contact contactToUpdate = _contacts.SingleOrDefault(p => p.ContactId == contact.ContactId);
            contactToUpdate.ContactNick = contact.ContactNick;
            contactToUpdate.ContactId = contact.ContactId;
            contactToUpdate.ContactMail = contact.ContactMail;
            contactToUpdate.ContactSurname = contact.ContactSurname;
            contactToUpdate.ContactRelation = contact.ContactRelation;
            contactToUpdate.ContactNumber = contact.ContactNumber;
            contactToUpdate.ContactAddress = contact.ContactAddress;
            contactToUpdate.ContactAdditionalNotes = contact.ContactAdditionalNotes;
            contactToUpdate.ContactName = contact.ContactName;




        }
    }
}
