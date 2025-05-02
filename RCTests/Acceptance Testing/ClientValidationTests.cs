using RCLibrary.Entities;

namespace Acceptance_Testing
{
    [TestFixture]
    internal class ClientValidationTests
    {
        private Client client;

        [SetUp]
        public void Setup()
        {
            client = new Client();
        }

        // FR06: Коректний формат водійських прав (ABC-123456)
        [Test]
        public void FR06_DriverLicense_ValidFormat_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => client.DriverLicense = "ABC-123456");
        }

        // FR06: Невірний формат прав
        [Test]
        public void FR06_DriverLicense_InvalidFormat_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => client.DriverLicense = "123-ABC");
        }

        // FR10: Клієнт старше 18 років
        [Test]
        public void FR10_BirthDate_Adult_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => client.BirthDate = DateTime.Now.AddYears(-20));
        }

        // FR10: Клієнт молодше 18 років
        [Test]
        public void FR10_BirthDate_Under18_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => client.BirthDate = DateTime.Now.AddYears(-17));
        }
    }
}
