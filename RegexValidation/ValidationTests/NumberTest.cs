using NUnit.Framework;
using RegexValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationTests
{
    public class NumberTest
    {
        [Test]
        public void FirstNameTest()
        {
            Validation validation = new Validation();
            bool number = validation.MobileNumber_Validation("9456455566");
            Assert.IsTrue(number);
        }
    }
}
