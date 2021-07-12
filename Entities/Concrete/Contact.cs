using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public  class Contact:IEntity
    {
        public int ContactId { get; set; }
        public string ContactNick { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }

        public string ContactNumber { get; set; }
        public string ContactMail { get; set; }
        public string ContactRelation { get; set; }
        public string ContactAddress { get; set; }
        public string ContactAdditionalNotes { get; set; }

    }
}
