using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexValidation
{
    public class UserCustomException:Exception
    {
        public enum CustomException
        {
            FIRSTNAME_NOT_VALID, LASTNAME_NOT_VALID, MOBILENUMBER_NOT_VALID, PASSWORD_NOT_VALID, EMAILID_NOT_VALID,
        }
        public CustomException customException;
        public UserCustomException(CustomException exception,string message): base(message)
        {
            this.customException = exception;
        }
    }
}
