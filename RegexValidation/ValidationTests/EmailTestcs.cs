using NUnit.Framework;
using RegexValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationTests
{
    public class EmailTestcs
    {
        [Test]
        public void EmailTest()
        {
            Validation validation = new Validation();
            bool email = validation.Email_Validation("abc@gmail.com");
            Assert.IsTrue(email);
        }
    }
}
