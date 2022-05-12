using NUnit.Framework;
using RegexValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationTests
{
    public class TestValidation
    {
        [Test]
        public void FirstNameTest()
        {
            Validation validation = new Validation();
            bool name = validation.FirstName_Validation("Arpan");
            Assert.IsTrue(name);
        }
        [Test]
        public void Last_NameTest()
        {
            Validation validation = new Validation();
            bool name = validation.LastName_Validation("Suji");
            Assert.IsTrue(name);
        }
        [Test]
        public void Number_Test()
        {
            Validation validation = new Validation();
            bool number = validation.MobileNumber_Validation("9456455566");
            Assert.IsTrue(number);
        }
        [Test]
        public void EmailTest()
        {
            Validation validation = new Validation();
            bool email = validation.Email_Validation("abc@gmail.com");
            Assert.IsTrue(email);
        }
        [Test]
        public void Password_Test()
        {
            Validation validation = new Validation();
            bool password = validation.Password_Validation("abcd1234545");
            Assert.IsTrue(password);
        }
        [Test]
        public void PasswordTest_WithOneUpperCase()
        {
            Validation validation = new Validation();
            bool password = validation.PasswordValidation_WithOneUpperCase("Arabc");
            Assert.IsTrue(password);
        }
        [Test]
        public void PasswordTest_WithOneNumericNumber()
        {
            Validation validation = new Validation();
            bool password = validation.PasswordValidation_WithOneNumericNumber("Ar123");
            Assert.IsTrue(password);
        }
        [Test]
        public void PasswordTest_WithOneSpecialCharacter()
        {
            Validation validation = new Validation();
            bool password = validation.PasswordValidation_WithOneSpecialCharacter("Ar28@");
            Assert.IsTrue(password);
        }
        [Test]
        public void AllEmailSamplesTest()
        {
            Validation validation = new Validation();
            bool email = validation.AllEmailSamplesValidation("abc.100@abc.com.au");
            Assert.IsTrue(email);
        }
    }
}
