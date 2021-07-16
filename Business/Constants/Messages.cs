using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ContactAdded = "Kişi eklendi";
        public static string ContactNickInvalid = "Kişi ismi geçersiz";
        
        public static string ContactListed="Kişiler listelendi";
        public static string ContactCountOfContactError = "Bir kişi listesinde en fazla 10 kişi olabilir";
        public static string ContactNickAlreadyExists = "Bu isimde zaten başka bir kişi var";
        public  static string  AuthorizationDenied= "Yetkiniz yok";
    }
}
