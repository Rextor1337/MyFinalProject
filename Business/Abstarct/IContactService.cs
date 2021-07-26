using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();


        IDataResult<List<Contact>> GetById(int contactId);

        IResult Add(Contact contact);

        IResult Update(Contact contact);

        IResult AddTransactionalTest(Contact contact);


    }
}
