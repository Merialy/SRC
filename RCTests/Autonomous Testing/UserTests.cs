using RCLibrary.Entities;

namespace Autonomous_Testing
{
    [TestFixture] // ToDo #4.6 Тести абстрактного класу User
    internal class UserTests
    {
        private class TestUser : User
        {
            public override bool Serialize() => true;
            public override bool Deserialize() => true;
        }

        [Test] //TCU01
        public void TCU01_TypeClass_CanBeSetAndGet()
        {
            var user = new TestUser();
            user.TypeClass = "Адміністратор";
            Assert.That(user.TypeClass, Is.EqualTo("Адміністратор"));
        }

        [Test] //TCU02
        public void TCU02_Email_EmptyOrNull_ThrowsArgumentException()
        {
            var user = new TestUser();
            Assert.Throws<ArgumentException>(() => user.Email = "");
            Assert.Throws<ArgumentException>(() => user.Email = null);
        }

        [Test] //TCU03
        public void TCU03_Email_InvalidFormats_ThrowsArgumentException()
        {
            var user = new TestUser();
            Assert.Throws<ArgumentException>(() => user.Email = "invalid");
            Assert.Throws<ArgumentException>(() => user.Email = "invalid@");
            Assert.Throws<ArgumentException>(() => user.Email = "invalid@domain");
            Assert.Throws<ArgumentException>(() => user.Email = "invalid@domain.");
        }

        [Test] //TCU04
        public void TCU04_Email_MixedCase_ConvertsToLowercase()
        {
            var user = new TestUser();
            user.Email = "TesT@ExAmPle.CoM";
            Assert.That(user.Email, Is.EqualTo("test@example.com"));
        }

        [Test] //TCU05
        public void TCU05_Email_ValidFormats_SetsValue()
        {
            var user = new TestUser();
            user.Email = "valid@example.com";
            Assert.That(user.Email, Is.EqualTo("valid@example.com"));

            user.Email = "ANOTHER@EXAMPLE.COM";
            Assert.That(user.Email, Is.EqualTo("another@example.com"));
        }

        [TestCase("Іванов")] //TCU06
        [TestCase("Петров-Ва")]
        public void TCU06_LastName_ValidValues_SetsValue(string lastName)
        {
            var user = new TestUser();
            user.LastName = lastName;
            Assert.That(user.LastName, Is.EqualTo(lastName));
        }

        [TestCase("")] //TCU07
        [TestCase("Іван0в")]
        [TestCase("123")]
        public void TCU07_LastName_InvalidValues_ThrowsArgumentException(string lastName)
        {
            var user = new TestUser();
            Assert.Throws<ArgumentException>(() => user.LastName = null);
            Assert.Throws<ArgumentException>(() => user.LastName = lastName);
        }

        [Test] //TCU08
        public void TCU08_MiddleName_EmptyOrNull_BecomesDefault()
        {
            var user = new TestUser();
            user.MiddleName = "";
            Assert.That(user.MiddleName, Is.EqualTo("-"));

            user.MiddleName = null;
            Assert.That(user.MiddleName, Is.EqualTo("-"));
        }

        [Test] //TCU09
        public void TCU09_MiddleName_ValidValue_SetsValue()
        {
            var user = new TestUser();
            user.MiddleName = "Іванович";
            Assert.That(user.MiddleName, Is.EqualTo("Іванович"));
        }

        [Test] //TCU10
        public void TCU10_MiddleName_WithDigits_ThrowsArgumentException()
        {
            var user = new TestUser();
            Assert.Throws<ArgumentException>(() => user.MiddleName = "Іван0вич");
        }

        [TestCase("1234567890")] //TCU11
        [TestCase("0987654321")]
        public void TCU11_PhoneNumber_ValidValues_SetsValue(string phone)
        {
            var user = new TestUser();
            user.PhoneNumber = phone;
            Assert.That(user.PhoneNumber, Is.EqualTo(phone));
        }

        [TestCase("")] //TCU12
        [TestCase("123")]
        [TestCase("12345678901")]
        public void TCU12_PhoneNumber_InvalidValues_ThrowsArgumentException(string phone)
        {
            var user = new TestUser();
            Assert.Throws<ArgumentException>(() => user.PhoneNumber = null);
            Assert.Throws<ArgumentException>(() => user.PhoneNumber = phone);
        }

        [TestCase("ValidPass1")] //TCU13
        [TestCase("LongerPassword123")]
        public void TCU13_Password_ValidValues_SetsValue(string password)
        {
            var user = new TestUser();
            user.Password = password;
            Assert.That(user.Password, Is.EqualTo(password));
        }

        [TestCase("")] //TCU14
        [TestCase("short")]
        [TestCase("1234567")]
        public void TCU14_Password_InvalidValues_ThrowsArgumentException(string password)
        {
            var user = new TestUser();
            Assert.Throws<ArgumentException>(() => user.Password = null);
            Assert.Throws<ArgumentException>(() => user.Password = password);
        }

        [Test] //TCU15
        public void TCU15_ToString_WithMiddleName_ReturnsCorrectFormat()
        {
            var user = new TestUser
            {
                LastName = "Іванов",
                FirstName = "Іван",
                MiddleName = "Іванович"
            };

            Assert.That(user.ToString(), Is.EqualTo("Іванов І.І."));
        }

        [Test] //TCU16
        public void TCU16_ToString_WithoutMiddleName_ReturnsCorrectFormat()
        {
            var user = new TestUser
            {
                LastName = "Іванов",
                FirstName = "Іван",
                MiddleName = ""
            };

            Assert.That(user.ToString(), Is.EqualTo("Іванов І.-."));
        }

        [Test] //TCU17
        public void TCU17_FirstLetter_ReturnsCorrectValue()
        {
            var user = new TestUser();

            var method = typeof(User).GetMethod("FirstLetter",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            Assert.IsNotNull(method);

            var result1 = method.Invoke(user, new object[] { "Іван" });
            Assert.That(result1, Is.EqualTo("І"));

            var result2 = method.Invoke(user, new object[] { "" });
            Assert.That(result2, Is.EqualTo(""));
        }
    }
}
