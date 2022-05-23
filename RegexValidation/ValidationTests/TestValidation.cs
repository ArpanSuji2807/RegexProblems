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
            try
            {
                Validation validation = new Validation();
                bool name = validation.FirstName_Validation("Arpan");
            }
            catch(UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "First name is not valid");
            }
        }
        [Test]
        public void GivenLastNameAsInput_WhenTestValidation_ShouldReturnLastName()
        {
            try
            {
                Validation validation = new Validation();
                bool name = validation.LastName_Validation("Suji");
            }
            catch (UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Last name is not valid");
            }
        }
        [Test]
        public void GivenPhoneNumberAsInput_WhenTestValidation_ShouldReturnPhoneNumber()
        {
            try
            {
                Validation validation = new Validation();
                bool number = validation.MobileNumber_Validation("9456455566");
            }
            catch(UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Mobile number is not valid");
            }
        }
        [Test]
        public void GivenEmailAsInput_WhenTestValidation_ShouldReturnEmail()
        {
            try
            {
                Validation validation = new Validation();
                bool email = validation.Email_Validation("abc@gmail.com");
            }
            catch(UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Email is not valid");
            }
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPassword()
        {
            try
            {
                Validation validation = new Validation();
                bool password = validation.Password_Validation("abcd1234545");
            }
            catch(UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Password is not valid");
            }
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneUpperCase()
        {
            try
            {
                Validation validation = new Validation();
                bool password = validation.PasswordValidation_WithOneUpperCase("Arabc");
            }
            catch (UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Password is not valid");
            }
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneNumericValue()
        {
            try
            {
                Validation validation = new Validation();
                bool password1 = validation.PasswordValidation_WithOneNumericNumber("Arr1236");
            }
            catch(UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Password is not valid");
            }
        }
        [Test]
        public void GivenPasswordAsInput_WhenTestValidation_ShouldReturnPasswordWithOneSpecialCharacter()
        {
            try
            {
                Validation validation = new Validation();
                bool password2 = validation.PasswordValidation_WithOneSpecialCharacter("Ar28@");
            }
            catch(UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Password is not valid");
            }
        }
        [Test]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc+100@gmail.com")]
        [TestCase("abc@yahoo.com")]
        public void GivenEmailAsInput_WhenParameterizedTestValidation_ShouldReturnAllEmailSamples(string email)
        {
            try
            {
                Validation validation = new Validation();
                bool actual = validation.MultipleEmailValidationParameterized(email);
            }
            catch(UserCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Email is not valid");
            }
        }
    }
}
