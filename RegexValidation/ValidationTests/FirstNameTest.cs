using NUnit.Framework;
using RegexValidation;

namespace ValidationTests
{
    public class Tests
    {
        [Test]
        public void FirstNameTest()
        {
            Validation validation = new Validation();
            bool name = validation.FirstName_Validation("Arpan");
            Assert.IsTrue(name);
        }
    }
}