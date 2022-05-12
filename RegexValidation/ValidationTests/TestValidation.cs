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
        public void GivenFirstNameAsInput_WhenTestValidation_ShouldReturnFirstName()
        {
            Validation validation = new Validation();
            bool name = validation.FirstName_Validation("Arpan");
            Assert.IsTrue(name);
        }
        [Test]
        public void GivenLastNameAsInput_WhenTestValidation_ShouldReturnLastName()
        {
            Validation validation = new Validation();
            bool name = validation.LastName_Validation("Suji");
            Assert.IsTrue(name);
        }
        [Test]
        public void GivenPhoneNumberAsInput_WhenTestValidation_ShouldReturnPhoneNumber()
        {
            Validation validation = new Validation();
            bool number = validation.MobileNumber_Validation("9456455566");
            Assert.IsTrue(number);
        }
        [Test]
        public void GivenEmailAsInput_WhenTestValidation_ShouldReturnEmail()
        {
            Validation validation = new Validation();
            bool email = validation.Email_Validation("abc@gmail.com");
            Assert.IsTrue(email);
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPassword()
        {
            Validation validation = new Validation();
            bool password = validation.Password_Validation("abcd1234545");
            Assert.IsTrue(password);
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneUpperCase()
        {
            Validation validation = new Validation();
            bool password = validation.PasswordValidation_WithOneUpperCase("Arabc");
            Assert.IsTrue(password);
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneNumericValue()
        {
            Validation validation = new Validation();
            bool password1 = validation.PasswordValidation_WithOneNumericNumber("Arr1236");
            Assert.IsTrue(password1);
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneSpecialCharacter()
        {
            Validation validation = new Validation();
            bool password2 = validation.PasswordValidation_WithOneSpecialCharacter("Ar28@");
            Assert.IsTrue(password2);
        }
        [Test]
        public void GivenEmailAsInput_WhenTestValidation_ShouldReturnAllEmailSamples()
        {
            Validation validation = new Validation();
            bool email = validation.AllEmailSamplesValidation("abc.100@abc.com.au");
            Assert.IsTrue(email);
        }
    }
}
