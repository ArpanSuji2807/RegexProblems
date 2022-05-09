using NUnit.Framework;
using RegexValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationTests
{
    public class PasswordTest
    {
        [Test]
        public void Password_Test()
        {
            Validation validation = new Validation();
            bool password = validation.Password_Validation("abcd1234545");
            Assert.IsTrue(password);
        }
    }
}
