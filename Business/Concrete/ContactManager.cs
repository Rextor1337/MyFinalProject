using Business.Abstarct;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        
           

        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);

            if (contact.ContactNick.Length<2)
            {
                return new ErrorResult(Messages.ContactNickInvalid);
            }


            return new SuccessResult(Messages.ContactAdded);
        }

        public IDataResult<List<Contact>> GetAll()
        {
            

            {
                return new SuccessDataResult<List<Contact>>(_contactDal.GelAll(),Messages.ContactListed);
            }
        }

        public IDataResult<Contact> GetById(int contactId)
        {
            return new SuccessDataResult<Contact>( _contactDal.Get(p=>p.ContactId == contactId));
        }

        IDataResult<List<Contact>> IContactService.GetById(int contactId)
        {
            throw new NotImplementedException();
        }
    }
}
