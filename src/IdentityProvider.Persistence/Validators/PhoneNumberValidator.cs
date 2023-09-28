using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Persistence.Validators
{
    public class PhoneNumberValidator
    {
        public static bool PhoneNumber(string phoneNumber)
        {
            if(phoneNumber.Length!= 13)
            {
                return false;
            }

            if(phoneNumber.StartsWith("+998") != true) 
            {
                return false;
            }

            for (int i = 1;  i< phoneNumber.Length; i++) 
            {
                if (char.IsDigit(phoneNumber[i]) == false )
                {
                    return false;
                }
            }
            return true;    
        }
    }
}
