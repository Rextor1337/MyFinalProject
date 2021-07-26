using Business.Abstarct;
using Business.BusinessAspects.AutoFac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
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
        
        [SecuredOperation(" contact.add , admin ")]
        [ValidationAspect(typeof(ContactValidator))]
        [CacheRemoveAspect("IContactService.Get")]


        public IResult Add(Contact contact)
        {
            IResult result = BusinessRules.Run(CheckIfContactNickExists(contact.ContactNick),
                CheckIfContactCountOfContactCorrect(contact.ContactId));
            if (result != null)
            {
                return result;
            }
            _contactDal.Add(contact);

            return new SuccessResult(Messages.ContactAdded);


            

        }

        [CacheAspect]

        public IDataResult<List<Contact>> GetAll()
        {


            {
                return new SuccessDataResult<List<Contact>>(_contactDal.GelAll(), Messages.ContactListed);
            }
        }

        public IDataResult<Contact> GetById(int contactId)
        {
            return new SuccessDataResult<Contact>(_contactDal.Get(p => p.ContactId == contactId));
        }

        [ValidationAspect(typeof(ContactValidator))]
        [CacheRemoveAspect("IContactService.Get")]

        public IResult Update(Contact contact)
        {
            var result = _contactDal.GelAll(p => p.ContactId == contact.ContactId).Count;

            if (result >= 15)
            {
                return new ErrorResult(Messages.ContactCountOfContactError);
            }
            throw new NotImplementedException();
        }

        [CacheAspect]

        IDataResult<List<Contact>> IContactService.GetById(int contactId)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfContactCountOfContactCorrect(int contactId)
        {
            var result = _contactDal.GelAll(p => p.ContactId == contactId).Count;

            if (result >= 15)
            {
                return new ErrorResult(Messages.ContactCountOfContactError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfContactNickExists(string contactNick)
        {
            var result = _contactDal.GelAll(p => p.ContactNick == contactNick).Any();

            if (result)
            {
                return new ErrorResult(Messages.ContactNickAlreadyExists);
            }
            return new SuccessResult();
        }
        
        

        public IResult AddTransactionalTest(Contact contact)
        {
            throw new NotImplementedException();
        }

        
        
    }

}

