using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContactDal : IContactDal
    {
        public void Add(Contact entity)
        {
            using (ContactContext context=new ContactContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Contact entity)
        {
            using (ContactContext context = new ContactContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Contact> GelAll(Expression<Func<Contact, bool>> filter = null)
        {
            using (ContactContext context = new ContactContext())
            {
                return filter == null 
                    ? context.Set<Contact>().ToList() 
                    : context.Set<Contact>().Where(filter).ToList();
            }
        }

        public Contact Get(Expression<Func<Contact, bool>> filter)
        {
            using (ContactContext context = new ContactContext())
            {
                return context.Set<Contact>().SingleOrDefault(filter);
            }
        }

        public void Update(Contact entity)
        {
            using (ContactContext context = new ContactContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
