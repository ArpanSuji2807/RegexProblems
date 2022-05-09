using NUnit.Framework;
using RegexValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationTests
{
    internal class LastNameTest
    {
        [Test]
        public void FirstNameTest()
        {
            Validation validation = new Validation();
            bool name = validation.LastName_Validation("Suji");
            Assert.IsTrue(name);
        }
    }
}
