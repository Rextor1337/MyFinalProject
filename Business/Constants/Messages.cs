using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ContactAdded = "Kişi eklendi";
        public static string ContactNickInvalid = "Kişi ismi geçersiz";
        
        internal static string ContactListed="Kişiler listelendi";
        internal static string ContactCountOfContactError = "Bir kişi listesinde en fazla 10 kişi olabilir";
        internal static string ContactNickAlreadyExists = "Bu isimde zaten başka bir kişi var";
    }
}
