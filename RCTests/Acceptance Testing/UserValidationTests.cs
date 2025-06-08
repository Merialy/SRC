using RCLibrary;
using RCLibrary.Entities;

namespace Acceptance_Testing
{
    [TestFixture]
    internal class UserValidationTests
    {
        private User user;

        [SetUp]
        public void Setup()
        {
            user = new UserSystem();
        }

        // FR06: Перевірка коректного email
        [Test]
        public void FR06_Email_ValidFormat_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => user.Email = "valid@example.com");
        }

        // FR06: Спроба ввести email без @
        [Test]
        public void FR06_Email_MissingAtSymbol_ShouldThrowArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => user.Email = "invalid.com");
            StringAssert.Contains("символ \"@\" та \".\"", ex.Message);
        }

        // FR06: Пустий email
        [Test]
        public void FR06_Email_Empty_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => user.Email = "");
        }

        // FR06: Пароль менше 8 символів
        [Test]
        public void FR06_Password_TooShort_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => user.Password = "short");
        }

        // FR06: Номер телефону не містить 10 цифр
        [Test]
        public void FR06_PhoneNumber_InvalidLength_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => user.PhoneNumber = "123456789");
        }
    }
}
